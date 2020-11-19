using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierBdd
{
    public class Rayon
    {
        private int numR;
        private string nomR;
        


        public Rayon(int unNumR, string unNomR)
        {
            NumR = unNumR;
            NomR = unNomR;
            
        }

        public int NumR { get => numR; set => numR = value; }
        public string NomR { get => nomR; set => nomR = value; }
        
    }

}
