using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Задания_по_WPF.Pages;

namespace Задания_по_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StudentsButton_Click(object sender, RoutedEventArgs e)
        { 
            MainFrame.Navigate(new StudentsPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new GradesPage());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
                MainFrame.GoBack();
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoForward)
                MainFrame.GoForward();
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddOrEditUserPage(new Student(), "Add"));
        }
    }
}
