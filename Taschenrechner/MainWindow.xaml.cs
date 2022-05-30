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
        List<string> liste1 = new List<string>();
        List<decimal> listeZR = new List<decimal>();

        string status = "";
        string valu = "";
        decimal a;
        decimal b;
        decimal c;
        

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
            if(valu == "")
            {
                valu = "0";
            }
            if (valu.Substring(0, 1) == ".")
            {
                valu = "0" + valu;
            }
            a = decimal.Parse( valu, System.Globalization.CultureInfo.InvariantCulture);
            valu = "";
            BoxErgebnis.Text = a.ToString();
            listeZR.Add(a);
            liste1.Add(a + " + ");
            
        }

        private void Bgleich_Click(object sender, RoutedEventArgs e)
        {
            Kblock.Text = "";
            if (status == "+")
            {

                b = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
                listeZR.Add(b);
                liste1.Add(b.ToString());
                decimal sum = 0;
                for (int i = 0; i < listeZR.Count; i++) {
                    sum = sum + listeZR[i] ;
                }
                listeZR.Clear();
                liste1.Add(" = " + sum.ToString() + "\n");
                valu = sum.ToString();
                listeZR.Add(sum);
                sum = 0;
                a = 0;
                b = 0;
                
            }
            else if (status == "-")
            {

                b = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
                liste1.Add(b.ToString());
                listeZR.Add(b);
                decimal sum = listeZR[0];
                for (int i = 1; i < listeZR.Count; i++)
                {
                    sum = sum - listeZR[i];
                }
                listeZR.Clear();
                liste1.Add(" = "+ sum.ToString() + "\n");
                valu = sum.ToString();
                listeZR.Add(sum);
                sum = 0;
                a = 0;
                b = 0;
            }
            else if (status == "*")
            {
                if (valu == "")
                {
                    valu = "0";
                }
                b = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
                liste1.Add(b.ToString());
                listeZR.Add(b);
                decimal sum = listeZR[0];
                for (int i = 1; i < listeZR.Count; i++)
                {
                    sum = sum * listeZR[i];
                }
                listeZR.Clear();
                liste1.Add(" = " + sum.ToString() + "\n");
                valu = sum.ToString();
                listeZR.Add(sum);
                sum = 0;
                a = 0;
                b = 0;

            }
            else if ( status == "/")
            {

                b = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
                liste1.Add(b.ToString());
                if ( a == 0 )
                {
                    a = 1;
                }
                if ( b == 0)
                {
                    b = 1;
                }

                listeZR.Add(b);
                decimal sum = listeZR[0];

                for (int i = 1; i < listeZR.Count; i++)
                {
                    sum = sum / listeZR[i];
                }
                listeZR.Clear();
                liste1.Add(" = " + sum.ToString() + "\n");
                listeZR.Add(sum);
                valu = sum.ToString();
                sum = 0;
                a = 0;
                b = 0;

            }
            sInListe();
        }

        private void Bmal_Click(object sender, RoutedEventArgs e)
        {
            status = "*";
            if(valu == "")
            {
                valu = "0";
            }
            if(valu == "0")
            {
                valu = "1";
            }
            if (valu.Substring(0, 1) == ".")
            {
                valu = "0" + valu;
            }
            a = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
            
            valu = "";
            BoxErgebnis.Text = a.ToString();
            liste1.Add(a + " * ");
            listeZR.Add(a);
        }

        private void Bgeteilt_Click(object sender, RoutedEventArgs e)
        {
            status = "/";
            if( valu == "")
            {
                valu = "0";
            }
            if (valu.Substring(0, 1) == ".")
            {
                valu = "0" + valu;
            }
            a = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
            
            valu = "";
            BoxErgebnis.Text = a.ToString();
            liste1.Add(a + " / ");
            listeZR.Add(a);
        }

        private void Bminus_Click(object sender, RoutedEventArgs e)
        {
            status = "-";
            if(valu == "")
            {
                valu = "0";
            }
            if (valu.Substring(0, 1) == ".")
            {
                valu = "0" + valu;
            }
            a = decimal.Parse(valu, System.Globalization.CultureInfo.InvariantCulture);
            valu = "";
            BoxErgebnis.Text = a.ToString();
            listeZR.Add(a);
            liste1.Add(a + " - ");
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            valu = "";
            liste1.Clear();
            listeZR.Clear();
        }

        private void sInListe()
        {
            for (int i =0; i < liste1.Count(); i++)
            {

                Kblock.Text +=  liste1[i].ToString() ;
                
            };
        }

    }
}
