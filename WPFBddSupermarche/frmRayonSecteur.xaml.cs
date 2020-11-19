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
using System.Windows.Shapes;
using MetierBdd;

namespace WPFBddSupermarche
{
    /// <summary>
    /// Logique d'interaction pour frmRayonSecteur.xaml
    /// </summary>
    public partial class frmRayonSecteur : Window
    {
        GestionnaireBdd gstBdd;
        public frmRayonSecteur(GestionnaireBdd unGst)
        {
            InitializeComponent();
            gstBdd = unGst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gstBdd = new GestionnaireBdd();
            cboSecteur.ItemsSource = gstBdd.GetAllSecteur();
        }
        private void CboSecteur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cboSecteur.SelectedItem != null)
            {
                lstRayonSecteur.ItemsSource = gstBdd.GetAllRayonByNumSecteur((cboSecteur.SelectedItem as Secteur).NumS);
            }
        }
    }
}
