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
using Taschenrechner;

namespace Taschenrechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RechenCore tr = new RechenCore();
        List<string> liste1 = new List<string>();
        List<string> listeZR = new List<string>();

        string ergebnis = "";
        string valu = "";


        

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

            liste1.Add(valu);
            liste1.Add("+");
            valu = "";
            
        }

        private void Bgleich_Click(object sender, RoutedEventArgs e)
        {
            liste1.Add(valu);
            for( int i = 0; i < liste1.Count(); i++)
            {
                listeZR.Add(liste1[i]);
            }

            decimal test = tr.Berechnung(liste1);
            ergebnis = test.ToString();
            
            listeZR.Add("=" + ergebnis+"\n");

            sInListe();
            valu = "";
            liste1.Clear();
            listeZR.Clear();
        }

        private void Bmal_Click(object sender, RoutedEventArgs e)
        {

            liste1.Add(valu );
            liste1.Add("*");
            valu = "";
        }
            
        private void Bgeteilt_Click(object sender, RoutedEventArgs e)
        {


            liste1.Add(valu);
            liste1.Add("/");
            valu = "";
        }

        private void Bminus_Click(object sender, RoutedEventArgs e)
        {


            liste1.Add(valu );
            liste1.Add("-");

            valu = "";
        }

        private void BClear_Click(object sender, RoutedEventArgs e)
        {

            valu = "";
            liste1.Clear();
            listeZR.Clear();
        }

        private void sInListe()
        {
            for (int i =0; i < listeZR.Count(); i++)
            {

                Kblock.Text +=  listeZR[i] ;
                
            };
            listeZR.Clear();
        }

    }
}
