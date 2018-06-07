using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.CP.Whatever;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Controllers
{
    public class HomeController : BasicController
    {
        public ActionResult Index()
        {
            SessionInitialize();
            EventoCAD evt = new EventoCAD(session);
            var aux = evt.GetAll(0, 0);
            RetoCAD ret = new RetoCAD(session);
            var aux2 = ret.GetAll(0, 0);
            GymkanaCAD gym = new GymkanaCAD(session);
            var aux3 = gym.GetAll(0, 0);

            ViewData["Eventos"] = aux;
            ViewData["Retos"] = aux2;
            ViewData["Gymkanas"] = aux3;

            SessionClose();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
