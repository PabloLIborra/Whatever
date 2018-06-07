
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Evento_borrarEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class EventoCEN
{
public void BorrarEvento (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Evento_borrarEvento) ENABLED START*/

        // Write here your custom code...
        MapaCAD mapa = new MapaCAD ();
        PuntuacionCAD punt = new PuntuacionCAD ();
        ReporteCAD rep = new ReporteCAD ();

        System.Collections.Generic.IList<MapaEN> mapas;
        System.Collections.Generic.IList<PuntuacionEN> puntos;
        System.Collections.Generic.IList<ReporteEN> reportes;

        Destroy (p_oid);

        mapas = mapa.FiltrarPorEvento (p_oid);
        mapa.Destroy (mapas [0].Id);

        puntos = punt.FiltrarTodosEventos (p_oid);
        foreach (PuntuacionEN element in puntos) {
                punt.Destroy (element.Id);
        }

        reportes = rep.FiltrarTodosEventos (p_oid);
        foreach (ReporteEN element in reportes) {
                rep.Destroy (element.ID);
        }




        /*PROTECTED REGION END*/
}
}
}
