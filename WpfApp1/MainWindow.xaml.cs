using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double dSaldo = 1500;
        public MainWindow()
        {  
            InitializeComponent();
            Verberg_bedragen();
        }

        private void Verberg_bedragen()
        {
            txt_10.Visibility = Visibility.Hidden;
            txt_30.Visibility = Visibility.Hidden;
            txt_50.Visibility = Visibility.Hidden;
            txt_100.Visibility = Visibility.Hidden;
            txt_150.Visibility = Visibility.Hidden;
            txt_250.Visibility = Visibility.Hidden;
            txt_OK.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            boek_bedrag_af(250);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (pwPincode.Password == "4321")
            {
                txtMessage.Text = "Kies bedrag..";
           
                txt_10.Visibility = Visibility.Visible;
                txt_30.Visibility = Visibility.Visible;
                txt_50.Visibility = Visibility.Visible;
                txt_100.Visibility = Visibility.Visible;
                txt_150.Visibility = Visibility.Visible;
                txt_250.Visibility = Visibility.Visible;
                txt_OK.Visibility = Visibility.Hidden;
                b_10.IsEnabled = true;
                b_30.IsEnabled = true;
                b_50.IsEnabled = true;
                b_100.IsEnabled = true;
                b_150.IsEnabled = true;
                b_250.IsEnabled = true;
                b_OK.IsEnabled = false;
            }
            else txtMessage.Text = "Onjuiste pincode!";
        }
        
        private void boek_bedrag_af(double bedrag)
        {
            dSaldo -= bedrag;
            txtMessage.Text = "Uw nieuwe saldo is € " + dSaldo + ". Nog een fijne dag!";
            b_10.IsEnabled = false;
            b_30.IsEnabled = false;
            b_50.IsEnabled = false;
            b_100.IsEnabled = false;
            b_150.IsEnabled = false;
            b_250.IsEnabled = false;
            b_OK.IsEnabled = true;
            Verberg_bedragen();
            pwPincode.Password = "";
        }

        private void b_10_Click(object sender, RoutedEventArgs e)
        {
            boek_bedrag_af(10);
        }

        private void b_30_Click(object sender, RoutedEventArgs e)
        {
            boek_bedrag_af(30);
        }

        private void b_50_Click(object sender, RoutedEventArgs e)
        {
            boek_bedrag_af(50);
        }

        private void b_100_Click(object sender, RoutedEventArgs e)
        {
            boek_bedrag_af(100);
        }

        private void b_150_Click(object sender, RoutedEventArgs e)
        {
            boek_bedrag_af(150);
        }
    }
}
