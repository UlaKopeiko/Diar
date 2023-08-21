using Diary.Entities;
using Diary.UI.UC;
using Microsoft.Office.Interop.Word;
using Nest;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowTestPassing.xaml
    /// </summary>

    public partial class WindowTestPassing : System.Windows.Window
    {
        Employee _currentEmployee = new Employee();
        int sum = new int();
        FormulaForTest formulaForTest = new FormulaForTest();
        Entities.Result result = new Entities.Result();
        Test _currentTest = new Test();
        public static int evaluation = new int();
        public static int numberOfFactor = new int();
        public static int rt = new int();
        public static int lt = new int();
        private int time = 300;
        private DispatcherTimer Timer;

        public WindowTestPassing(Test test, Employee employee)
        {
            _currentEmployee = employee;
            _currentTest = test;
            InitializeComponent();
            var warning = _currentTest.Warning;
            formulaForTest = App.DataBase.FormulaForTests.Where(p=>p.Test == _currentTest.ID).FirstOrDefault();
            numberOfFactor = (int)formulaForTest.Formula;
            result = App.DataBase.Results.Where(p => p.Test == _currentTest.ID).FirstOrDefault();
            WindowMessage.Show("Предупреждение", $"{warning}");


            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SavingTheResult();
        }

        private void SavingTheResult()
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy");
            var fileName = $"{_currentEmployee.LastName}_{_currentTest.Title}_{date}";
            var application = new Word.Application();
            Word.Document document = application.Documents.Add();
            for (int i = 0; i < ListQuestion.Items.Count; i++)
            {
               
                Entities.Question printList = (Question)ListQuestion.Items[i];
                Word.Paragraph paragraph = document.Paragraphs.Add();
                Word.Range range = paragraph.Range;
                range.Text = $"{printList.Text}";
                if (printList.Factor == 1)
                {
                   range.Text += $": {printList.rt}";
                }
                else
                {
                    range.Text += $": {printList.lt}";
                }
                range.InsertParagraphAfter();
            }
            var sum = UCQuestion.evaluation;
            sum += 35;
            string comment = string.Empty;
            if (sum < result.LowThreshold)
                comment = result.LowValue;
            if (sum >= result.LowThreshold && evaluation <= result.HighЕhreshold)
                comment = result.MediumValue;
            if (sum > result.HighЕhreshold)
                comment = result.HighValue;
            Journal journal = new Journal();
            journal.Date = DateTime.Now;
            journal.Test = _currentTest.ID;
            journal.Employee = _currentEmployee.ID;
            journal.Result = Convert.ToString(sum);
            Word.Paragraph paragraphSum = document.Paragraphs.Add();
            Word.Range rangeSum = paragraphSum.Range;
            rangeSum.Text = "Количество баллов: ";
            rangeSum.Text += $"{sum}";
            Word.Paragraph paragraphResult = document.Paragraphs.Add();
            Word.Range rangeResult = paragraphResult.Range;
            rangeResult.Text = "Результат: ";
            rangeResult.Text += $"{comment}";
            rangeResult.InsertParagraphAfter();
            document.SaveAs($@"C:\Users\Professional\Desktop\{fileName}.pdf", Word.WdExportFormat.wdExportFormatPDF);
            WindowMessage.Show("Предупреждение", "Спасибо за прохождение");


            string path = $@"C:\Users\Professional\Desktop\{fileName}.pdf";
            string flName = $"{fileName}.pdf";


            Guid fileId = Guid.NewGuid();
            SqlConnection conn = new SqlConnection(ClassConnect.GetSQLConnString());

            conn.Open();
            SqlCommand insert = new SqlCommand(
              "INSERT INTO Document ([DocumentID], [DocumentName], [Employee]) " +
              "VALUES (@FileId, @FileName, @Employee)", conn);
            insert.Parameters.Add("@FileId",
              SqlDbType.UniqueIdentifier).Value = fileId;
            insert.Parameters.Add("@FileName",
              SqlDbType.VarChar, 100).Value = flName;
            insert.Parameters.Add("@Employee",
              SqlDbType.Int).Value = _currentEmployee.ID;
            insert.ExecuteNonQuery();

            SqlTransaction fsTx = conn.BeginTransaction();
            SqlCommand getTransaction = new SqlCommand(
              "SELECT [DocumentSource].PathName(), " +
              "GET_FILESTREAM_TRANSACTION_CONTEXT() " +
              "FROM Document " +
              "WHERE DocumentId = @FileID", conn);
            getTransaction.Transaction = fsTx;
            getTransaction.Parameters.Add("@FileId",
              SqlDbType.UniqueIdentifier).Value = fileId;

            SqlDataReader contextReader = getTransaction.ExecuteReader(CommandBehavior.SingleRow);
            contextReader.Read();
            string filePath = contextReader.GetString(0);
            byte[] transactionId = (byte[])contextReader[1];
            contextReader.Close();

            using (FileStream fs = File.OpenRead(path))
            {
                using (SqlFileStream sqlFS = new SqlFileStream(filePath, transactionId, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int location = fs.Read(buffer, 0, buffer.Length);
                    while (location > 0)
                    {
                        sqlFS.Write(buffer, 0, location);
                        location = fs.Read(buffer, 0, buffer.Length);
                    }
                }
            }
            fsTx.Commit();
            conn.Close();
            string deleteFile = $@"C:\Users\Professional\Desktop\{fileName}.pdf";

            if (File.Exists(deleteFile))
            {
                File.Delete(deleteFile);


            }
            App.DataBase.Journals.Add(journal);
            App.DataBase.SaveChanges();
            WindowActiveTests activeTests = new WindowActiveTests(_currentEmployee);
            activeTests.Show();
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowSelectionMessage.Show("Подтверждение", "Хотите завершить тест?"))
            {
                Timer.Stop();
                WindowActiveTests activeTests = new WindowActiveTests(_currentEmployee);
                activeTests.Show();
                this.Close();
            }
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
            ListQuestion.ItemsSource = App.DataBase.Questions.Where(p => p.Test == _currentTest.ID).ToList();
            tbTest.Text = _currentTest.Title;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(time> 0)
            {
                if(time% 60 <= 10)
                {
                    if(time%60 ==0)
                    {
                        time--;
                        tbTime.Text = string.Format("00:0{0}:{1}", time / 60, time % 60);
                    }
                    else
                    {
                        if (time < 60)
                        {
                            tbTime.Foreground = Brushes.Red;
                        }
                        time--;
                        tbTime.Text = string.Format("00:0{0}:0{1}", time / 60, time % 60);
                    }
                }
                else
                {
                    time--;
                    tbTime.Text = string.Format("00:0{0}:{1}", time / 60, time % 60);
                }
            }
            else
            {
                Timer.Stop();
                SavingTheResult();
            }
           
        }
    }
}
