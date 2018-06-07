
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IReporteCAD
{
ReporteEN ReadOIDDefault (int ID
                          );

void ModifyDefault (ReporteEN reporte);




int New_ (ReporteEN reporte);

void Destroy (int ID
              );


System.Collections.Generic.IList<ReporteEN> GetAll (int first, int size);


ReporteEN GetID (int ID
                 );


WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorEventoYUsuario (int? id_evento, int ? id_usuario);


WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorRetoYUsuario (int? id_reto, int ? id_usuario);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorEvento (int ? id_evento);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorReto (int ? id_reto);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorUsuario (int ? id_usuario);




void RelationerReporteReto (int p_Reporte_OID, int p_reto_OID);

void RelationerReporteEvento (int p_Reporte_OID, int p_evento_OID);



void UnrelationerReporteReto (int p_Reporte_OID, int p_reto_OID);

void UnrelationerReporteEvento (int p_Reporte_OID, int p_evento_OID);


WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorGymkanaYUsuario (int? id_gym, int ? id_usuario);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorGymkana (int ? id_gym);



void RelationerReporteGymkana (int p_Reporte_OID, int p_gymkana_OID);


void UnrelationerReporteGymkana (int p_Reporte_OID, int p_gymkana_OID);
}
}
