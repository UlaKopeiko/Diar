using Diary.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Shell;

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowTestsPassed.xaml
    /// </summary>
    public partial class WindowTestsPassed : Window
    {
        private Employee _currentEmployee;
        public WindowTestsPassed(Employee employee)
        {
            InitializeComponent();
            _currentEmployee = employee;
            ListFile.ItemsSource = App.DataBase.Documents.Where(p=>p.Employee == employee.ID).ToList();
        }
        private void BtnAddDoc_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fd = new Microsoft.Win32.OpenFileDialog();
            fd.ShowDialog();
            string path = fd.FileName;
            string fileName = fd.SafeFileName;


            Guid fileId = Guid.NewGuid();
            SqlConnection conn = new SqlConnection(ClassConnect.GetSQLConnString());

            conn.Open();
            SqlCommand insert = new SqlCommand(
              "INSERT INTO Document ([DocumentID], [DocumentName], [Employee]) " +
              "VALUES (@FileId, @FileName, @Employee)", conn);
            insert.Parameters.Add("@FileId",
              SqlDbType.UniqueIdentifier).Value = fileId;
            insert.Parameters.Add("@FileName",
              SqlDbType.VarChar, 100).Value = fileName;
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
            UpdateList();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowUser user = new WindowUser(_currentEmployee);
            user.Show();
            this.Close();
        }
        public void UpdateList()
        {
            if(tbxSearch.Text.Length > 0)
            {
                var list = App.DataBase.Documents.Where(p => p.Employee == _currentEmployee.ID ).ToList();
                ListFile.ItemsSource = list.Where(p => p.DocumentName.ToLower().Contains(tbxSearch.Text.ToLower())).ToList();
            }
            else
            {
                ListFile.ItemsSource = App.DataBase.Documents.Where(p => p.Employee == _currentEmployee.ID).ToList();
            }
            
        }
        private void tbxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxSearch.Text.Length > 0)
            {
                tbSearch.Text = "";
                UpdateList();
            }
            else
            {
                tbSearch.Text = "Поиск по названию";
                UpdateList();
            }
        }

        private void Download_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
                var path = "";
                Document data = ((FrameworkElement)sender).DataContext as Document;
                List<Document> files = new List<Document>();
                using (SqlConnection conn = new SqlConnection(ClassConnect.GetSQLConnString()))
                {
                    conn.Open();
                    string query = "select * from Document where DocumentID = '" + data.DocumentID + "'";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Guid fileId = reader.GetGuid(0);
                        byte[] fileData = (byte[])reader.GetValue(1);
                        int employee = reader.GetInt32(2);
                    string fileName = (string)reader.GetString(3);
                        Document file = new Document(fileId, fileName, employee, fileData );
                        files.Add(file);
                    }
                }
                var fd = new CommonOpenFileDialog();
                fd.Title = "Сохранить в...";
                fd.IsFolderPicker = true;

                fd.AddToMostRecentlyUsedList = false;

                fd.AllowNonFileSystemItems = false;
                fd.EnsureFileExists = true;
                fd.EnsurePathExists = true;
                fd.EnsureReadOnly = false;
                fd.EnsureValidNames = true;
                fd.Multiselect = false;
                fd.ShowPlacesList = true;
                fd.IsFolderPicker = true;
            if (fd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path = fd.FileName + "\\" + files[0].DocumentName;
            }
            if (path != null)
            {
                using (FileStream fs = new FileStream(path.ToString(), FileMode.OpenOrCreate))
                {
                    fs.Write(files[0].DocumentSource, 0, files[0].DocumentSource.Length);

                    WindowMessage.Show("Предупреждение", "Файл успешно сохранён");


                }
            }
        }

        private void Delete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowSelectionMessage.Show("Подтверждение", "Вы хотите удалить файл?"))
            {
                Document data = ((FrameworkElement)sender).DataContext as Document;
                App.DataBase.Documents.Remove(data);
                App.DataBase.SaveChanges();
                ListFile.ItemsSource = App.DataBase.Documents.Where(p => p.Employee == _currentEmployee.ID).ToList();
                }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
    }

