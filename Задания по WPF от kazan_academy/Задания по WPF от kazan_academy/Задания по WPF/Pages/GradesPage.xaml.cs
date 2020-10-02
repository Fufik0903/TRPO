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
    /// Логика взаимодействия для GradesPage.xaml
    /// </summary>
    public partial class GradesPage : Page
    {
        public GradesPage()
        {
            InitializeComponent();

            DataContext = this;
            allGrades = MyDataBase.connection.Grade.ToList();
            allStudents = MyDataBase.connection.Student.ToList();
            allTeachers = MyDataBase.connection.Teacher.ToList();
            GradesListView.SelectedIndex = 0;
        }

        public List<Grade> allGrades { get; set; }
        public List<Student> allStudents { get; set; }
        public List<Teacher> allTeachers { get; set; }

        public Teacher ClassroomTeacher { get; set; }

        private void GradesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Grade myGrade = (Grade)GradesListView.SelectedItem;
            allStudents = MyDataBase.connection.Student.ToList().Where(a => a.Grade.Title == myGrade.Title).ToList();
            StudentsDataGrid.ItemsSource = allStudents;

            ClassroomTeacher = allTeachers.Where(teacher => teacher.Id == myGrade.Teacher_Id).First();
            string FioTeacher = $"Учитель: {ClassroomTeacher.Surname} {ClassroomTeacher.Name} {ClassroomTeacher.Patronymic}";
            ClassroomTeacherLabel.Content = FioTeacher;

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Student selectedStudent = StudentsDataGrid.SelectedItem as Student;
            NavigationService.Navigate(new AddOrEditUserPage(selectedStudent, "Edit"));
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Student selectedStudent = StudentsDataGrid.SelectedItem as Student;
            allStudents.Remove(selectedStudent);
            StudentsDataGrid.ItemsSource = allStudents;

            MyDataBase.connection.Student.Remove(selectedStudent);
            MyDataBase.connection.SaveChanges();

            MessageBox.Show("Студент успешно удалён!");
        }
    }
}
