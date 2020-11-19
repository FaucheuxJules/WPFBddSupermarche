using System;
using System.Collections.Generic;
using System.Text;

namespace MetierBdd
{
    public class Secteur
    {
        private int numS;
        private string nomS;

    public Secteur(int unNumS, string unNomS)
        {
            NumS = unNumS;
            NomS = unNomS;
        }

        public int NumS { get => numS; set => numS = value; }
        public string NomS { get => nomS; set => nomS = value; }
    }
}
