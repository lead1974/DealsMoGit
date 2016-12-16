using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using DealsMo.DataAccess.Repos;
using DealsMo.Services;
using DealsMo.DataAccess.Models;

namespace DealsMo.Controllers
{
    public class HomeController : Controller
    {
        private IMailService _mail;
        private IGlobalService _global;
        private IUserRepository<User> _user;

        public HomeController() {}

        public HomeController(IMailService mail, IGlobalService global, IUserRepository<User> user)
        {
            _mail = mail;
            _global = global;
            _user = user;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}