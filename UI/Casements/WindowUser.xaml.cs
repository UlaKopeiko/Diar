using Diary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlTypes;
using System.Data;

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowUser.xaml
    /// </summary>
    public partial class WindowUser : Window
    {
        Feeling _currentFeeling;
        Employee _currentEmployee;
        int k;


        public WindowUser(Entities.Employee employee)
        {
            InitializeComponent();
            _currentEmployee = employee;
            DataContext =employee;
            tbBith.Text = employee.Birthday.ToString("d");
            if(App.DataBase.Feelings.Where(p => p.Employee == employee.ID).Count() != 0)
            {
                _currentFeeling = App.DataBase.Feelings.ToList().Where(p => p.Employee == employee.ID).Last();
                tbCurrentDeviations.Text = _currentFeeling.CurrentDeviations.ToString();
                tbComplaints.Text = _currentFeeling.Complaints.ToString();
            }
            else
            {
                WindowMessage.Show("Предупреждение", "В базе данных не найдена история самочувствия");
                _currentFeeling = new Feeling();
                tbCurrentDeviations.Text = "";
                tbComplaints.Text = "";
            }

        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            WindowUsers users = new WindowUsers();
            users.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(_currentFeeling.Date == DateTime.Today.Date && App.DataBase.Feelings.Where(p => p.Employee == _currentEmployee.ID).Count() != 0)
            {
                _currentFeeling.CurrentDeviations = tbCurrentDeviations.Text;
                _currentFeeling.Complaints = tbComplaints.Text;
                _currentFeeling.Evaluation = k;
            }
            else
            {
                Feeling feeling = new Feeling();
                feeling.Date = DateTime.Today.Date;
                feeling.CurrentDeviations = tbCurrentDeviations.Text;
                feeling.Complaints = tbComplaints.Text;
                feeling.Employee = _currentEmployee.ID;
                feeling.Evaluation = k;
                App.DataBase.Feelings.Add(feeling);
            }
            
            App.DataBase.SaveChanges();
            _currentFeeling = App.DataBase.Feelings.ToList().Where(p => p.Employee == _currentEmployee.ID).Last();
            tbCurrentDeviations.Text = _currentFeeling.CurrentDeviations.ToString();
            tbComplaints.Text = _currentFeeling.Complaints.ToString();
            WindowMessage.Show("Предупреждение", "Информация сохранена");
        }

        private void sEvaluation_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            k = (int)sEvaluation.Value;
        }

        private void btnChart_Click(object sender, RoutedEventArgs e)
        {
            WindowHealth health = new WindowHealth(_currentEmployee);
            health.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowTestsPassed testsPassed = new WindowTestsPassed(_currentEmployee);
            testsPassed.Show();
            this.Close();
        }
    }
}
