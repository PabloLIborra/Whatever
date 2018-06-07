
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Usuario_deshacerAdmin) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class UsuarioCP : BasicCP
{
public bool DeshacerAdmin (string nombre)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Usuario_deshacerAdmin) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;



        try
        {
            SessionInitializeTransaction();
            usuarioCAD = new UsuarioCAD(session);
            usuarioCEN = new UsuarioCEN(usuarioCAD);

            UsuarioEN usuen = usuarioCAD.FiltrarUsuarioPorNombre(nombre);
            int id_admin = usuen.Admin.ID;
            AdminCEN adminCEN = new AdminCEN();
            adminCEN.Destroy(id_admin);
            SessionCommit();
            return true;
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
