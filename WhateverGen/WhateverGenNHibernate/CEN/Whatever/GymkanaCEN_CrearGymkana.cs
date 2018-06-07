
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Gymkana_crearGymkana) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class GymkanaCEN
{
public void CrearGymkana (WhateverGenNHibernate.EN.Whatever.GymkanaEN gym, double lat, double lon, int zoom)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Gymkana_crearGymkana) ENABLED START*/

        GymkanaCAD gymk = new GymkanaCAD ();
        MapaCAD mapa = new MapaCAD ();
        MapaEN map = new MapaEN ();

        map.Latitud = lat;
        map.Longitud = lon;
        map.Zoom = zoom;
        map.Evento_mapa2 = gym;

        gymk.New_ (gym);
        mapa.New_ (map);

        /*PROTECTED REGION END*/
}
}
}
