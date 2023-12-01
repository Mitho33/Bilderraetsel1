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

namespace Wpfwm2014
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tm_Click(object sender, RoutedEventArgs e)
           
        {
         
            LabelAnzeige.Content = "Thomas Müller";
        }

        private void Pl_Click(object sender, RoutedEventArgs e)

        {

            LabelAnzeige.Content = "Philipp Lahm";
        }

        private void Mg_Click(object sender, RoutedEventArgs e)
        {
            LabelAnzeige.Content = "Mario Götze";
        }

        private void As_click(object sender, RoutedEventArgs e)
        {
            LabelAnzeige.Content = "Andre Schürrle";
        }

         private void Gb_click(object sender, RoutedEventArgs e)
        {
            LabelAnzeige.Content = "Gerome Boateng";
        }
        private void Mh_click(object sender, RoutedEventArgs e)
        {
            LabelAnzeige.Content = "Mats Hummels";
        }

        private void MJ_click(object sender, RoutedEventArgs e)//zum Erzeugen der Methoden in den 
          //  Eigenschaften des Steuerelements auf Ereignishandler gehen und bei Klick mit LM doppelklick
        {
            LabelAnzeige.Content = "Marcell Jansen";
        }
        private void Bh_click(object sender, RoutedEventArgs e)
        {
            LabelAnzeige.Content = "Benjamin Höwedes";
        }
        private void Sk_click(object sender, RoutedEventArgs e)
        {
            LabelAnzeige.Content = "Sami Khedira";
        }

        private void Tk_click(object sender, RoutedEventArgs e)
        {
            LabelAnzeige.Content = "Toni Kroos";
        }

        private void Mn_click(object sender, RoutedEventArgs e)
        {
            LabelAnzeige.Content = "Manuel Neuer";
        }

    }
}
