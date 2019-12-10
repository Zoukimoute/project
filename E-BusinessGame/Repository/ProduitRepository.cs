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
    public class ProduitRepository<T> : baseRepository where T : baseModel
    {
       
        public ProduitRepository()
        {

        }
        public T GetByID(int id)
        {
            return base.GetByID<T>(id);
        }

        public List<Produit> GetAll()
        {
            return base.GetAll<Produit>();
        }
    }
}