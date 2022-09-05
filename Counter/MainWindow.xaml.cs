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
using System.Windows.Threading;

namespace Counter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int m_counter = 0, s_counter = 0, understand = 0, count = 0;
        //int timerTick = 0;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public void start_timer(object sender, RoutedEventArgs e)
        {
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            s_counter ++;
            if (s_counter == 60)
            {
                m_counter++;
                s_counter = 0;
            }

            minute.Text = m_counter.ToString(); 
            seconds.Text = s_counter.ToString();
        }

        private void btn_ponyatno_Click(object sender, RoutedEventArgs e)
        {
            understand++;
            if (m_counter != 0)
            {
                count = m_counter / understand;
            }
            
        }

        public void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
