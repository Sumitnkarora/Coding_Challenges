using System;
using System.Windows;

namespace WpfApplication1
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
            DateTime xyz;
            for (int i = 0; i < 10000000000; i++)
            {
                xyz = DateTime.Now;
            }
            MessageBox.Show("Code Exit");
        }
    }
}
