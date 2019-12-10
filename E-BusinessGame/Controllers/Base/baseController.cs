using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_BusinessGame.Controllers.Base
{
    public class baseController : Controller
    {
        public baseController()
        {
                
        }

        /// <summary>
        /// Retourne l'ID de l'utilisateur courant.
        /// </summary>
        /// <returns></returns>
        protected int GetUtilisateurCourant()
        {
          return int.Parse(HttpContext.Request.Cookies.Get("Connect").Value);
        }
    }
}