using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.CP.Whatever;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Controllers
{
    [Authorize(Roles = "usuario")]
    public class EventoController : BasicController
    {
        //
        // GET: /Evento/

        public ActionResult Index()
        {
            SessionInitialize();
            EventoCAD cad = new EventoCAD(session);
            var aux = cad.GetAll(0, 0);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /Evento/Details/5

        public ActionResult Details(int id)
        {
            Evento ev = null;
            SessionInitialize();
            EventoEN evEN = new EventoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerEvento().ConvertENToModelUI(evEN);
            SessionClose();
            return View(ev);
        }

        //
        // GET: /Evento/Create

        public ActionResult Create()
        {
            SessionInitialize();

            Evento ev = new Evento();
            ev.Creador = User.Identity.Name;

            SessionClose();
            return View(ev);
        }

        //
        // POST: /Evento/Create

        [HttpPost]
        public ActionResult Create(Evento ev)
        {            
            try
            {
                UsuarioCAD cad = new UsuarioCAD();
                EventoCP cp = new EventoCP();
                EventoEN even = new EventoEN();
                even.Descripcion = ev.Descripcion;
                even.Fecha = ev.Fecha;
                even.Precio = ev.Precio;
                even.Titulo = ev.Titulo;
                even.Usuario = cad.FiltrarUsuarioPorNombre(User.Identity.Name);
                cp.CrearEvento(even, ev.Latitud,ev.Longitud,ev.Zoom);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Evento/Edit/5

        public ActionResult Edit(int id)
        {
            Evento ev = null;
            SessionInitialize();
            EventoEN even = new EventoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerEvento().ConvertENToModelUI(even);
            UsuarioEN usu = ev.usuario;
            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Details", new { id = id });
            }
            SessionClose();
            return View(ev);

        }

        //
        // POST: /Evento/Edit/5

        [HttpPost]
        public ActionResult Edit(Evento ev)
        {
            try
            {
                EventoCEN cen = new EventoCEN();

                cen.Modify(ev.id,ev.Titulo,ev.Descripcion,ev.Fecha,ev.Precio);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Evento/Delete/5

        public ActionResult Delete(int id)
        {
            Evento ev = null;
            SessionInitialize();
            EventoEN even = new EventoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerEvento().ConvertENToModelUI(even);
            UsuarioEN usu = ev.usuario;
            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Details", new { id = id });
            }
            SessionClose();
            return View(ev);
        }

        //
        // POST: /Evento/Delete/5

        [HttpPost]
        public ActionResult Delete(Evento ev)
        {
            try
            {

                EventoCP cp = new EventoCP();
                cp.BorrarEvento(ev.id);


                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Evento/List

        public ActionResult List()
        {
            SessionInitialize();
            EventoCAD cad = new EventoCAD(session);
            UsuarioCAD usucad = new UsuarioCAD(session);
            UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
            var aux = cad.FiltrarEventoPorUsuario(usuen.ID);

            SessionClose();

            return View(aux);
        }
    }
}
