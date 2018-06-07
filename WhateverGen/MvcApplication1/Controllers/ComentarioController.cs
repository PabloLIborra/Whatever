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
    public class ComentarioController : BasicController
    {
        //
        // GET: /Comentario/

        public ActionResult ComentarioEvento(int id)
        {
            SessionInitialize();
            ComentarioCAD cad = new ComentarioCAD(session);
            var aux = cad.FiltrarComentarioPorEvento(id);

            SessionClose();

            return View(aux);
        }

        public ActionResult ComentarioGymkana(int id)
        {
            SessionInitialize();
            ComentarioCAD cad = new ComentarioCAD(session);
            var aux = cad.FiltrarComentarioPorGymkana(id);

            SessionClose();

            return View(aux);
        }

        public ActionResult ComentarioReto(int id)
        {
            SessionInitialize();
            ComentarioCAD cad = new ComentarioCAD(session);
            var aux = cad.FiltrarComentarioPorReto(id);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /Comentario/CreateGymkana

        public ActionResult CreateGymkana(int id)
        {
            SessionInitialize();

            Comentario com = new Comentario();

            com.Creador = User.Identity.Name;
            com.idGymkana = id;

            SessionClose();
            return View(com);
        }

        //
        // GET: /Comentario/CreateEvento

        public ActionResult CreateEvento(int id)
        {
            SessionInitialize();

            Comentario com = new Comentario();

            com.Creador = User.Identity.Name;
            com.idEvento = id;

            SessionClose();
            return View(com);
        }

        //
        // GET: /Comentario/CreateReto

        public ActionResult CreateReto(int id)
        {
            SessionInitialize();

            Comentario com = new Comentario();

            com.Creador = User.Identity.Name;
            com.idReto = id;

            SessionClose();
            return View(com);
        }

        //
        // POST: /Comentario/CreateEvento

        [HttpPost]
        public ActionResult CreateEvento(Comentario com)
        {
            try
            {
                UsuarioCAD usucad = new UsuarioCAD();
                UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
                ComentarioCP comcp = new ComentarioCP();
                EventoCAD evcad = new EventoCAD();
                EventoEN even = evcad.GetID(com.id);

                comcp.CrearComentarioParaEvento(even.ID, com.Texto, usuen.ID);

                return RedirectToAction("ComentarioEvento", new { id = com.id });

            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Comentario/CreateGymkana

        [HttpPost]
        public ActionResult CreateGymkana(Comentario com)
        {
            try
            {
                UsuarioCAD usucad = new UsuarioCAD();
                UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
                ComentarioCP comcp = new ComentarioCP();
                GymkanaCAD gymcad = new GymkanaCAD();
                GymkanaEN gymen = gymcad.GetID(com.id);

                comcp.CrearComentarioParaGymkana(gymen.ID, com.Texto, usuen.ID);

                return RedirectToAction("ComentarioGymkana", new { id = com.id });

            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Comentario/CreateReto

        [HttpPost]
        public ActionResult CreateReto(Comentario com)
        {
            try
            {
                UsuarioCAD usucad = new UsuarioCAD();
                UsuarioEN usuen = usucad.FiltrarUsuarioPorNombre(User.Identity.Name);
                ComentarioCP comcp = new ComentarioCP();
                RetoCAD retcad = new RetoCAD();
                RetoEN reten = retcad.GetID(com.id);

                comcp.CrearComentarioParaReto(reten.ID, com.Texto, usuen.ID);

                return RedirectToAction("ComentarioReto", new { id = com.id });

            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Comentario/Delete/5

        public ActionResult Delete(int id)
        {
            Comentario com = null;
            SessionInitialize();
            ComentarioEN comen = new ComentarioCAD(session).ReadOIDDefault(id);
            com = new AssemblerComentario().ConvertENToModelUI(comen);
            UsuarioEN usu = com.usuario;
            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            SessionClose();
            return View(com);
        }

        //
        // POST: /Comentario/DeleteEvento/5

        [HttpPost]
        public ActionResult Delete(Comentario com)
        {
           try
            {
                ComentarioCP cp = new ComentarioCP();
                ComentarioEN comen = new ComentarioCAD().GetID(com.id);
                cp.BorrarUnComentario(com.id);
                if (comen.Evento != null)
                    return RedirectToAction("ComentarioEvento", new { id = comen.Evento.ID });
                else if (comen.Gymkana != null)
                    return RedirectToAction("ComentarioGymkana", new { id = comen.Gymkana.ID });
                else 
                    return RedirectToAction("ComentarioReto", new { id = comen.Reto.ID });

            }
            catch
            {
                return View();
            }
        }
    }
}
