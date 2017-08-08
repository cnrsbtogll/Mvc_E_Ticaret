using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeonTicaret.WebUI.App_Classes;

namespace ZeonTicaret.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Sepet()
        {
            return PartialView();
        }
        public PartialViewResult Slider()
        {
            var data = Context.Baglanti.Resims.Where(x => x.BuyukYol.Contains("Slider")).ToList();

            return PartialView(data);
        }
        public PartialViewResult YeniUrunler()
        {
            var data = Context.Baglanti.Uruns.ToList();
            return PartialView(data);
        }
        public PartialViewResult Servisler()
        {
            return PartialView();
        }        
        public PartialViewResult Markalar()
        {
            var data = Context.Baglanti.Markas.ToList();
            return PartialView(data);
        }     
       
    }
}