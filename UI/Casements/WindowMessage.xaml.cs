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
using System.Xml.Serialization;

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowMessage.xaml
    /// </summary>
    public partial class WindowMessage : Window
    {
        public WindowMessage()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public WindowMessage(string title, string text)
        {
            InitializeComponent();
            btnNext.Focus();
            Title = title;
            tbText.Text = text;
        }
        public static void Show(string title, string text)
        {
            var wind = new WindowMessage(title, text);
            wind.ShowDialog();
        }
    }
}
