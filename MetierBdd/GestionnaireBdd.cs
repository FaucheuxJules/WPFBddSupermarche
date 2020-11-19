using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace MetierBdd
{
    public  class GestionnaireBdd
    {
        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataReader dr;

        public GestionnaireBdd()
        {
            string chaine = "Server=localhost; Database=supermarche; Uid = root; Pwd = ";
            cnx = new MySqlConnection(chaine);
            cnx.Open();
        }
        public List<Secteur> GetAllSecteur()
        {
            List<Secteur> mesSecteurs = new List<Secteur>();
            cmd = new MySqlCommand("SELECT numS, nomS FROM secteur", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Secteur unSecteur = new Secteur(Convert.ToInt16(dr[0]), dr[1].ToString());
                mesSecteurs.Add(unSecteur);
            }
            dr.Close();
            return mesSecteurs;
            //Yass
        }
        public List<Rayon> GetAllRayonByNumSecteur(int numSecteur)
        {
            List<Rayon> mesRayons = new List<Rayon>();

            cmd = new MySqlCommand("SELECT numR, nomR FROM rayon where numSecteur ="+ numSecteur, cnx);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Rayon unRayon = new Rayon(Convert.ToInt16(dr[0]), dr[1].ToString());
                mesRayons.Add(unRayon);
            }
            dr.Close();
            return mesRayons;
        }

    }
}
