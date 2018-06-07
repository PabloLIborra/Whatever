
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Admin_borrarRetos) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class AdminCP : BasicCP
{
public void BorrarRetos (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Admin_borrarRetos) ENABLED START*/

        IAdminCAD adminCAD = null;
        AdminCEN adminCEN = null;



        try
        {
                SessionInitializeTransaction ();
                adminCAD = new AdminCAD (session);
                adminCEN = new  AdminCEN (adminCAD);


                RetoCAD reto = new RetoCAD (session);
                reto.Destroy (p_oid);


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
