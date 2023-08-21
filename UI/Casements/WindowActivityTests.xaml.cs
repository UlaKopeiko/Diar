using Diary.Entities;
using Diary.UI.UC;
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
    /// Логика взаимодействия для WindowActivityTests.xaml
    /// </summary>
    public partial class WindowActivityTests : Window
    {
        List<ActivityTime> activities = new List<ActivityTime>();
        public WindowActivityTests()
        {
            InitializeComponent();
            ListActivity.ItemsSource = App.DataBase.ActivityTimes.ToList();
           
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            activities.Clear();
            var date = calendar.SelectedDate.Value.ToShortDateString();
            foreach(ActivityTime i in App.DataBase.ActivityTimes.ToList())
            {
                if(i.StartTime.ToShortDateString() == date)
                {
                    activities.Add(i);
                }
            }
            ListActivity.ItemsSource = activities.ToList();
        }

        private void btnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowMenu menu = new WindowMenu();
            menu.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            activities.Clear();
            ListActivity.ItemsSource = App.DataBase.ActivityTimes.ToList();
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
                    if(activities.Count != 0)
                    {
                        activities.Clear();
                        var date = calendar.SelectedDate.Value.ToShortDateString();
                        foreach (ActivityTime i in App.DataBase.ActivityTimes.ToList())
                        {
                            if (i.StartTime.ToShortDateString() == date)
                            {
                                activities.Add(i);
                            }
                        }
                        ListActivity.ItemsSource = activities.ToList();
                    }
                    else
                        ListActivity.ItemsSource = App.DataBase.ActivityTimes.ToList();
                }

            }
        }
    }
}
