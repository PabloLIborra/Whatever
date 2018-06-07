
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Mapa_filtrarMapa) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class MapaCEN
{
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> FiltrarMapa (string latitud, string longitud, int radio)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Mapa_filtrarMapa) ENABLED START*/

        // Write here your custom code...
        System.Collections.Generic.IList<MapaEN> listaM = this.GetAll (0, 0);
        System.Collections.Generic.IList<MapaEN> listaMDentro = null;

        foreach (MapaEN map in listaM) {
                if (map.Evento.ID != 0) {
                        double lati = double.Parse(latitud);
                        double longi = double.Parse(longitud);
                        double lat = double.Parse(map.Latitud);
                        double lon = double.Parse(map.Longitud);

                        double EarthRadius = 6371;

                        double distance = 0;
                        double Lat = (lat - lati) * (Math.PI / 180);
                        double Lon = (lon - longi) * (Math.PI / 180);
                        double a = Math.Sin (Lat / 2) * Math.Sin (Lat / 2) + Math.Cos (lati * (Math.PI / 180)) * Math.Cos (lat * (Math.PI / 180)) * Math.Sin (Lon / 2) * Math.Sin (Lon / 2);
                        double c = 2 * Math.Atan2 (Math.Sqrt (a), Math.Sqrt (1 - a));
                        distance = EarthRadius * c;


                        if (distance < radio)
                                listaMDentro.Add (map);
                }
        }
        return listaMDentro;

        /*PROTECTED REGION END*/
}
}
}
