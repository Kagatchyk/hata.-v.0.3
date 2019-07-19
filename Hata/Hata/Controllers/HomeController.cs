using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Hata.Controllers
{
    public class MusicList
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
    public class HomeController : Controller
    {

        MusicList musicList = new MusicList();
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(MusicList list)
        {
            if (list.Price < 100)
            {
                ViewBag.Message = "Вовк";
            }
            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
       
        public ActionResult Contact(int id)
        {
            ViewBag.Message = id*2;

            return View();
        }

    }
}