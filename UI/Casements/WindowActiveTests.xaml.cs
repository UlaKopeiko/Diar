using Diary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowActiveTests.xaml
    /// </summary>
    public partial class WindowActiveTests : Window
    {
        Employee _currentEmployee = new Employee();
        public WindowActiveTests(Employee employee)
        {
            _currentEmployee = employee;
            InitializeComponent();
            ListTest.ItemsSource = App.DataBase.Tests.Where(p =>p.Status == 1).ToList();
            tbName.Text = _currentEmployee.FLName;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            var element = ((System.Windows.Controls.Button)sender).DataContext as Entities.Test;
            WindowTestPassing testPassing = new WindowTestPassing(element, _currentEmployee);
            testPassing.Show();
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowSelectionMessage.Show("Подтверждение", "Вы уверены, что хотите выйти из профиля??"))
            {
                WindowAutorization autorization = new WindowAutorization();
                autorization.Show();
                this.Close();
            }

        }
    }
}
