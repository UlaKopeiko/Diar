using Diary.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для WindowListTests.xaml
    /// </summary>
    public partial class WindowListTests : Window
    {
        
        public WindowListTests()
        {
            InitializeComponent();
            ListTest.ItemsSource = App.DataBase.Tests.ToList();

        }
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
          
        }
        
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Entities.Test test = ListTest.SelectedItem as Entities.Test;
            if (test == null)
            {
                WindowMessage.Show("Предупреждение", "Выберите тест для продолжения");
            }
            else
            {
                int _currentTest = test.ID;
                WindowInfTest infTest = new WindowInfTest(_currentTest);
                infTest.Show();
                this.Close();
            }
            
        }

        

        

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu menu = new WindowMenu();
            menu.Show();
            this.Close();
        }

        private void tbxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UsingFilters();
        }
        private void UsingFilters()
        {
            if (tbxSearch.Text.Length > 0)
            {
                tbSearch.Text = "";
                var _currentForSearch = App.DataBase.Tests.Where(p => p.Title.ToLower().Contains(tbxSearch.Text.ToLower())).ToList();
                if (rbActivity.IsChecked == true)
                {
                    ListTest.ItemsSource = _currentForSearch.Where(p => p.Status == 1).ToList();
                }
                if (rbExpects.IsChecked == true)
                {
                    ListTest.ItemsSource = _currentForSearch.Where(p => p.Status == 2).ToList();
                }
                if (rbDisabled.IsChecked == true)
                {
                    ListTest.ItemsSource = _currentForSearch.Where(p => p.Status == 3).ToList();
                }
                if(rbActivity.IsChecked == false && rbDisabled.IsChecked== false && rbExpects.IsChecked == false) 
                {
                    ListTest.ItemsSource = _currentForSearch.ToList();
                }
            }
            else
            {
                ListTest.ItemsSource = App.DataBase.Tests.ToList();
                tbSearch.Text = "Поиск по названию";
                ActivityCheck();
            }
        }
        private void ActivityCheck()
        {
            if (rbActivity.IsChecked == true)
            {
                ListTest.ItemsSource = App.DataBase.Tests.Where(p => p.Status == 1).ToList();
            }
            if (rbExpects.IsChecked == true)
            {
                ListTest.ItemsSource = App.DataBase.Tests.Where(p => p.Status == 2).ToList();
            }
            if (rbDisabled.IsChecked == true)
            {
                ListTest.ItemsSource = App.DataBase.Tests.Where(p => p.Status == 3).ToList();
            }
            if (rbActivity.IsChecked == false && rbDisabled.IsChecked == false && rbExpects.IsChecked == false)
            {
                ListTest.ItemsSource = App.DataBase.Tests.ToList();
            }
        }

        private void rbActivity_Checked(object sender, RoutedEventArgs e)
        {
            UsingFilters();
        }

        private void rbExpects_Checked(object sender, RoutedEventArgs e)
        {
            UsingFilters();
        }

        private void rbDisabled_Checked(object sender, RoutedEventArgs e)
        {
            UsingFilters();
        }

        private void rbAll_Checked(object sender, RoutedEventArgs e)
        {
            UsingFilters();
        }
    }
}
