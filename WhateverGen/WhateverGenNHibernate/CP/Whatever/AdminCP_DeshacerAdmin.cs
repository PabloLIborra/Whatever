
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Admin_deshacerAdmin) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class AdminCP : BasicCP
{
public void DeshacerAdmin (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Admin_deshacerAdmin) ENABLED START*/

        IAdminCAD adminCAD = null;
        AdminCEN adminCEN = null;



        try
        {
                SessionInitializeTransaction ();
                adminCAD = new AdminCAD (session);
                adminCEN = new  AdminCEN (adminCAD);

                UsuarioCAD usucad = new UsuarioCAD (session);
                UsuarioEN usuen = new UsuarioEN ();
                AdminEN admin = new AdminEN ();
                admin = adminCAD.GetID (p_oid);
                adminCAD.Destroy (p_oid);
                usuen.Contrasena = admin.Contrasena;
                usuen.Edad = admin.Edad;
                usuen.Email = admin.Email;
                usuen.Facebook = admin.Facebook;
                usuen.Foto = admin.Foto;
                usuen.Twitter = admin.Twitter;
                usuen.ID = admin.ID;
                usuen.Instagram = admin.Instagram;
                usuen.Nombre = admin.Nombre;
                usuen.Sexo = admin.Sexo;

                usucad.New_ (usuen);



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
