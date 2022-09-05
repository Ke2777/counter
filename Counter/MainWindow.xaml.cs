using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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
using System.Threading;

namespace Counter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        float m_counter = 0, s_counter = 0, understand = 0;
        float count = 0, speed = 0, record = 99999;
        DateTime date;


        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
        }

        public void start_timer(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            s_counter ++;
            if (s_counter > 59)
            {
                m_counter++;
                s_counter = 0;
            }
            seconds.Text = s_counter.ToString();
            minute.Text = m_counter.ToString();

        }

        private void btn_ponyatno_Click(object sender, RoutedEventArgs e)
        {
            understand++;
            understand_box.Text = understand.ToString();
            if (m_counter != 0)
            {
                count = m_counter / understand;
                speed = understand / m_counter;
                if (count < record)
                {
                    record = count;
                }

                record_box.Text = record.ToString();
                count_box.Text = count.ToString();
                speed_box.Text = speed.ToString();
            }
            
        }

        public void btn_stop_Click(object sender, RoutedEventArgs e)
        {
         dispatcherTimer.Stop();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            understand++;
            understand_box.Text = understand.ToString();
            if (m_counter != 0)
            {
                count = m_counter / understand;
                speed = understand / m_counter;
                if (count < record)
                {
                    record = count;
                }

                record_box.Text = record.ToString();
                count_box.Text = count.ToString();
                speed_box.Text = speed.ToString();
            }
        }

    }
}
