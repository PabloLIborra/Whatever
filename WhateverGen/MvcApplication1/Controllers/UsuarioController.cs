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
    [Authorize(Roles = "usuario")]

    public class UsuarioController : BasicController
    {
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            if (Roles.IsUserInRole("usuario"))
            {
                SessionInitialize();
                UsuarioCAD cad = new UsuarioCAD(session);
                var aux = cad.ReadAllDefault(0, -1).ToList();
                var aux2 = new List<UsuarioEN>();
                foreach(UsuarioEN element in aux){
                    if (!Roles.IsUserInRole("admin"))
                    {
                        aux2.Add(element);
                    }
                }
                SessionClose();

                return View(aux2);
            }
            return RedirectToAction("Index","Home");

        }
        public ActionResult Index2()
        {
            if (Roles.IsUserInRole("usuario"))
            {
                SessionInitialize();
                UsuarioCAD cad = new UsuarioCAD(session);
                var aux = cad.ReadAllDefault(0, -1).ToList();
                var aux2 = new List<UsuarioEN>();
                foreach(UsuarioEN element in aux){
                    if (Roles.IsUserInRole("admin"))
                    {
                        aux2.Add(element);
                    }
                }
                SessionClose();

                return View(aux2);
            }
            return RedirectToAction("Index","Home");

        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(int id)
        {
            Usuario usu = null;
            UsuarioEN usuEN;
            SessionInitialize();
            if (id <= 0)
            {
                usuEN = new UsuarioCAD(session).FiltrarUsuarioPorNombre(User.Identity.Name);
            }
            else
            {
                usuEN = new UsuarioCAD(session).ReadOIDDefault(id);
            }
            usu = new AssemblerUsuario().ConvertENToModelUI(usuEN); 

            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            SessionClose();
            return View(usu);
            
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            if (Roles.IsUserInRole("admin"))
            {
                Usuario usu = new Usuario();
            
                return View(usu);
            }
            return RedirectToAction("Index","Home");
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        public ActionResult Create(Usuario model, HttpPostedFileBase file)
        {
            WebSecurity.CreateUserAndAccount(model.Nombre, model.Contrasena);
            if (!Roles.RoleExists("usuario"))
            {
                Roles.CreateRole("usuario");
            }
            if (!Roles.RoleExists("admin"))
            {
                Roles.CreateRole("admin");
            }
            if (ModelState.IsValid)
            {

                string fileName = "", path = "";
                if (file != null && file.ContentLength > 0)
                {
                    fileName = Path.GetFileName(file.FileName);
                    path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                    file.SaveAs(path);
                }

                try
                {
                    UsuarioCEN usu = new UsuarioCEN();
                    UsuarioEN usuen = new UsuarioEN();
                    usuen.Contrasena = model.Contrasena;
                    usuen.Edad = model.Edad;
                    usuen.Email = model.Email;
                    if (model.Facebook == null) model.Facebook = ""; 
                    fileName = "/Images/Uploads/" + fileName;
                    usuen.Foto = fileName;
                    if (model.Instagram == null) model.Instagram = ""; 
                    usuen.Nombre = model.Nombre;
                    usuen.Sexo = model.sexo;
                    if (model.Twitter == null) model.Twitter = "";

                    usu.Registro(usuen);
                    Roles.AddUserToRole(model.Nombre, "usuario");
                    WebSecurity.Login(model.Nombre, model.Contrasena);


                    return RedirectToAction("Index");
                }
                catch 
                {
                    return View();
                }
            }

            // Si llegamos a este punto, es que se ha producido un error y volvemos a mostrar el formulario
            return View(model);
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(int id)
        {
            Usuario usu = null;
            SessionInitialize();
            UsuarioEN usuen = new UsuarioCAD(session).ReadOIDDefault(id);
            usu = new AssemblerUsuario().ConvertENToModelUI(usuen);

            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            SessionClose();
            return View(usu);
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        public ActionResult Edit(Usuario usu, HttpPostedFileBase file)
        {
            
                string fileName = "", path = "";
            // Verify that the user selected a file
                if (file != null && file.ContentLength > 0)
                {
                // extract only the fielname
                fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file.SaveAs(path);
            }
            try
            {
                UsuarioCEN cen = new UsuarioCEN();
                fileName = "/Images/Uploads/" + fileName;
                if (usu.Foto != fileName && fileName != "/Images/Uploads/")
                {
                    usu.Foto = fileName;
                }
                cen.Modify(usu.id, usu.Nombre, usu.Edad, usu.sexo, usu.Facebook, usu.Instagram, usu.Twitter, usu.Contrasena, usu.Email, usu.Foto);
                return RedirectToAction("Details", new { id = usu.id });
            }
                catch
                {
                    return View();
                }
            }
            
        

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            UsuarioCAD usuCAD = new UsuarioCAD(session);
            UsuarioCEN cen = new UsuarioCEN(usuCAD);
            UsuarioEN usuEN = cen.GetID(id);
            Usuario usu = new AssemblerUsuario().ConvertENToModelUI(usuEN);
            SessionClose();

            if (User.Identity.Name == usuEN.Nombre || Roles.IsUserInRole("admin")) {
                return View(usu);
            }
            return RedirectToAction("Index", "Home");

        }

        //
        // POST: /Usuario/Delete/5

        [HttpPost]
        public ActionResult Delete(Usuario usu)
        {
            try
            {
                new UsuarioCP().BorrarUsuario(usu.id);
                Membership.DeleteUser(User.Identity.Name);
                WebSecurity.Logout();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
