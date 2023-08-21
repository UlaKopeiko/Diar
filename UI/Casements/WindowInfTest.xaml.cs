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

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowInfTest.xaml
    /// </summary>
    public partial class WindowInfTest : Window
    {
        private int _currentTest;
        public WindowInfTest(int currentTest)
        {
            InitializeComponent();
            _currentTest = currentTest;
            ListQuestions.ItemsSource = App.DataBase.Questions.Where(p => p.Test == _currentTest).ToList();
            var title = App.DataBase.Tests.FirstOrDefault(p => p.ID == _currentTest);
            tbTitle.Text=title.Title;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            WindowListTests listTest = new WindowListTests();
            listTest.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (WindowSelectionMessage.Show("Подтверждение", "Вы хотите удалить вопрос?"))
            {
                Entities.Question question = ListQuestions.SelectedItem as Entities.Question;
                if (question == null)
                {
                    WindowMessage.Show("Предупреждение", "Выберите вопрос для удаления");
                }
                else
                {
                    App.DataBase.Questions.Remove(question);
                    App.DataBase.SaveChanges();
                    var list = App.DataBase.Questions.Where(p => p.Test == _currentTest).ToList();
                    ListQuestions.ItemsSource=list;
                }

            }
        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (openFilters.Width != 30)
            {

                DoubleAnimation widthAnimation = new DoubleAnimation(30, new Duration(TimeSpan.FromSeconds(0.5)));
                openFilters.BeginAnimation(WidthProperty, widthAnimation);
                btnCloseImage.Visibility = Visibility.Hidden;
            }
            if (openFilters.Width == 30)
            {

                DoubleAnimation widthAnimation = new DoubleAnimation(400, new Duration(TimeSpan.FromSeconds(0.5)));
                openFilters.BeginAnimation(WidthProperty, widthAnimation);
                btnCloseImage.Visibility = Visibility.Visible;
            }
        }

        
        private void tbxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxSearch.Text.Length > 0)
            {
                tbSearch.Text = "";
                var _currentQuestions = App.DataBase.Questions.Where(p => p.Test == _currentTest).ToList();
                ListQuestions.ItemsSource = _currentQuestions.Where(p => p.Text.ToLower().Contains(tbxSearch.Text.ToLower())).ToList();
            }
            else
            {
                ListQuestions.ItemsSource = App.DataBase.Questions.Where(p => p.Test == _currentTest).ToList();
                tbSearch.Text = "Поиск по содержанию";
            }
        }

        private void btnEditActivity_Click(object sender, RoutedEventArgs e)
        {
            var title = App.DataBase.Tests.FirstOrDefault(p => p.ID == _currentTest);
            WindowTestActivity activity = new WindowTestActivity(title);
            activity.Show();
            this.Close();
        }

        private void btnBackMenu_Click(object sender, RoutedEventArgs e)
        {
            WindowMenu menu = new WindowMenu();
            menu.Show();
            this.Close();
        }
    }
}
