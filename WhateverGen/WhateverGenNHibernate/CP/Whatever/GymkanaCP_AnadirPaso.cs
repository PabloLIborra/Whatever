
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Gymkana_anadirPaso) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class GymkanaCP : BasicCP
{
public void AnadirPaso (WhateverGenNHibernate.EN.Whatever.PasoEN paso, WhateverGenNHibernate.EN.Whatever.MapaEN mapa, WhateverGenNHibernate.EN.Whatever.GymkanaEN gym)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Gymkana_anadirPaso) ENABLED START*/

        IGymkanaCAD gymkanaCAD = null;
        GymkanaCEN gymkanaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                gymkanaCAD = new GymkanaCAD (session);
                gymkanaCEN = new  GymkanaCEN (gymkanaCAD);


                PasoCAD paso2 = new PasoCAD (session);
                MapaCP mapa2 = new MapaCP (session);
                paso.Gymkana = gym;
                int id_paso = paso2.New_ (paso);
                mapa2.CrearMapaParaPaso (id_paso, mapa.Latitud, mapa.Longitud, mapa.Zoom);
                gym.NumPasos = gym.NumPasos + 1;

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
