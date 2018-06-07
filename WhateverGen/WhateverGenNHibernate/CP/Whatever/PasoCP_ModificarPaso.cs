
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Paso_modificarPaso) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class PasoCP : BasicCP
{
public void ModificarPaso (WhateverGenNHibernate.EN.Whatever.PasoEN paso, WhateverGenNHibernate.EN.Whatever.MapaEN mapa)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Paso_modificarPaso) ENABLED START*/

        IPasoCAD pasoCAD = null;
        PasoCEN pasoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                pasoCAD = new PasoCAD (session);
                pasoCEN = new  PasoCEN (pasoCAD);


                MapaCAD map = new MapaCAD (session);


                pasoCAD.Modify (paso);
                map.Modify (mapa);

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
