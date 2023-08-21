using System;
using System.Collections;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowUsers.xaml
    /// </summary>
    public partial class WindowUsers : Window
    {
        public WindowUsers()
        {
            InitializeComponent();
            ListUsers.ItemsSource = App.DataBase.Employees.Where(p=>p.Position != 1).ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu menu= new WindowMenu();
            menu.Show();
            this.Close();
        }
        
        
        


        private void ListViewItemClick(object sender, MouseButtonEventArgs e)
        {
            
            WindowUser user = new WindowUser(((ListViewItem)sender).DataContext as Entities.Employee);
            user.Show();
            Window.GetWindow(this).Close();
        }

        private void tbxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxSearch.Text.Length > 0)
            {
                tbSearch.Text = "";
                ListUsers.ItemsSource = App.DataBase.Employees.Where(p => p.FirstName.ToLower().Contains(tbxSearch.Text.ToLower()) || p.LastName.ToLower().Contains(tbxSearch.Text.ToLower()) || p.Surname.ToLower().Contains(tbxSearch.Text.ToLower())).ToList();
            }
            else
            {
                tbSearch.Text = "Поиск по ФИО";
                ListUsers.ItemsSource = App.DataBase.Employees.ToList();
            }
                
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowAddEmployee addEmployee = new WindowAddEmployee();
            addEmployee.Show();
            this.Close();
        }
    }
}
