
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Admin_borrarEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class AdminCEN
{
public void BorrarEvento (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Admin_borrarEvento) ENABLED START*/

        // Write here your custom code...
        EventoCEN evento = new EventoCEN ();
        MapaCEN mapa = new MapaCEN ();

        System.Collections.Generic.IList<MapaEN> aux;
        aux = mapa.FiltrarPorEvento(p_oid);
        int id_mapa = -1;

        foreach (MapaEN element in aux) {
                        id_mapa = element.Id;
                        mapa.Destroy (id_mapa);
        }


        evento.Destroy (p_oid);
        /*PROTECTED REGION END*/
}
}
}
