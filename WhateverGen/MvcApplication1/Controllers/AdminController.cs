using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Controllers
{
    [Authorize(Roles = "usuario")]

    public class AdminController : BasicController
    {
        //
        // GET: /Admin/

        public ActionResult UpGrade(string Name)
        {
                SessionInitialize();

                Roles.AddUserToRole(Name, "admin");

                SessionClose();

                return RedirectToAction("Index","Usuario");
            
        }

        // GET: /Admin/Create

        public ActionResult DownGrade(string Name)
        {
            Roles.RemoveUserFromRole(Name, "admin");

            SessionClose();

            return RedirectToAction("Index", "Usuario");
        }
        
       
    }
}
