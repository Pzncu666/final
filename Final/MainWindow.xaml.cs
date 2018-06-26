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
using System.Windows.Forms;

namespace Final
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnWindowStateChanged(object sender, EventArgs e)
        {
            if (WindowState != WindowState.Normal)
            {
                WindowState = WindowState.Normal;
            }
        }

        public void UpdateTime()
        {
            if(IsInitialized)
            {
                double value_m = sli.Value * 30 ;
                time.Text = value_m.ToString();
            }
        }

        // 滑條
        private void sli_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            num_fire.Text = sli.Value.ToString();
            UpdateTime();
        }
   
        
        // 按鈕
        private void but_canc_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void but_ok_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        // 勾勾事件
        private void CheckBox1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CheckMark1.Visibility == Visibility.Collapsed)
                CheckMark1.Visibility = Visibility.Visible;
            else
                CheckMark1.Visibility = Visibility.Collapsed;

        }

        private void CheckBox2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CheckMark2.Visibility == Visibility.Collapsed)
                CheckMark2.Visibility = Visibility.Visible;
            else
                CheckMark2.Visibility = Visibility.Collapsed;
        }

        
    }
}
