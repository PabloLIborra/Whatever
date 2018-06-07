
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Paso_borrarPaso) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class PasoCP : BasicCP
{
public void BorrarPaso (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Paso_borrarPaso) ENABLED START*/

        IPasoCAD pasoCAD = null;
        PasoCEN pasoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                pasoCAD = new PasoCAD (session);
                pasoCEN = new  PasoCEN (pasoCAD);

                MapaCP mapa = new MapaCP (session);

                mapa.BorrarMapaParaPaso (p_oid);
                pasoCAD.Destroy (p_oid);



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
