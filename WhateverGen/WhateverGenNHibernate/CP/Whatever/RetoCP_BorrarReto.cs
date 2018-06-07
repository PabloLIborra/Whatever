
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Reto_borrarReto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class RetoCP : BasicCP
{
public void BorrarReto (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Reto_borrarReto) ENABLED START*/

        IRetoCAD retoCAD = null;
        RetoCEN retoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                retoCAD = new RetoCAD (session);
                retoCEN = new  RetoCEN (retoCAD);


                PuntuacionCP punt = new PuntuacionCP (session);
                ReporteCP rep = new ReporteCP (session);
                ComentarioCP com = new ComentarioCP (session);

                punt.BorrarPuntuacionReto (p_oid);
                rep.BorrarReportesReto (p_oid);
                com.BorrarComentariosReto (p_oid);

                retoCAD.Destroy (p_oid);




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
