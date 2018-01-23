using StatsdClient;
using System;
using System.Threading;
using System.Windows;

namespace SampleWinAppForStatsD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MetricsConfig metricsConfig = new MetricsConfig
            {
                StatsdServerName = "172.16.2.118",
                Prefix = "A-Level"
            };
            Metrics.Configure(metricsConfig);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            while(true)
            {
                Thread.Sleep(100);
                Metrics.Counter("stat-name");
                //Metrics.Time(() => myMethod(), "stat-name");
                Metrics.GaugeAbsoluteValue("gauge-name", new Random(10).NextDouble());
                Metrics.GaugeDelta("gauge-name", new Random(10).NextDouble());
                Metrics.Set("something-special", "80");
            }

        }
    }
}
