using E_BusinessGame.Models;
using E_BusinessGame.Models.Base;
using E_BusinessGame.Repository.Base;
using SQLConnexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_BusinessGame.Repository
{
    public class PanierRepository<T> : baseRepository where T : baseModel
    {

        private ProduitRepository<Produit> _produitRepository = new ProduitRepository<Produit>();
        public PanierRepository()
        {

        }
        public T GetByID(int id)
        {
            return base.GetByID<T>(id);
        }

        public List<Produit> GetAll(int idUtilisateur)
        {
            var liste = new List<Produit>();
            foreach (string[] produitTab in _BDD.ResultatRequeteSQL(SQLManager.GetPanier<Produit>(idUtilisateur)))
            {
                liste.Add(new Produit(produitTab));
            }
            return liste;
        }

        public bool AjouterPanier(int idu, int idp,int quantite)
        {
            var produit = _produitRepository.GetByID(idp);
            if (produit != null)
            {
                var produitExistDansPanier = GetAll(idu).FirstOrDefault(x => x.ID == idp);
                if (produitExistDansPanier != null) //Déjà présent
                {
                    return _BDD.ExecuterCommandeSQL(SQLManager.AjouterPanier(idu, idp, quantite,true));
                }
                else
                {
                    return _BDD.ExecuterCommandeSQL(SQLManager.AjouterPanier(idu, idp, quantite));
                }
            }
            return false;
        }
    }
}