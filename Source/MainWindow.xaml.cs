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

namespace Source
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConnectToJIRA api;

        public MainWindow()
        {
            InitializeComponent();
            this.api = new ConnectToJIRA();
            Console.WriteLine("TEST EXECUTION");
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            Object test = this.api.GetPermission();
            Console.WriteLine(test);
        }
    }
}
