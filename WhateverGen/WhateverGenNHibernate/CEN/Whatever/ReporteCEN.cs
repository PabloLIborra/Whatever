

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.Exceptions;

using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;


namespace WhateverGenNHibernate.CEN.Whatever
{
/*
 *      Definition of the class ReporteCEN
 *
 */
public partial class ReporteCEN
{
private IReporteCAD _IReporteCAD;

public ReporteCEN()
{
        this._IReporteCAD = new ReporteCAD ();
}

public ReporteCEN(IReporteCAD _IReporteCAD)
{
        this._IReporteCAD = _IReporteCAD;
}

public IReporteCAD get_IReporteCAD ()
{
        return this._IReporteCAD;
}

public int New_ (string p_motivo, int p_usuario)
{
        ReporteEN reporteEN = null;
        int oid;

        //Initialized ReporteEN
        reporteEN = new ReporteEN ();
        reporteEN.Motivo = p_motivo;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids ID
                reporteEN.Usuario = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                reporteEN.Usuario.ID = p_usuario;
        }

        //Call to ReporteCAD

        oid = _IReporteCAD.New_ (reporteEN);
        return oid;
}

public void Destroy (int ID
                     )
{
        _IReporteCAD.Destroy (ID);
}

public System.Collections.Generic.IList<ReporteEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> list = null;

        list = _IReporteCAD.GetAll (first, size);
        return list;
}
public ReporteEN GetID (int ID
                        )
{
        ReporteEN reporteEN = null;

        reporteEN = _IReporteCAD.GetID (ID);
        return reporteEN;
}

public WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorEventoYUsuario (int? id_evento, int ? id_usuario)
{
        return _IReporteCAD.FiltrarReportePorEventoYUsuario (id_evento, id_usuario);
}
public WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorRetoYUsuario (int? id_reto, int ? id_usuario)
{
        return _IReporteCAD.FiltrarReportePorRetoYUsuario (id_reto, id_usuario);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorEvento (int ? id_evento)
{
        return _IReporteCAD.FiltrarReportesPorEvento (id_evento);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorReto (int ? id_reto)
{
        return _IReporteCAD.FiltrarReportesPorReto (id_reto);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorUsuario (int ? id_usuario)
{
        return _IReporteCAD.FiltrarReportesPorUsuario (id_usuario);
}
public void RelationerReporteReto (int p_Reporte_OID, int p_reto_OID)
{
        //Call to ReporteCAD

        _IReporteCAD.RelationerReporteReto (p_Reporte_OID, p_reto_OID);
}
public void RelationerReporteEvento (int p_Reporte_OID, int p_evento_OID)
{
        //Call to ReporteCAD

        _IReporteCAD.RelationerReporteEvento (p_Reporte_OID, p_evento_OID);
}
public void UnrelationerReporteReto (int p_Reporte_OID, int p_reto_OID)
{
        //Call to ReporteCAD

        _IReporteCAD.UnrelationerReporteReto (p_Reporte_OID, p_reto_OID);
}
public void UnrelationerReporteEvento (int p_Reporte_OID, int p_evento_OID)
{
        //Call to ReporteCAD

        _IReporteCAD.UnrelationerReporteEvento (p_Reporte_OID, p_evento_OID);
}
public WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorGymkanaYUsuario (int? id_gym, int ? id_usuario)
{
        return _IReporteCAD.FiltrarReportePorGymkanaYUsuario (id_gym, id_usuario);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorGymkana (int ? id_gym)
{
        return _IReporteCAD.FiltrarReportesPorGymkana (id_gym);
}
public void RelationerReporteGymkana (int p_Reporte_OID, int p_gymkana_OID)
{
        //Call to ReporteCAD

        _IReporteCAD.RelationerReporteGymkana (p_Reporte_OID, p_gymkana_OID);
}
public void UnrelationerReporteGymkana (int p_Reporte_OID, int p_gymkana_OID)
{
        //Call to ReporteCAD

        _IReporteCAD.UnrelationerReporteGymkana (p_Reporte_OID, p_gymkana_OID);
}
}
}
