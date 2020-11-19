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
using MetierBdd;

namespace WPFBddSupermarche
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GestionnaireBdd gstBdd;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRayonSecteur_Click(object sender, RoutedEventArgs e)
        {
            frmRayonSecteur frm = new frmRayonSecteur(gstBdd);
            frm.Show();

        }

        private void BtnNewEmploye_Click(object sender, RoutedEventArgs e)
        {
            frmNewEmploye frm = new frmNewEmploye(gstBdd);
            frm.Show();
        }

        private void BtnGestionH_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gstBdd = new GestionnaireBdd();
                
        }
    }
}
