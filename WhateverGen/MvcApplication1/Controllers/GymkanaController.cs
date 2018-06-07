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

    public class GymkanaController : BasicController
    {
        //
        // GET: /Gymkana/

        public ActionResult Index()
        {
            
            SessionInitialize();
            GymkanaCAD cad = new GymkanaCAD(session);
            var aux = cad.ReadAllDefault(0, 0);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /Gymkana/Details/5

        public ActionResult Details(int id)
        {
            Gymkana gym = null;
            SessionInitialize();
            GymkanaEN gymen = new GymkanaCAD(session).ReadOIDDefault(id);
            gym = new AssemblerGymkana().ConvertENToModelUI(gymen);
            SessionClose();
            return View(gym);
        }

        //
        // GET: /Gymkana/Create

        public ActionResult Create()
        {
            SessionInitialize();

            Gymkana gym = new Gymkana();
            gym.Creador = User.Identity.Name;
            gym.Puntuaciones = null;

            SessionClose();

            return View(gym);
        }

        //
        // POST: /Gymkana/Create

        [HttpPost]
        public ActionResult Create(Gymkana gym)
        {
            try
            {
                GymkanaCP cp = new GymkanaCP();
                GymkanaEN en = new GymkanaEN();
                UsuarioCAD cad = new UsuarioCAD();


                en.Titulo = gym.Titulo;
                en.Descripcion = gym.Descripcion;
                en.Fecha = gym.Fecha;
                en.Usuario = cad.FiltrarUsuarioPorNombre(User.Identity.Name);
                en.Precio = gym.Precio;
                en.NumPasos = 0;

                cp.CrearGymkana(en, gym.Latitud, gym.Longitud, gym.Zoom);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Gymkana/Edit/5

        public ActionResult Edit(int id)
        {
            Gymkana gym = null;
            SessionInitialize();
            GymkanaEN gymen = new GymkanaCAD(session).ReadOIDDefault(id);
            gym = new AssemblerGymkana().ConvertENToModelUI(gymen);
            UsuarioEN usu = gym.usuario;
            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Details", new { id = id });
            }
            SessionClose();
            return View(gym);

        }

        //
        // POST: /Gymkana/Edit/5

        [HttpPost]
        public ActionResult Edit(Gymkana gym)
        {
            try
            {
                GymkanaCEN cen = new GymkanaCEN();
                cen.Modify(gym.id,gym.Numeropasos,gym.Titulo,gym.Descripcion,gym.Fecha,gym.Precio);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Gymkana/Delete/5

        public ActionResult Delete(int id)
        {
            Gymkana gym = null;
            SessionInitialize();
            GymkanaEN gymen = new GymkanaCAD(session).ReadOIDDefault(id);
            gym = new AssemblerGymkana().ConvertENToModelUI(gymen);
            UsuarioEN usu = gym.usuario;
            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Details", new { id = id });
            }
            SessionClose();
            return View(gym);
        }

        //
        // POST: /Gymkana/Delete/5

        [HttpPost]
        public ActionResult Delete(Gymkana gym)
        {
            try
            {
                GymkanaCP cp = new GymkanaCP();
                cp.BorrarGymkana(gym.id);


                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Gymkana/List

        public ActionResult List()
        {
            SessionInitialize();
            GymkanaCAD cad = new GymkanaCAD(session);
            UsuarioCAD usucad = new UsuarioCAD(session);
            UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
            var aux = cad.FiltrarGymkanaPorUsuario(usuen.ID);

            SessionClose();

            return View(aux);
        }
    }
}
