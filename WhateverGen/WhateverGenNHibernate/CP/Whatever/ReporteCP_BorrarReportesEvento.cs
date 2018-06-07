
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Reporte_BorrarReportesEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class ReporteCP : BasicCP
{
public void BorrarReportesEvento (int id_evento)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Reporte_BorrarReportesEvento) ENABLED START*/

        IReporteCAD reporteCAD = null;
        ReporteCEN reporteCEN = null;



        try
        {
                SessionInitializeTransaction ();
                reporteCAD = new ReporteCAD (session);
                reporteCEN = new  ReporteCEN (reporteCAD);



                // Write here your custom transaction ...
                System.Collections.Generic.IList<ReporteEN> reportes = new System.Collections.Generic.List<ReporteEN>();
                reportes = reporteCAD.FiltrarReportesPorEvento (id_evento);
                foreach (ReporteEN element in reportes) {
                        reporteCAD.UnrelationerReporteEvento (element.ID, id_evento);
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
