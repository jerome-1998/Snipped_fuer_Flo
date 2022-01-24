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
using System.IO;

namespace FloSnipped
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReadData_Click(object sender, RoutedEventArgs e)
        {
            string[] textLines = File.ReadAllLines("Data.txt");
            List<Switch> switches = new List<Switch>();
            foreach (string line in textLines)
            {
                switches.Add(new Switch() { IPAddress = line.Split(';')[0], Hostname = line.Split(';')[1], Location = line.Split(';')[2], SwitchN = line.Split(';')[3]});
            }
            lbSwitches.ItemsSource = switches;
            
        }
    }

    public class Switch
    {
        public string IPAddress { get; set; }
        public string Hostname { get; set; }
        public string Location { get; set; }
        public string SwitchN { get; set; }

    }
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// 


}
