
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Reporte_BorrarReportesGymkana) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class ReporteCP : BasicCP
{
public void BorrarReportesGymkana (int id_gym)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Reporte_BorrarReportesGymkana) ENABLED START*/

        IReporteCAD reporteCAD = null;
        ReporteCEN reporteCEN = null;



        try
        {
                SessionInitializeTransaction ();
                reporteCAD = new ReporteCAD (session);
                reporteCEN = new  ReporteCEN (reporteCAD);



                // Write here your custom transaction ...

                System.Collections.Generic.IList<ReporteEN> reportes = new System.Collections.Generic.List<ReporteEN>();
                reportes = reporteCAD.FiltrarReportesPorGymkana (id_gym);
                foreach (ReporteEN element in reportes) {
                        reporteCAD.UnrelationerReporteGymkana (element.ID, id_gym);
                        reporteCAD.Destroy (element.ID);
                }


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
