
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Reporte_Reportar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class ReporteCEN
{
public void Reportar (int id_usuario, int id_gym, int id_reto, string motivo)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Reporte_Reportar) ENABLED START*/

        // Write here your custom code...

        ReporteEN repor = new ReporteEN ();
        ReporteCEN reporcen = new ReporteCEN ();
        AdminCEN admincen = new AdminCEN ();

        System.Collections.Generic.IList<AdminEN> admin = null;
        System.Collections.Generic.IList<int> numadmins = null;
        System.Collections.Generic.IList<ReporteEN> listareporte;
        listareporte = reporcen.GetAll (0, 0);
        int aux = 0;

        foreach (AdminEN element in admin) {
                numadmins.Add (element.ID);
        }
        aux = listareporte [listareporte.Count - 1].ID;

        admin = admincen.GetAll (0, 0);

        reporcen.New_ (motivo, aux + 1, id_usuario, numadmins, id_reto, id_gym);

        /*PROTECTED REGION END*/
}
}
}
