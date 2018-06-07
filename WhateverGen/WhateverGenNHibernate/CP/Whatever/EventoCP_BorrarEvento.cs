
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Evento_borrarEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class EventoCP : BasicCP
{
public void BorrarEvento (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Evento_borrarEvento) ENABLED START*/

        IEventoCAD eventoCAD = null;
        EventoCEN eventoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                eventoCAD = new EventoCAD (session);
                eventoCEN = new  EventoCEN (eventoCAD);

                MapaCP mapa = new MapaCP (session);
                PuntuacionCP punt = new PuntuacionCP (session);
                ReporteCP rep = new ReporteCP (session);
                ComentarioCP com = new ComentarioCP (session);

                mapa.BorrarMapaParaEvento (p_oid);
                punt.BorrarPuntuacionEvento (p_oid);
                rep.BorrarReportesEvento (p_oid);
                com.BorrarComentariosEvento (p_oid);

                eventoCAD.Destroy (p_oid);



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
