using Diary.Entities;
using Nest;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowTestActivity.xaml
    /// </summary>
    public partial class WindowTestActivity : Window
    {
        List<string> listDate = new List<string>();
        Test _currentTest = new Test();
        List<int> time = new List<int>();
        int status = 2;
        public WindowTestActivity(Test test)
        {
            _currentTest = test;
            InitializeComponent();
            
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var bc = new BrushConverter();
            if(_currentTest != null)
            {
                var activity = _currentTest.Status;
                if (activity == 3)
                {
                    bDisabled.Background = (Brush)bc.ConvertFrom("White");
                    tbDisabled.Foreground = (Brush)bc.ConvertFrom("#406474");
                    ActivitySetup.Visibility = Visibility.Hidden;
                    btnSave.Visibility = Visibility.Hidden;
                }
                else
                {
                    bActive.Background = (Brush)bc.ConvertFrom("White");
                    tbActive.Foreground = (Brush)bc.ConvertFrom("#406474");
                }
            }
            calendar.DisplayDateStart = DateTime.Now;
           
        }


        private void Menu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (openMenu.Width != 30)
            {

                DoubleAnimation widthAnimation = new DoubleAnimation(30, new Duration(TimeSpan.FromSeconds(0.5)));
                openMenu.BeginAnimation(WidthProperty, widthAnimation);
                btnCloseImage.Visibility = Visibility.Hidden;
            }
            if (openMenu.Width == 30)
            {

                DoubleAnimation widthAnimation = new DoubleAnimation(400, new Duration(TimeSpan.FromSeconds(0.5)));
                openMenu.BeginAnimation(WidthProperty, widthAnimation);
                btnCloseImage.Visibility = Visibility.Visible;
            }
        }

        private void bActive_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var bc = new BrushConverter(); 
            bActive.Background = (Brush)bc.ConvertFrom("White");
            tbActive.Foreground = (Brush)bc.ConvertFrom("#406474");
            bDisabled.Background = (Brush)bc.ConvertFrom("#406474");
            tbDisabled.Foreground = (Brush)bc.ConvertFrom("White");
            ActivitySetup.Visibility = Visibility.Visible;
            btnSave.Visibility = Visibility.Visible;
            
        }

        private void bDisabled_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowSelectionMessage.Show("Подтверждение", "Вы хотите отключить тест и удалить всю активность?"))
            {
                var bc = new BrushConverter(); 
                bDisabled.Background = (Brush)bc.ConvertFrom("White");
                tbDisabled.Foreground = (Brush)bc.ConvertFrom("#406474");
                bActive.Background = (Brush)bc.ConvertFrom("#406474");
                tbActive.Foreground = (Brush)bc.ConvertFrom("White");
                ActivitySetup.Visibility = Visibility.Hidden;
                btnSave.Visibility = Visibility.Hidden;
                cbStartHours.SelectedValue = null;
                cbEndHours.SelectedValue = null;
                cbStartMin.SelectedValue = null;
                cbEndMin.SelectedValue = null;
                tbDate.Text = "Дата не выбрана";
                _currentTest.Status = 3;
                App.DataBase.ActivityTimes.RemoveRange(_currentTest.ActivityTimes);
                App.DataBase.SaveChanges();
            }
        }

        private void cbEndHours_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedMin = Convert.ToInt32(cbEndMin.SelectedItem);
            int selectedHours = Convert.ToInt32(cbEndHours.SelectedItem);
            var list = new List<int>();
            if (cbEndHours.SelectedItem != null)
            {
                for (int i = 9; i < selectedHours; i++)
                {
                    list.Add(i);
                }
                cbStartHours.ItemsSource = list;
                if(Convert.ToInt32(cbEndHours.SelectedValue) == 17)
                {
                    cbEndMin.ItemsSource = new List<string> { "00"};
                   
                }
                else
                {
                    cbEndMin.ItemsSource = new List<string> { "00", "30" };
                    TimeCheck();
                }
            }
        }
        private void cbEndMin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeCheck();
        }

        private void cbEndMin_DropDownOpened(object sender, EventArgs e)
        {
            if (cbEndMin.ItemsSource == null && Convert.ToInt32(cbEndHours.SelectedValue) != 17)
            {
                cbEndMin.ItemsSource = new List<string> { "00", "30" };
            }
            if (Convert.ToInt32(cbEndHours.SelectedValue) == 17)
            {
                cbEndMin.ItemsSource = new List<string> { "00" };
            }

        }

        private void cbEndHours_DropDownOpened(object sender, EventArgs e)
        {
            if (cbEndHours.ItemsSource == null)
            {
                cbEndHours.ItemsSource = new List<int> { 10, 11, 12, 13, 14, 15, 16, 17 };
            }
        }

        private void cbStartMin_DropDownOpened(object sender, EventArgs e)
        {
            if (cbStartMin.ItemsSource == null)
            {
                cbStartMin.ItemsSource = new List<string> { "00", "30" };
            }
        }

        private void cbStartHours_DropDownOpened(object sender, EventArgs e)
        {
            if (cbStartHours.ItemsSource == null)
            {
                cbStartHours.ItemsSource = new List<int> { 9, 10, 11, 12, 13, 14, 15, 16 };
            }
        }

        private void cbStartHours_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedHours = Convert.ToInt32(cbStartHours.SelectedItem);
            var listStart = new List<int>();
            if(cbStartHours.SelectedItem != null)
            {
                for (int i = 17; i > selectedHours; i--)
                {
                    listStart.Add(i);
                }
                cbEndHours.ItemsSource = listStart.OrderBy(p=>p).ToList();
                if (Convert.ToInt32(cbStartHours.SelectedItem) == 16)
                {
                    cbStartMin.ItemsSource = new List<string> { "00" };
                }
                else
                {
                    cbStartMin.ItemsSource = new List<string> { "00", "30" };
                    TimeCheck();
                }
            }
            
            
        }
        private void TimeCheck()
        {
            int selectedMin = Convert.ToInt32(cbStartMin.SelectedItem);
            int selectedHoursStart = Convert.ToInt32(cbStartHours.SelectedItem);
            int selectedHoursEnd = Convert.ToInt32(cbEndHours.SelectedItem);
            selectedHoursStart++;
            if (selectedMin == 30)
            {
                if (selectedHoursStart == selectedHoursEnd)
                {
                    cbEndMin.ItemsSource = new List<string> { "30" };
                }
                else
                {
                    cbEndMin.ItemsSource = new List<string> { "00", "30" };
                }

            }
            else
            {
                cbEndMin.ItemsSource = new List<string> { "00", "30" };
            }
        }
        private void cbStartMin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeCheck();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            WindowInfTest test = new WindowInfTest(_currentTest.ID);
            test.Show();
            this.Close();
        }
        
        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
                tbDate.Text = calendar.SelectedDate.Value.ToShortDateString();
                listDate.Clear();
                listDate.Add(calendar.SelectedDate.Value.ToShortDateString());
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            listDate.Clear();
            tbDate.Text = "Дата не выбрана";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (WindowSelectionMessage.Show("Подтверждение", "Вы хотите сохранить активность?"))
            {
                if(cbStartHours.SelectedValue != null && cbEndHours.SelectedValue != null && cbStartMin.SelectedValue != null && cbEndMin.SelectedValue != null)
                {
                    if (tbDate.Text.Length > 0 && tbDate.Text != "Дата не выбрана")
                    {
                        ActivityTime activityTime = new ActivityTime();
                        activityTime.StartTime = Convert.ToDateTime(($"{tbDate.Text} {cbStartHours.SelectedValue}:{cbStartMin.SelectedValue}"));
                        activityTime.EndTime = Convert.ToDateTime(($"{tbDate.Text} {cbEndHours.SelectedValue}:{cbEndMin.SelectedValue}"));
                        activityTime.Test = _currentTest.ID;
                        var _currentActivity = App.DataBase.ActivityTimes.ToList();
                        var _currentTests = App.DataBase.Tests.ToList();
                        if(activityTime.StartTime >= DateTime.Now && DateTime.Now >= activityTime.EndTime)
                        {
                            status = 1;
                        }
                        _currentTest.Status = status;
                        App.DataBase.ActivityTimes.Add(activityTime);
                        App.DataBase.SaveChanges();
                    }
                    else
                        WindowMessage.Show("Предупреждение", "Выберите дату");
                }
                else
                    WindowMessage.Show("Предупреждение", "Выберите время начала и конца. Проверьте выбрали ли вы часы и минуты");

            }
            
        }

        private void btnInfAct_Click(object sender, RoutedEventArgs e)
        {
            WindowInfActivity infActivity = new WindowInfActivity(_currentTest);
            infActivity.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu menu = new WindowMenu();
            menu.Show();
            this.Close();
        }
    }
}
