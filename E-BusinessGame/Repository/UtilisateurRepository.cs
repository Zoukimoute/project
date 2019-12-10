using E_BusinessGame.Models;
using E_BusinessGame.Models.Base;
using E_BusinessGame.Repository.Base;
using SQLConnexion;
using SQLConnexion.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_BusinessGame.Repository
{
    /// <summary>
    /// Utilise le repository Utilisateur en associant le model référant.
    /// </summary>
    /// <typeparam name="T"> doit être le model(table) de la base de donnée</typeparam>
    public class UtilisateurRepository<T> : baseRepository where T : baseModel
    {
        private Secure _secure = new Secure();
        public UtilisateurRepository()
        {
            
        }

        public T GetByID(int id)
        {
            return base.GetByID<T>(id);
        }

        public bool UpdateOrCreate(Utilisateur utilisateur)
        {
            if (_BDD.ExecuterCommandeSQL(SQLManager.CreerClient(utilisateur.Nom, utilisateur.Prenom, utilisateur.Email, utilisateur.Password)))
                return true;
            return false;
        }

        /// <summary>
        /// Chercher un utilisateur par mail et mot de passe
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Utilisateur Connexion(string mail,string password)
        {
            var ListeUtilisateur = _BDD.ResultatRequeteSQL(SQLManager.ConnexionClient(mail, password));
            if (ListeUtilisateur.Count() != 0)
                return new Utilisateur(ListeUtilisateur.First());
            return null;
        }

        public List<Utilisateur> getall()
        {
          return base.GetAll<Utilisateur>();
        }

        public bool Supprimer(int id)
        {
            return _BDD.ExecuterCommandeSQL(SQLManager.SupprimerUtilisateur(id));
        }
    }
}