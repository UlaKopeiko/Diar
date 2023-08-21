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
    /// Логика взаимодействия для WindowAutorization.xaml
    /// </summary>
    public partial class WindowAutorization : Window
    {

        public WindowAutorization()
        {
            InitializeComponent();
            var _currentActivity = App.DataBase.ActivityTimes.ToList();
            var _currentTest = App.DataBase.Tests.ToList();
            var _currentTestW = App.DataBase.Tests.ToList();
            var _currentTestD = App.DataBase.Tests.ToList();
            _currentTestD = (from p in _currentTestD join act in _currentActivity on p.ID equals act.Test where act.StartTime <= DateTime.Now select p).ToList();
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

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            var employee = App.DataBase.Employees.ToList();
            if(tbLogin.Text.Length > 0 && tbPass.Text.Length > 0)
            {
                foreach (var emp in employee)
                {
                    if (emp.Login == tbLogin.Text)
                    {
                        if (emp.Password == tbPass.Text)
                        {
                            if (emp.Position == 1)
                            {
                                WindowMenu menu = new WindowMenu();
                                menu.Show();
                                this.Close();
                                return;
                            }
                            else
                            {
                                WindowActiveTests activeTests = new WindowActiveTests(emp);
                                activeTests.Show();
                                this.Close();
                                return;
                            }
                        }
                        WindowMessage.Show("Предупреждение", "Неверный логин или пароль");
                    }
                }
            }
            else
            {
                WindowMessage.Show("Предупреждение", "Заполните все поля");
            }
        }
    }
}
