using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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


namespace AppButton
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

        private async void PostButton_Click(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(new { TemperatureC = 45.5, Summary = "test" }), Encoding.UTF8, "application/json");
            var resp = await client.PostAsync("http://localhost:57136/api/WeatherForecast", content);
            MessageBox.Show(resp.StatusCode.ToString());

        }

        private void GetButton_Click(object sender, RoutedEventArgs e)
        {
            var request = WebRequest.CreateHttp("http://localhost:57136/api/WeatherForecast");
            request.Method = "GET";
            var resp = request.GetResponse();
            using (var rs = new StreamReader(resp.GetResponseStream()))
            {
                MessageBox.Show(rs.ReadToEnd());
            }

        }
    }
}
