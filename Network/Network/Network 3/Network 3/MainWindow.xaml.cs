using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace Network_3
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

        private void openFile_Click(object sender, RoutedEventArgs e)
        {
            string filename = txb_fileuri.Text;
            FileWebRequest request =
                   (FileWebRequest)WebRequest.Create(filename);

            using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                txb_fileContent.Text = sr.ReadToEnd();
            }
        }

        private void writeFile_Click(object sender, RoutedEventArgs e)
        {
            WebRequest request = WebRequest.Create(txb_fileuri.Text);
            request.Method = "PUT";
            using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(txb_writefile.Text);
            }
        }
    }
}
