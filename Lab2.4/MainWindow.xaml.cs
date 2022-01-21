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

namespace Lab2._4
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

        private void usd_rubCount_Click(object sender, RoutedEventArgs e)
        {
            double usd_rubRate = Convert.ToDouble(usd_rub.Text);
            double usdAmount = Convert.ToDouble(usd_rubAmount.Text);
            usd_rubTB.Text = (usd_rubRate * usdAmount).ToString();
        }

        private void eur_rubCount_Click(object sender, RoutedEventArgs e)
        {
            double eur_rubRate = Convert.ToDouble(eur_rub.Text);
            double eurAmount = Convert.ToDouble(eur_rubAmount.Text);
            eur_rubTB.Text = (eur_rubRate * eurAmount).ToString();
        }

        private void uah_rubCount_Click(object sender, RoutedEventArgs e)
        {
            double uah_rubRate = Convert.ToDouble(uah_rub.Text);
            double uahAmount = Convert.ToDouble(uah_rubAmount.Text);
            uah_rubTB.Text = (uah_rubRate * uahAmount).ToString();
        }

        private void tkl_rubCount_Click(object sender, RoutedEventArgs e)
        {
            double tkl_rubRate = Convert.ToDouble(tkl_rub.Text);
            double tklAmount = Convert.ToDouble(tkl_rubAmount.Text);
            tkl_rubTB.Text = (tkl_rubRate * tklAmount).ToString();
        }

        private void inch_metCount_Click(object sender, RoutedEventArgs e)
        {
            double inchesVal = Convert.ToDouble(inches.Text);
            inch_metTB.Text = (inchesVal * 0.0254).ToString();
        }

        private void feet_metCount_Click(object sender, RoutedEventArgs e)
        {
            double feetVal = Convert.ToDouble(feet.Text);
            feet_metTB.Text = (feetVal * 0.3048).ToString();
        }

        private void mil_metCount_Click(object sender, RoutedEventArgs e)
        {
            double milVal = Convert.ToDouble(miles.Text);
            mil_metTB.Text = (milVal * 1609.344).ToString();
        }

        private void yards_metCount_Click(object sender, RoutedEventArgs e)
        {
            double yardsVal = Convert.ToDouble(yards.Text);
            yards_metTB.Text = (yardsVal * 0.9144).ToString();
        }
    }
}
