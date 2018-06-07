
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Gymkana_borrarGymkana) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class GymkanaCP : BasicCP
{
public void BorrarGymkana (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Gymkana_borrarGymkana) ENABLED START*/

        IGymkanaCAD gymkanaCAD = null;
        GymkanaCEN gymkanaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                gymkanaCAD = new GymkanaCAD (session);
                gymkanaCEN = new  GymkanaCEN (gymkanaCAD);

                System.Collections.Generic.IList<PasoEN> pasos;
                PasoCAD paso = new PasoCAD (session);
                MapaCP mapa = new MapaCP (session);
                PuntuacionCP punt = new PuntuacionCP (session);
                ReporteCP rep = new ReporteCP (session);
                ComentarioCP com = new ComentarioCP (session);

                punt.BorrarPuntuacionGymkana (p_oid);
                rep.BorrarReportesGymkana (p_oid);
                com.BorrarComentariosGymkana (p_oid);

                pasos = paso.FiltrarPasoPorGymkana (p_oid);
                foreach (PasoEN element in pasos) {
                        mapa.BorrarMapaParaPaso (element.ID);
                        paso.Destroy (element.ID);
                }

                gymkanaCAD.Destroy (p_oid);

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
