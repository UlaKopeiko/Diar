using Diary.Entities;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowHealth.xaml
    /// </summary>
    public partial class WindowHealth : Window
    {
        
        List<Feeling> dateList = new List<Feeling>();
        List<DateTime> dateActual = new List<DateTime>();
        Employee _currentEmployee;
        DateTime startTime = new DateTime();
        DateTime endTime = new DateTime();

        public WindowHealth(Employee employee)
        {
            InitializeComponent();
            _currentEmployee = employee;
            tbName.Text = _currentEmployee.FLName;
        }

        private void btnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowUser user = new WindowUser(_currentEmployee);
            user.Show();
            this.Close();
        }
        private void ListViewItemClick(object sender, MouseButtonEventArgs e)
        {
            dateList = App.DataBase.Feelings.Where(p => p.Employee == _currentEmployee.ID).ToList();
            var element = ((System.Windows.Controls.ListViewItem)sender).DataContext;
            var _currentFeeling = dateList.Where(p=>p.Date== (DateTime) element ).FirstOrDefault();
            WindowHealthHistory user = new WindowHealthHistory(_currentFeeling);
            user.Show();
            Window.GetWindow(this).Close();
        }
        
        private void dpStartDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

            dpEndDate.SelectedDate = null;
            DateRestriction();
        }
        private void DateRestriction()
        {
            LinearСhart.Segments.Clear();
            dateActual.Clear();
            dateList.Clear();
            startTime = (DateTime)dpStartDate.SelectedDate;
            endTime = startTime.AddDays(10);
            dpEndDate.DisplayDateStart = startTime;
            dpEndDate.DisplayDateEnd = endTime;
            var x = 1;
            foreach (var item in App.DataBase.Feelings.Where(p => p.Employee == _currentEmployee.ID && p.Date >= dpStartDate.SelectedDate && p.Date <= dpEndDate.SelectedDate).ToList())
            {
                Point point = new Point(x * 100, Convert.ToDouble(item.Evaluation * 43));
                LinearСhart.Segments.Add(new LineSegment(point, true));
                x++;
                dateActual.Add((DateTime)item.Date);
            }
            ListDate.ItemsSource = dateActual.ToList();
        }

        private void dpEndDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dpStartDate.SelectedDate == null)
            {

            }
            else
            {
                DateRestriction();
            }
            
        }
    }
}

