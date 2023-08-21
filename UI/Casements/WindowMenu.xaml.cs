using Diary.UI.Casements;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Diary
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {

        public WindowMenu()
        {
            InitializeComponent();
            var _currentActivity = App.DataBase.ActivityTimes.ToList();
            var _currentTest = App.DataBase.Tests.ToList();
            var _currentTestW = App.DataBase.Tests.ToList();
            var _currentTestD = App.DataBase.Tests.ToList();

           
            _currentTestD = (from p in _currentTestD join act in _currentActivity on p.ID equals act.Test where act.StartTime <= DateTime.Now  select p).ToList();
            foreach (var test in _currentTestD)
            {
                test.Status = 3;
            }
            _currentTestW = (from p in _currentTestW join act in _currentActivity on p.ID equals act.Test where DateTime.Now <= act.EndTime select p).ToList();
            foreach (var test in _currentTestW)
            {
                test.Status = 2;
            }
            _currentTest = (from p in _currentTest join act in _currentActivity on p.ID equals act.Test where act.StartTime <= DateTime.Now && DateTime.Now <= act.EndTime select p).ToList();
            foreach (var test in _currentTest)
            {
                test.Status = 1;
            }


            App.DataBase.SaveChanges();

        }

        private void tbText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(lbTest.Visibility == Visibility.Visible) 
            {
                lbTest.Visibility = Visibility.Collapsed;
            }
            else
                lbTest.Visibility = Visibility.Visible;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (WindowSelectionMessage.Show("Подтверждение", "Вы уверены, что хотите выйти из профиля??"))
            {
                WindowAutorization autorization = new WindowAutorization();
                autorization.Show();
                this.Close();
            }
        }

        private void tbUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowUsers users = new WindowUsers();
            users.Show();
            this.Close();
        }

        private void btnCreateTest_Click(object sender, RoutedEventArgs e)
        {
            
        }

        

        private void btnActivity_Click(object sender, RoutedEventArgs e)
        {
            WindowActivityTests testActivity = new WindowActivityTests();
            testActivity.Show();
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lbTest.Visibility == Visibility.Visible)
            {
                lbTest.Visibility = Visibility.Collapsed;
            }
            else
                lbTest.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowListTests listTests = new WindowListTests();
            listTests.Show();
            this.Close();
        }

        private void btnCloseApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void tbDirectory_MouseMove(object sender, MouseEventArgs e)
        {
            WindowDirectory directory = new WindowDirectory();
            directory.Show();
            this.Close();
        }
    }
}
