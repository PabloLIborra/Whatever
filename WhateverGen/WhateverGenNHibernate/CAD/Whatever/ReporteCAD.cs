
using System;
using System.Text;
using WhateverGenNHibernate.CEN.Whatever;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.Exceptions;


/*
 * Clase Reporte:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class ReporteCAD : BasicCAD, IReporteCAD
{
public ReporteCAD() : base ()
{
}

public ReporteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ReporteEN ReadOIDDefault (int ID
                                 )
{
        ReporteEN reporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Get (typeof(ReporteEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteEN;
}

public System.Collections.Generic.IList<ReporteEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReporteEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReporteEN>();
                        else
                                result = session.CreateCriteria (typeof(ReporteEN)).List<ReporteEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();
                ReporteEN reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), reporte.ID);

                reporteEN.Motivo = reporte.Motivo;





                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ReporteEN reporte)
{
        try
        {
                SessionInitializeTransaction ();
                if (reporte.Usuario != null) {
                        // Argumento OID y no colección.
                        reporte.Usuario = (WhateverGenNHibernate.EN.Whatever.UsuarioEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.UsuarioEN), reporte.Usuario.ID);

                        reporte.Usuario.Reporte
                        .Add (reporte);
                }

                session.Save (reporte);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporte.ID;
}

public void Destroy (int ID
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ReporteEN reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), ID);
                session.Delete (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ReporteEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ReporteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ReporteEN>();
                else
                        result = session.CreateCriteria (typeof(ReporteEN)).List<ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetID
//Con e: ReporteEN
public ReporteEN GetID (int ID
                        )
{
        ReporteEN reporteEN = null;

        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Get (typeof(ReporteEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reporteEN;
}

public WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorEventoYUsuario (int? id_evento, int ? id_usuario)
{
        WhateverGenNHibernate.EN.Whatever.ReporteEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN as rep WHERE rep.Evento.ID=:id_evento and rep.Usuario.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarReportePorEventoYUsuarioHQL");
                query.SetParameter ("id_evento", id_evento);
                query.SetParameter ("id_usuario", id_usuario);


                result = query.UniqueResult<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorRetoYUsuario (int? id_reto, int ? id_usuario)
{
        WhateverGenNHibernate.EN.Whatever.ReporteEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN as rep WHERE rep.Reto.ID=:id_reto and rep.Usuario.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarReportePorRetoYUsuarioHQL");
                query.SetParameter ("id_reto", id_reto);
                query.SetParameter ("id_usuario", id_usuario);


                result = query.UniqueResult<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorEvento (int ? id_evento)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN as rep WHERE rep.Evento.ID=:id_evento";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarReportesPorEventoHQL");
                query.SetParameter ("id_evento", id_evento);

                result = query.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorReto (int ? id_reto)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN as rep WHERE rep.Reto.ID=:id_reto";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarReportesPorRetoHQL");
                query.SetParameter ("id_reto", id_reto);

                result = query.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorUsuario (int ? id_usuario)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN as rep WHERE rep.Usuario.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarReportesPorUsuarioHQL");
                query.SetParameter ("id_usuario", id_usuario);

                result = query.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void RelationerReporteReto (int p_Reporte_OID, int p_reto_OID)
{
        WhateverGenNHibernate.EN.Whatever.ReporteEN reporteEN = null;
        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), p_Reporte_OID);
                reporteEN.Reto = (WhateverGenNHibernate.EN.Whatever.RetoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.RetoEN), p_reto_OID);

                reporteEN.Reto.Reporte.Add (reporteEN);



                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelationerReporteEvento (int p_Reporte_OID, int p_evento_OID)
{
        WhateverGenNHibernate.EN.Whatever.ReporteEN reporteEN = null;
        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), p_Reporte_OID);
                reporteEN.Evento = (WhateverGenNHibernate.EN.Whatever.EventoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.EventoEN), p_evento_OID);

                reporteEN.Evento.Reporte.Add (reporteEN);



                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnrelationerReporteReto (int p_Reporte_OID, int p_reto_OID)
{
        try
        {
                SessionInitializeTransaction ();
                WhateverGenNHibernate.EN.Whatever.ReporteEN reporteEN = null;
                reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), p_Reporte_OID);

                if (reporteEN.Reto.ID == p_reto_OID) {
                        reporteEN.Reto = null;
                }
                else
                        throw new ModelException ("The identifier " + p_reto_OID + " in p_reto_OID you are trying to unrelationer, doesn't exist in ReporteEN");

                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void UnrelationerReporteEvento (int p_Reporte_OID, int p_evento_OID)
{
        try
        {
                SessionInitializeTransaction ();
                WhateverGenNHibernate.EN.Whatever.ReporteEN reporteEN = null;
                reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), p_Reporte_OID);

                if (reporteEN.Evento.ID == p_evento_OID) {
                        reporteEN.Evento = null;
                }
                else
                        throw new ModelException ("The identifier " + p_evento_OID + " in p_evento_OID you are trying to unrelationer, doesn't exist in ReporteEN");

                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public WhateverGenNHibernate.EN.Whatever.ReporteEN FiltrarReportePorGymkanaYUsuario (int? id_gym, int ? id_usuario)
{
        WhateverGenNHibernate.EN.Whatever.ReporteEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN as rep WHERE rep.Gymkana.ID=:id_gym and rep.Usuario.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarReportePorGymkanaYUsuarioHQL");
                query.SetParameter ("id_gym", id_gym);
                query.SetParameter ("id_usuario", id_usuario);


                result = query.UniqueResult<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> FiltrarReportesPorGymkana (int ? id_gym)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ReporteEN self where FROM ReporteEN as rep WHERE rep.Gymkana.ID=:id_gym";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ReporteENfiltrarReportesPorGymkanaHQL");
                query.SetParameter ("id_gym", id_gym);

                result = query.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void RelationerReporteGymkana (int p_Reporte_OID, int p_gymkana_OID)
{
        WhateverGenNHibernate.EN.Whatever.ReporteEN reporteEN = null;
        try
        {
                SessionInitializeTransaction ();
                reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), p_Reporte_OID);
                reporteEN.Gymkana = (WhateverGenNHibernate.EN.Whatever.GymkanaEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.GymkanaEN), p_gymkana_OID);

                reporteEN.Gymkana.Reporte.Add (reporteEN);



                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnrelationerReporteGymkana (int p_Reporte_OID, int p_gymkana_OID)
{
        try
        {
                SessionInitializeTransaction ();
                WhateverGenNHibernate.EN.Whatever.ReporteEN reporteEN = null;
                reporteEN = (ReporteEN)session.Load (typeof(ReporteEN), p_Reporte_OID);

                if (reporteEN.Gymkana.ID == p_gymkana_OID) {
                        reporteEN.Gymkana = null;
                }
                else
                        throw new ModelException ("The identifier " + p_gymkana_OID + " in p_gymkana_OID you are trying to unrelationer, doesn't exist in ReporteEN");

                session.Update (reporteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in ReporteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
