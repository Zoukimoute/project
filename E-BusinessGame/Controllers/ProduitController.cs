using E_BusinessGame.Models;
using E_BusinessGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_BusinessGame.Controllers
{
    public class ProduitController : Controller
    {
        private ProduitRepository<Produit> _produitRepository = new ProduitRepository<Produit>();
        public ActionResult All()
        {
            return View(_produitRepository.GetAll());
        }
    }
}