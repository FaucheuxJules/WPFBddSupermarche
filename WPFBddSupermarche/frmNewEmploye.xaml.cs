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
    /// Logique d'interaction pour frmNewEmploye.xaml
    /// </summary>
    public partial class frmNewEmploye : Window
    {
        GestionnaireBdd gstBdd;
        public frmNewEmploye(GestionnaireBdd unGst)
        {
            InitializeComponent();
            gstBdd = unGst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gstBdd = new GestionnaireBdd();
        }
        private void BtnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            gstBdd.EnregistrerEmploye(Convert.ToInt16(txtnumEmploye.Text), txtnomEmploye.Text);
            lstEmploye.ItemsSource = null;
            lstEmploye.ItemsSource = gstBdd.getAllEmploye();
            txtnumEmploye.Text = gstBdd.GetLastNumCateg().ToString();
            txtnomEmploye.Text = "";

        }
    }
}
