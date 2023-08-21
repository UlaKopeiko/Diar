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
    /// Логика взаимодействия для WindowDirectory.xaml
    /// </summary>
    public partial class WindowDirectory : Window
    {
        public WindowDirectory()
        {
            InitializeComponent();
            ListTerm.ItemsSource = App.DataBase.Directories.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowAddTerm term = new WindowAddTerm(0);
            term.Show();
            this.Close();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            Entities.Directory directory = ListTerm.SelectedItem as Entities.Directory;
            if (directory == null)
            {
                WindowMessage.Show("Предупреждение", "Выберите термин для продолжения");
            }
            else
            {
                int _currentTerm = directory.ID;
                WindowAddTerm term = new WindowAddTerm(_currentTerm);
                term.Show();
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Entities.Directory directory = ListTerm.SelectedItem as Entities.Directory;
            if (directory == null)
            {
                WindowMessage.Show("Предупреждение", "Выберите термин для удаления");
            }
            else
            {
                if (WindowSelectionMessage.Show("Подтверждение", "Вы хотите удалить термин?"))
                {
                    App.DataBase.Directories.Remove(directory);
                    App.DataBase.SaveChanges();
                    ListTerm.ItemsSource = App.DataBase.Directories.ToList();
                }
                    
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowMenu menu = new WindowMenu();
            menu.Show();
            this.Close();
        }

        private void tbxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tbxSearch.Text.Length > 0) 
            {
                tbSearch.Text = "";
                var _currentForSearch = App.DataBase.Directories.Where(p => p.Title.ToLower().Contains(tbxSearch.Text.ToLower())).ToList();
                if(_currentForSearch == null)
                {
                    tbNoResults.Visibility = Visibility.Visible;
                }
                else
                {
                    tbNoResults.Visibility = Visibility.Collapsed;
                    ListTerm.ItemsSource = _currentForSearch.ToList();
                }
                
            }
            else
            {
                tbNoResults.Visibility = Visibility.Collapsed;
                tbSearch.Text = "Поиск по названию";
                ListTerm.ItemsSource = App.DataBase.Directories.ToList();
            }

        }
    }
}
