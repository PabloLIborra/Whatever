using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CP.Whatever;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Controllers
{
    [Authorize(Roles = "usuario")]

    public class ReporteController : BasicController
    {
        //
        // GET: /Reporte/
        public ActionResult Index()
        {
            SessionInitialize();
            ReporteCAD cad = new ReporteCAD(session);
            var aux = cad.GetAll(0,0);

            SessionClose();

            return View(aux);
        }

        public ActionResult IndexEvento(int id)
        {
            SessionInitialize();
            ReporteCAD cad = new ReporteCAD(session);
            var aux = cad.FiltrarReportesPorEvento(id);

            SessionClose();

            return View(aux);
        }

        public ActionResult IndexGymkana(int id)
        {
            SessionInitialize();
            ReporteCAD cad = new ReporteCAD(session);
            var aux = cad.FiltrarReportesPorGymkana(id);

            SessionClose();

            return View(aux);
        }

        public ActionResult IndexReto(int id)
        {
            SessionInitialize();
            ReporteCAD cad = new ReporteCAD(session);
            var aux = cad.FiltrarReportesPorReto(id);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /Reporte/Details/5

        public ActionResult Details(int id)
        {
            Reporte rep = null;
            SessionInitialize();
            ReporteEN pasEN = new ReporteCAD(session).ReadOIDDefault(id);
            rep = new AssemblerReporte().ConvertENToModelUI(pasEN);
            if (!Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            SessionClose();
            return View(rep);
        }

        //
        // GET: /Reporte/CreateGymkana

        public ActionResult CreateGymkana(int id)
        {
            SessionInitialize();

            Reporte rep = new Reporte();

            rep.idGymkana = id;
            
            SessionClose();
            return View(rep);
        }

        //
        // GET: /Reporte/CreateEvento
        public ActionResult CreateEvento(int id)
        {
            SessionInitialize();

            Reporte rep = new Reporte();

            rep.idEvento = id;

            SessionClose();
            return View(rep);
        }

        //
        // GET: /Reporte/CreateReto
        public ActionResult CreateReto(int id)
        {
            SessionInitialize();

            Reporte rep = new Reporte();

            rep.idReto = id;

            SessionClose();
            return View(rep);
        }

        //
        // POST: /Reporte/CreateEvento

        [HttpPost]
        public ActionResult CreateEvento(Reporte rep)
        {
            try
            {
                UsuarioCAD usucad = new UsuarioCAD();
                UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
                ReporteCP repcp = new ReporteCP();
                EventoCAD evcad = new EventoCAD();
                EventoEN even = evcad.GetID(rep.idEvento);

                repcp.ReportarEvento(usuen.ID, even.ID, rep.Motivo);
                
                return RedirectToAction("IndexEvento", new { id = rep.idEvento });

            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Reporte/CreateGymkana

        [HttpPost]
        public ActionResult CreateGymkana(Reporte rep)
        {
            try
            {
                UsuarioCAD usucad = new UsuarioCAD();
                UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
                ReporteCP repcp = new ReporteCP();
                GymkanaCAD gymcad = new GymkanaCAD();
                GymkanaEN gymen = gymcad.GetID(rep.idGymkana);

                repcp.ReportarGymkana(usuen.ID, gymen.ID, rep.Motivo);

                return RedirectToAction("IndexGymkana", new { id = rep.idGymkana });

            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Reporte/CreateReto

        [HttpPost]
        public ActionResult CreateReto(Reporte rep)
        {
            try
            {
                UsuarioCAD usucad = new UsuarioCAD();
                UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
                ReporteCP repcp = new ReporteCP();
                RetoCAD retcad = new RetoCAD();
                RetoEN reten = retcad.GetID(rep.idReto);

                repcp.ReportarReto(usuen.ID, reten.ID, rep.Motivo);

                return RedirectToAction("IndexReto", new { id = rep.idReto });

            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reporte/Delete/5

        public ActionResult Delete(int id)
        {
            Reporte rep = null;
            SessionInitialize();
            ReporteEN repen = new ReporteCAD(session).ReadOIDDefault(id);
            rep = new AssemblerReporte().ConvertENToModelUI(repen);
            if (!Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            SessionClose();
            return View(rep);
        }

        //
        // POST: /Reporte/Delete/5

        [HttpPost]
        public ActionResult Delete(Reporte rep)
        {
            try
            {
                ReporteCP cp = new ReporteCP();
                ReporteEN repen = new ReporteCAD().GetID(rep.id);
                cp.BorrarUnReporte(rep.id);
                if (repen.Evento != null)
                    return RedirectToAction("IndexEvento", new { id = repen.Evento.ID });
                else if (repen.Gymkana != null)
                    return RedirectToAction("IndexGymkana", new { id = repen.Gymkana.ID });
                else if (repen.Reto != null)
                    return RedirectToAction("IndexReto", new { id = repen.Reto.ID });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
