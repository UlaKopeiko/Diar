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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowHealthHistory.xaml
    /// </summary>
    public partial class WindowHealthHistory : Window
    {
        Feeling _currentFeeling = new Feeling();
        Employee _currentEmployee = new Employee();
        public WindowHealthHistory(Feeling feeling)
        {
            InitializeComponent();
            _currentFeeling = feeling;
            _currentEmployee = App.DataBase.Employees.Where(p => p.ID == _currentFeeling.Employee).FirstOrDefault();
            tbName.Text = _currentEmployee.FLName;
            tbCurrentDeviations.Text = _currentFeeling.CurrentDeviations.ToString();
            tbComplaints.Text = _currentFeeling.Complaints.ToString();
            tbEvaluation.Text = _currentFeeling.Evaluation.ToString();
        }

        private void btnBack_Click(object sender, MouseButtonEventArgs e)
        {
            WindowHealth health = new WindowHealth(_currentEmployee);
            health.Show();
            this.Close();
        }
    }
}
