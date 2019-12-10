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
    public class Promotion : baseModel
    {
        public string Nom;
        public int Montant;
        public string Code;

        public Promotion()
        {
            
        }

        public Promotion(params object[] args)
        {
            ID = int.Parse(args[0].ToString());
            Nom = args[1].ToString();
            Montant = int.Parse(args[2].ToString());
            Code = args[3].ToString();
        }

       
    }
}