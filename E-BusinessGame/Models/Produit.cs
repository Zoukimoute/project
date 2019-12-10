using E_BusinessGame.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_BusinessGame.Models
{
    public class Produit : baseModel
    {
        public string Nom;
        public int Prix;
        public int Quantite;
        public string Description;
        public string Image;

        public Produit()
        {

        }

        public Produit(params object[] args)
        {
            ID = int.Parse(args[0].ToString());
            Nom = args[1].ToString();
            Prix = int.Parse(args[2].ToString());
            Quantite = int.Parse(args[3].ToString());
            Description = args[4].ToString();
            Image = args[5].ToString();
        }
    }
}