
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Paso_borrarPaso) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class PasoCEN
{
public void BorrarPaso (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Paso_borrarPaso) ENABLED START*/


        PasoEN paso = new PasoEN ();
        MapaCAD mapa = new MapaCAD ();

        System.Collections.Generic.IList<MapaEN> mapas;
        paso = GetID (p_oid);
        Destroy (p_oid);
        mapas = mapa.FiltrarPorPaso (p_oid);
        mapa.Destroy (mapas [0].Id);

        /*PROTECTED REGION END*/
}
}
}
