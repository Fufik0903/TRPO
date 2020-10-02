using System;
using System.Collections.Generic;
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

namespace Network_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string hostname = "www.google.com", message = "IP адреса для домена " + hostname + "\n";
            IPHostEntry entry = Dns.GetHostEntry(hostname);

            foreach (IPAddress a in entry.AddressList)
                message += "  --> " + a.ToString() + "\n";

            message += "\nАльтернативное имя домена: ";
            foreach (string aliasName in entry.Aliases)
                message += aliasName + "\n";

            message += "\nРеальное название хоста: " + entry.HostName;
            MessageBox.Show(message);
            this.Close();
        }
    }
}
