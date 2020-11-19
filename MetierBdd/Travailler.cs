using System;
using System.Collections.Generic;
using System.Text;

namespace MetierBdd
{
    public class Travailler
    {
        private int codeE;
        private int codeR;
        private DateTime date;
        private int temps;

        public Travailler (int unCodeE, int uncodeR, DateTime uneDate, int unTemps)
        {
            CodeE = unCodeE;
            CodeR = uncodeR;
            Date = uneDate;
            Temps = unTemps;
        }

        public int CodeE { get => codeE; set => codeE = value; }
        public int CodeR { get => codeR; set => codeR = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Temps { get => temps; set => temps = value; }
    }
}
