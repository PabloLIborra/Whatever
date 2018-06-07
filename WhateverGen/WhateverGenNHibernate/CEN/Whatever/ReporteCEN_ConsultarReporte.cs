
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Reporte_consultarReporte) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class ReporteCEN
{
public string ConsultarReporte (int id_usuario, int id_reto, int id_gym, int id_evento)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Reporte_consultarReporte) ENABLED START*/

        // Write here your custom code...
        if (id_gym != -1 && id_reto == -1 && id_evento == -1) {
                ReporteCEN report = new ReporteCEN ();
                ReporteEN reporen = new ReporteEN ();
                reporen = FiltrarReportePorGymkanaYUsuario (id_gym, id_usuario);
                return reporen.Motivo;
        }
        else if (id_gym == -1 && id_reto != -1 && id_evento == -1) {
                ReporteCEN report = new ReporteCEN ();
                ReporteEN reporen = new ReporteEN ();
                reporen = FiltrarReportePorRetoYUsuario (id_reto, id_usuario);
                return reporen.Motivo;
        }
        else if (id_gym == -1 && id_reto == -1 && id_evento != -1) {
                ReporteCEN report = new ReporteCEN ();
                ReporteEN reporen = new ReporteEN ();
                reporen = FiltrarReportePorEventoYUsuario (id_gym, id_usuario);
                return reporen.Motivo;
        }
        return null;
        /*PROTECTED REGION END*/
}
}
}
