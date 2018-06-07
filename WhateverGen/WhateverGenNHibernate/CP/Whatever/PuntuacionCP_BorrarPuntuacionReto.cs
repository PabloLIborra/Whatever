
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Puntuacion_borrarPuntuacionReto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class PuntuacionCP : BasicCP
{
public void BorrarPuntuacionReto (int id_reto)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Puntuacion_borrarPuntuacionReto) ENABLED START*/

        IPuntuacionCAD puntuacionCAD = null;
        PuntuacionCEN puntuacionCEN = null;



        try
        {
                SessionInitializeTransaction ();
                puntuacionCAD = new PuntuacionCAD (session);
                puntuacionCEN = new  PuntuacionCEN (puntuacionCAD);



                // Write here your custom transaction ...

                System.Collections.Generic.IList<PuntuacionEN> puntuaciones = new System.Collections.Generic.List<PuntuacionEN>();
                puntuaciones = puntuacionCAD.FiltrarPuntuacionPorReto (id_reto);
                foreach (PuntuacionEN element in puntuaciones) {
                        puntuacionCAD.UnrelationerPuntuacionReto (element.Id, id_reto);
                        puntuacionCAD.Destroy (element.Id);
                }

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
