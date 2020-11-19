using System;
using System.Collections.Generic;
using System.Text;

namespace MetierBdd
{
    public class Employe
    {
        private int numE;
        private string prenomE;

        public Employe(int unNumE, string unPrenomE)
        {
            NumE = unNumE;
            PrenomE = unPrenomE;
        }

        public int NumE { get => numE; set => numE = value; }
        public string PrenomE { get => prenomE; set => prenomE = value; }
    }
}
