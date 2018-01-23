using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace memoryGrowthExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<string> x = new List<string>();
            for (int i = 0; i < 1000000; i++)
            {
                x.Add("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            }
            MessageBox.Show("Done");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            System.GC.Collect();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Process proc = Process.GetCurrentProcess();
            MessageBox.Show(proc.PrivateMemorySize64.ToString());
        }
    }
}
