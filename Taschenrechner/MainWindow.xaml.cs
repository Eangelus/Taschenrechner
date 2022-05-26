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

namespace Taschenrechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Decimal> liste1 = new List<Decimal>();
        string status = "";
        string valu = "";
        Decimal a;
        Decimal b;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BoxErgebnis_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            valu = valu + "0";
            BoxErgebnis.Text = valu;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            valu = valu + "1";
            BoxErgebnis.Text = valu;
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            valu = valu + "2";
            BoxErgebnis.Text = valu;
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            valu = valu + "3";
            BoxErgebnis.Text = valu;
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            valu = valu + "4";
            BoxErgebnis.Text = valu;
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            
            valu = valu + "5";
            BoxErgebnis.Text = valu;
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            
            valu = valu + "6";
            BoxErgebnis.Text = valu;
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            valu = valu + "7";
            BoxErgebnis.Text = valu;
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            
            valu = valu + "8";
            BoxErgebnis.Text = valu;
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            
            valu = valu + "9";
            BoxErgebnis.Text = valu ;
        }

        private void BoxErgebnis_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {


        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
     

        }

        private void Bp_Click(object sender, RoutedEventArgs e)
        {
            valu = valu + ".";
            BoxErgebnis.Text = valu;
        }

        private void Bplus_Click(object sender, RoutedEventArgs e)
        {
            status = "+";
            if (valu.Substring(0, 1) == ".")
            {
                valu = "0" + valu;
            }
            a = decimal.Parse( valu, System.Globalization.CultureInfo.InvariantCulture);
            liste1.Add(a);
            valu = "";
            BoxErgebnis.Text = valu;
            
        }

        private void Bgleich_Click(object sender, RoutedEventArgs e)
        {

            if (status == "+")
            {
                if ( valu == "") { 
                        valu = "0";
                }
                b = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
                liste1.Add(b);
                Decimal c = a + b;
                liste1.Add(c);

                BoxErgebnis.Text = c.ToString();
                a = 0;
                b = 0;
                valu = "";
            }
            else if (status == "-")
            {
                if (valu == "")
                {
                    valu = "0";
                }
                b = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
                liste1.Add(b);
                Decimal c = a - b;
                liste1.Add(c);

                BoxErgebnis.Text = c.ToString();
                a = 0;
                b = 0;
                valu = "";
            }
            else if (status == "*")
            {
                if (valu == "")
                {
                    valu = "0";
                }
                b = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
                liste1.Add(b);
                Decimal c = a * b;
                liste1.Add(c);

                BoxErgebnis.Text = c.ToString();
                a = 0;
                b = 0;
                valu = "";
                for (int i = 0; i < liste1.Count; i++)
                {
                    Kblock.Text = liste1[i].ToString();
                }
            }
            else if ( status == "/")
            {
                if (valu == "")
                {
                    valu = "0";
                }
                b = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
                liste1.Add(b);
                if ( a == 0 )
                {
                    a = 1;
                }
                if ( b == 0)
                {
                    b = 1;
                }

                Decimal c = a / b;
                liste1.Add(c);

                BoxErgebnis.Text = c.ToString();
                a = 0;
                b = 0;
                valu = "";
            }
         
        }

        private void Bmal_Click(object sender, RoutedEventArgs e)
        {
            status = "*";
            if(valu == "0")
            {
                valu = "1";
            }
            if (valu.Substring(0, 1) == ".")
            {
                valu = "0" + valu;
            }
            a = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
            liste1.Add(a);
            valu = "";
            BoxErgebnis.Text = valu;

        }

        private void Bgeteilt_Click(object sender, RoutedEventArgs e)
        {
            status = "/";
            if (valu.Substring(0, 1) == ".")
            {
                valu = "0" + valu;
            }
            a = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
            liste1.Add(a);
            valu = "";
            BoxErgebnis.Text = valu;

        }

        private void Bminus_Click(object sender, RoutedEventArgs e)
        {
            status = "-";
            if (valu.Substring(0, 1) == ".")
            {
                valu = "0" + valu;
            }
            a = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
            liste1.Add(a);
            valu = "";
            BoxErgebnis.Text = valu;
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            valu = "";
        }
    }
}
