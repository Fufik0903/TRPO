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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Задания_по_WPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddOrEditUserPage.xaml
    /// </summary>
    public partial class AddOrEditUserPage : Page
    {

        public string Operation { get; set; }
        public Student MyStudent { get; set; }
        public List<Grade> GradeList { get; set; }

        public AddOrEditUserPage(Student student, string EditOrAdd)
        {
            GradeList = MyDataBase.connection.Grade.ToList();
            MyStudent = student;
            Operation = EditOrAdd;
            InitializeComponent();
            DataContext = this;
            //занесение данных в поля
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Grade selectedGrade = GradeStudentComboBox.SelectedItem as Grade;
            MyStudent.Grade_Id = Convert.ToInt32(GradeList.Where(g => g.Title == selectedGrade.Title).First().Id);
            try
            {
                if (Operation == "Add")
                    MyDataBase.connection.Student.Add(MyStudent);
                MyDataBase.connection.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Некорректные данне");
            }
            MessageBox.Show("Действие прошло успешно");
            NavigationService.Navigate(new StudentsPage());
        }
    }
}
