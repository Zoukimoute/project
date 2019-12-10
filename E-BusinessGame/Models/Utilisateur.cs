using E_BusinessGame.Models.Base;
using E_BusinessGame.Repository;
using SQLConnexion;
using SQLConnexion.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_BusinessGame.Models
{
    public class Utilisateur : baseModel
    {
        public string Nom;
        public string Prenom;
        public string Email;
        public string Password;
        public List<Produit> Panier = new List<Produit>();
        private Secure _secure = new Secure();

        public Utilisateur()
        {

        }

        public Utilisateur(params object[] args)
        {
            ID = int.Parse(args[0].ToString());
            Nom = args[1].ToString();
            Prenom = args[2].ToString();
            Email = args[3].ToString();
            Password = args[4].ToString();
        }

        public void AjouterProduit(Produit p)
        {
            if (p != null)
            {
                Panier.Add(p);
            }
        }
    }
}