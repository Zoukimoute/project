using E_BusinessGame.Controllers.Base;
using E_BusinessGame.Models;
using E_BusinessGame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_BusinessGame.Controllers
{
    public class UtilisateurController : baseController
    {
        private UtilisateurRepository<Utilisateur> _utilisateurRepository = new UtilisateurRepository<Utilisateur>();
        private PanierRepository<Produit> _panierRepository = new PanierRepository<Produit>();
        // GET: Utilisateur
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enregistrement()
        {
            return View();
        }

        public ActionResult Nouveau(string prenom, string nom, string mail, string password)
        {
            if(_utilisateurRepository.getall().First(x => x.Email == mail) != null)
            {
                ViewData["ErreurMessage"] = "Erreur le mail est déjà associé à un compte";
            }
            else
            {
                var utilisateur = new Utilisateur(new string[] { "0", nom, prenom, mail, password });
                if (_utilisateurRepository.UpdateOrCreate(utilisateur))
                {
                    _utilisateurRepository.getall().First(x => x.Email == mail && x.Password == password);
                    if (_utilisateurRepository != null)
                    {
                        HttpContext.Response.Cookies.Set(new HttpCookie("Connect", utilisateur.ID.ToString()));
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewData["ErreurMessage"] = "Erreur critique.";
                    }
                }
                else
                {
                    ViewData["ErreurMessage"] = "Erreur le mail est déjà associé à un compte";
                }
            }
            return View("Enregistrement");
        }

        public ActionResult Connexion()
        {
            return View();
        }

        public ActionResult ConnexionForm(string mail, string password)
        {
            var utilisateur = _utilisateurRepository.Connexion(mail, password);
            if(utilisateur == null)
            {
                ViewData["ErreurMessage"] = "Erreur d'identifiant ou de mot de passe";
                return View("Connexion");
            }
            HttpContext.Response.Cookies.Set(new HttpCookie("Connect", utilisateur.ID.ToString()));
            return RedirectToAction("Index", "Home");
        }

        public ActionResult All()
        {
            return View(_utilisateurRepository.getall());
        }

        public void AjouterProduit(int id, int quantite=1)
        {
            _panierRepository.AjouterPanier(GetUtilisateurCourant(), id, quantite);
        }

        public ActionResult Panier()
        {
            return View(_panierRepository.GetAll(GetUtilisateurCourant()));
        }

        public ActionResult Supprimer()
        {
            _utilisateurRepository.Supprimer(GetUtilisateurCourant());
            return View();
        }
    }
}