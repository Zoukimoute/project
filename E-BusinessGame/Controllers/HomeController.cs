using E_BusinessGame.Models;
using E_BusinessGame.Repository;
using System.Web.Mvc;

namespace E_BusinessGame.Controllers
{
    public class HomeController : Controller
    {
        PromotionRepository<Promotion> _promotionRepository = new PromotionRepository<Promotion>();
        public ActionResult Index()
        {
            var listePromos = _promotionRepository.GetAll();
            return View();
        }

        public ActionResult Connexion()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}