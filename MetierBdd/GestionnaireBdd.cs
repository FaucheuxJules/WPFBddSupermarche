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
        public List<Employe> getAllEmploye()
        {
            List<Employe> mesEmployes = new List<Employe>();
            cmd = new MySqlCommand("Select numE, prenomE from employe", cnx);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Employe unEmploye = new Employe(Convert.ToInt16(dr[0]), dr[1].ToString());
                mesEmployes.Add(unEmploye);
            }
            dr.Close();
            return mesEmployes;
            
        }

        public int GetLastNumCateg()
        {
            int max;
            cmd = new MySqlCommand("select max(numE) from employe", cnx);
            dr = cmd.ExecuteReader();
            dr.Read();
            max = Convert.ToInt16(dr[0].ToString()) + 1;

            return max;
        }
        public void EnregistrerEmploye(int numE, string prenomE)
        {
            cmd = new MySqlCommand("insert into employe VALUES ("+numE+",' "+prenomE+"')",cnx);
            cmd.ExecuteNonQuery();

        }
    }
}
