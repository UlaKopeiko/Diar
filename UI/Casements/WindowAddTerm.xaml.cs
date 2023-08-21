using Diary.Entities;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для WindowAddTerm.xaml
    /// </summary>
    public partial class WindowAddTerm : Window
    {
        int _currentTermID;
        public WindowAddTerm(int term)
        {
            InitializeComponent();
            _currentTermID = term;
            var _currentTerm = App.DataBase.Directories.FirstOrDefault(p => p.ID == _currentTermID);
            if (_currentTermID != 0) 
            {
                tbxTerm.Text = _currentTerm.Title;
                tbxText.Text = _currentTerm.Description;
            }
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            WindowDirectory directory = new WindowDirectory();
            directory.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (tbxTerm.Text.Length > 0)
            {
                if (tbxText.Text.Length > 0)
                {
                    
                    if (_currentTermID == 0)
                    {
                        Entities.Directory directory = new Entities.Directory();
                        directory.Title = tbxTerm.Text;
                        directory.Description = tbxText.Text;
                        App.DataBase.Directories.Add(directory);
                        App.DataBase.SaveChanges();
                        WindowDirectory windowDirectory = new WindowDirectory();
                        windowDirectory.Show();
                        this.Close();
                    }
                    else
                    {
                        var _currentTerm = App.DataBase.Directories.FirstOrDefault(p => p.ID == _currentTermID);
                        _currentTerm.Title = tbxTerm.Text;
                        _currentTerm.Description = tbxText.Text;
                        _currentTerm.ID = _currentTermID;
                        App.DataBase.SaveChanges();
                        WindowDirectory windowDirectory = new WindowDirectory();
                        windowDirectory.Show();
                        this.Close();
                    }

                }
                else
                    WindowMessage.Show("Предупреждение", "Введите описание");
            }
            else
                WindowMessage.Show("Предупреждение", "Введите термин");
        }
    }
}
