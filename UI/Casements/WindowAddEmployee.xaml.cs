using Diary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Drawing;

namespace Diary.UI.Casements
{
    /// <summary>
    /// Логика взаимодействия для WindowAddEmployee.xaml
    /// </summary>
    public partial class WindowAddEmployee : Window
    {
        string path = string.Empty;
        public WindowAddEmployee()
        {
            InitializeComponent();
            cbPosition.ItemsSource = App.DataBase.Positions.ToList();
            cbCharacter.ItemsSource = App.DataBase.CharacterAccentuations.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            WindowUsers users = new WindowUsers();
            users.Show();
            this.Close();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder reason = new StringBuilder();
            if (ClassLibrary.NameVerification.CheckName(tbxLast.Text, tbxFirst.Text, out reason))
            {
                if (tbxLast.Text.Length > 0 && tbxFirst.Text.Length > 0 && tbxSurname.Text.Length > 0 && tbxMotivation.Text.Length > 0 && tbxTemperament.Text.Length > 0 && tbxFamily.Text.Length > 0 && tbxLogin.Text.Length > 0 && tbxPass.Text.Length > 0)
                {
                    if (cbCharacter.SelectedIndex != 0 && cbPosition.SelectedIndex != 0 && dpBirthday.Text.Length > 0)
                    {
                        Position position = cbPosition.SelectedItem as Position;
                        CharacterAccentuation character = cbCharacter.SelectedItem as CharacterAccentuation;
                        Employee employee = new Employee();
                        employee.LastName = tbxLast.Text;
                        employee.FirstName = tbxFirst.Text;
                        employee.Surname = tbxSurname.Text;
                        employee.Birthday = (DateTime)dpBirthday.SelectedDate;
                        employee.Position = position.ID;
                        employee.Login = tbxLogin.Text;
                        employee.Password = tbxPass.Text;
                        employee.Temperament = tbxTemperament.Text;
                        employee.Family = tbxFamily.Text;
                        employee.CharacterAccentuation = character.Id;
                        employee.Motivation = tbxMotivation.Text;

                        App.DataBase.Employees.Add(employee);
                        SqlConnection conn = new SqlConnection(ClassConnect.GetSQLConnString());

                        conn.Open();
                        SqlCommand insert = new SqlCommand(
                        "UPDATE Employee SET Photo = BulkColumn" +
                        $"FROM Openrowset(Bulk '{path}', Single_Blob) as EmployeePicture  WHERE ID = {employee.ID}", conn);

                        conn.Close();
                        App.DataBase.SaveChanges();
                        WindowMessage.Show("Подтверждение", "Новый сотрудник добавлен");
                        WindowUsers users = new WindowUsers();
                        users.Show();
                        this.Close();
                    }
                    else
                    {
                        WindowMessage.Show("Предупреждение", "Выберите все необходимые данные для продолжения");
                    }
                }
                else
                    WindowMessage.Show("Предупреждение", "Заполните все поля для продолжения");
            }
        }
        private void btnAddPhoto_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fd = new Microsoft.Win32.OpenFileDialog();
            fd.ShowDialog();
            path = fd.FileName;
            
        }

    }

}
