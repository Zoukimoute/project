using SQLConnexion.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_BusinessGame
{
    public static class SQLManager
    {
        public static string CreerClient(string nom, string prenom,string mail,string password)
        {
            return $"INSERT INTO utilisateur SET Nom=\"{nom}\", Prenom=\"{prenom}\", Mail=\"{mail}\", Password=\"{password}\"";
        }

        /// <summary>
        /// Recherche par l'ID dans la table T indiquée.
        /// </summary>
        /// <typeparam name="T"> est la table SQL</typeparam>
        /// <param name="id">sera la valeur recherchée</param>
        /// <returns></returns>
        public static string GetByID<T>(int id)
        {
            return $"SELECT * FROM {typeof(T).Name} WHERE ID = {id}";
        }

        public static string ConnexionClient(string mail, string password)
        {
            return $"SELECT * FROM Utilisateur WHERE Mail=\"{mail}\" and Password=\"{password}\"";
        }

        public static string AddProduit(string nom, int prix, int quantite, string description, string image)
        {
            return $"INSERT INTO Produit SET Nom=\"{nom}\",Prix=\"{prix}\",quantite=\"{quantite}\",description=\"{description}\",image=\"{image}\"";
        }

        public static string GetAll<T>()
        {
            return $"SELECT * FROM {typeof(T).Name}";
        }

        public static string GetPanier<T>(int idUtilisateur)
        {
            return $"SELECT produit.ID,produit.Nom,Prix,panier.Quantite,Description,Image FROM produit,panier WHERE UtilisateurID = \"{idUtilisateur}\" && produit.ID = ProduitID";
        }

        /// <summary>
        /// Ajoute ou modifie un article dans la panier de l'utilisateur
        /// </summary>
        /// <param name="idu"></param>
        /// <param name="idp"></param>
        /// <param name="quantite"></param>
        /// <param name="modification">indique si le produit doit être modifié(true) ou ajouté(false)</param>
        /// <returns></returns>
        public static string AjouterPanier(int idu, int idp,int quantite,bool modification = false)
        {
            if(modification)
                return $"UPDATE panier SET Quantite=\"{quantite}\" WHERE UtilisateurId=\"{idu}\" and ProduitID=\"{idp}\"";
            return $"INSERT INTO panier SET UtilisateurId=\"{idu}\", ProduitID=\"{idp}\", Quantite=\"{quantite}\"";
        }
        public static string SupprimerUtilisateur(int id)
        {
            return $"DELETE FROM utilisateur WHERE ID =\"{id}\"";
        }
    }
}