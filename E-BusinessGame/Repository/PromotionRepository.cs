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
    public class PromotionRepository<T> : baseRepository where T : baseModel
    {
        private Secure _secure = new Secure();
        public PromotionRepository()
        {
            
        }

        public T GetByID(int id)
        {
            return base.GetByID<T>(id);
        }
        public List<Promotion> GetAll()
        {
          return base.GetAll<Promotion>();
        }
    
        public Promotion GetByName(string name)
        {
            return GetAll().FirstOrDefault(x => x.Nom.ToLower().Contains(name.ToLower()));
        }
    }
}