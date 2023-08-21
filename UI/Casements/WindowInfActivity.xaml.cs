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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowInfActivity.xaml
    /// </summary>
    public partial class WindowInfActivity : Window
    {
        Test _currentTest = new Test();
        public WindowInfActivity(Test test)
        {
            InitializeComponent();
            _currentTest = test;
            tbTitle.Text = test.Title;
            ListActivity.ItemsSource = App.DataBase.ActivityTimes.Where(p=>p.Test ==test.ID).ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        { 
            if (WindowSelectionMessage.Show("Подтверждение", "Вы хотите удалить время активности теста?"))
            {
                ActivityTime activity = ListActivity.SelectedItem as ActivityTime;
                if (activity == null)
                {
                    WindowMessage.Show("Предупреждение", "Выберите время активности для удаления");
                }
                else
                {
                    App.DataBase.ActivityTimes.Remove(activity);
                    App.DataBase.SaveChanges();
                    if (_currentTest.ActivityTimes.Count == 0)
                    {
                        _currentTest.Status = 3;
                    }
                    App.DataBase.SaveChanges();
                    ListActivity.ItemsSource = App.DataBase.ActivityTimes.Where(p => p.Test == _currentTest.ID).ToList();
                }

            }
        }

        private void btnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowTestActivity activity = new WindowTestActivity(_currentTest);
            activity.Show();
            this.Close();
        }
    }
}
