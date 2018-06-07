
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Reto_borrarReto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class RetoCEN
{
public void BorrarReto (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Reto_borrarReto) ENABLED START*/
        PuntuacionCAD punt = new PuntuacionCAD ();
        ReporteCAD rep = new ReporteCAD ();

        System.Collections.Generic.IList<PuntuacionEN> puntos;
        System.Collections.Generic.IList<ReporteEN> reportes;

        Destroy (p_oid);

        puntos = punt.FiltrarTodosRetos (p_oid);
        foreach (PuntuacionEN element in puntos) {
                punt.Destroy (element.Id);
        }

        reportes = rep.FiltrarTodosRetos (p_oid);
        foreach (ReporteEN element in reportes) {
                rep.Destroy (element.ID);
        }
        /*PROTECTED REGION END*/
}
}
}
