using SQLConnexion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E_BusinessGame.Repository.Base
{
    public class baseRepository
    {
       public BDD _BDD = new BDD();

        public T GetByID<T>(int id)
        {
            var Result = _BDD.ResultatRequeteSQL(SQLManager.GetByID<T>(id));
            if (Result.Count == 0)
                return default;
            return (T)Activator.CreateInstance(typeof(T),Result.First());
        }

        public List<T> GetAll<T>()
        {
            var Result = _BDD.ResultatRequeteSQL(SQLManager.GetAll<T>());
            List<T> tmp = new List<T>();
            foreach (string[] entree in Result)
                tmp.Add((T)Activator.CreateInstance(typeof(T),entree));
            return tmp;
        }
    }
}