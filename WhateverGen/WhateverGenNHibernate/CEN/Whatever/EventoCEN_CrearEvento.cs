
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Evento_crearEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class EventoCEN
{
public void CrearEvento (WhateverGenNHibernate.EN.Whatever.EventoEN evento, double lat, double long_, int zoom)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Evento_crearEvento) ENABLED START*/

        // Write here your custom code...

        EventoCAD eve = new EventoCAD ();
        MapaCAD mapa = new MapaCAD ();
        MapaEN map = new MapaEN ();

        eve.New_ (evento);
        map.Latitud = lat;
        map.Longitud = long_;
        map.Zoom = zoom;
        map.Evento_mapa2 = evento;


        mapa.New_ (map);
        /*PROTECTED REGION END*/
}
}
}
