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
    /// Логика взаимодействия для WindowSelectionMessage.xaml
    /// </summary>
    public partial class WindowSelectionMessage : Window
    {
        public static bool _result { get; set; }
        public WindowSelectionMessage()
        {
            InitializeComponent();
        }

        
        public WindowSelectionMessage(string title, string text)
        {
            InitializeComponent();
            Title = title;
            tbText.Text = text;
        }
        public static bool Show(string title, string text)
        {
            var wind = new WindowSelectionMessage(title, text);
            wind.ShowDialog();
            var result = _result;
            return result;
        }
        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            _result = true;
            Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            _result = false;
            Close();
        }
    }
}
