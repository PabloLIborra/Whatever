
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
 * Clase Puntuacion:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class PuntuacionCAD : BasicCAD, IPuntuacionCAD
{
public PuntuacionCAD() : base ()
{
}

public PuntuacionCAD(ISession sessionAux) : base (sessionAux)
{
}



public PuntuacionEN ReadOIDDefault (int id
                                    )
{
        PuntuacionEN puntuacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                puntuacionEN = (PuntuacionEN)session.Get (typeof(PuntuacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuacionEN;
}

public System.Collections.Generic.IList<PuntuacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PuntuacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PuntuacionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PuntuacionEN>();
                        else
                                result = session.CreateCriteria (typeof(PuntuacionEN)).List<PuntuacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PuntuacionEN puntuacion)
{
        try
        {
                SessionInitializeTransaction ();
                PuntuacionEN puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), puntuacion.Id);




                puntuacionEN.Puntuacion = puntuacion.Puntuacion;


                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PuntuacionEN puntuacion)
{
        try
        {
                SessionInitializeTransaction ();
                if (puntuacion.Usuario != null) {
                        // Argumento OID y no colección.
                        puntuacion.Usuario = (WhateverGenNHibernate.EN.Whatever.UsuarioEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.UsuarioEN), puntuacion.Usuario.ID);

                        puntuacion.Usuario.Puntuacion
                        .Add (puntuacion);
                }

                session.Save (puntuacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuacion.Id;
}

public System.Collections.Generic.IList<PuntuacionEN> GetPuntuaciones (int first, int size)
{
        System.Collections.Generic.IList<PuntuacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PuntuacionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PuntuacionEN>();
                else
                        result = session.CreateCriteria (typeof(PuntuacionEN)).List<PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetID
//Con e: PuntuacionEN
public PuntuacionEN GetID (int id
                           )
{
        PuntuacionEN puntuacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                puntuacionEN = (PuntuacionEN)session.Get (typeof(PuntuacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuacionEN;
}

public WhateverGenNHibernate.EN.Whatever.PuntuacionEN FiltrarPuntuacionPorUsuarioYReto (int? id_reto, int ? id_usuario)
{
        WhateverGenNHibernate.EN.Whatever.PuntuacionEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN as pun WHERE pun.Reto.ID=:id_reto and pun.Usuario.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarPuntuacionPorUsuarioYRetoHQL");
                query.SetParameter ("id_reto", id_reto);
                query.SetParameter ("id_usuario", id_usuario);


                result = query.UniqueResult<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public WhateverGenNHibernate.EN.Whatever.PuntuacionEN FiltrarPuntuacionPorEventoYUsuario (int? id_evento, int ? id_usuario)
{
        WhateverGenNHibernate.EN.Whatever.PuntuacionEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN as pun WHERE pun.Evento.ID=:id_evento and pun.Usuario.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarPuntuacionPorEventoYUsuarioHQL");
                query.SetParameter ("id_evento", id_evento);
                query.SetParameter ("id_usuario", id_usuario);


                result = query.UniqueResult<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void Modify (PuntuacionEN puntuacion)
{
        try
        {
                SessionInitializeTransaction ();
                PuntuacionEN puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), puntuacion.Id);

                puntuacionEN.Puntuacion = puntuacion.Puntuacion;

                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                PuntuacionEN puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), id);
                session.Delete (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarPuntuacionPorEvento (int ? id_evento)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN as pun WHERE pun.Evento.ID=:id_evento";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarPuntuacionPorEventoHQL");
                query.SetParameter ("id_evento", id_evento);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarPuntuacionPorReto (int ? id_reto)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN as pun WHERE pun.Reto.ID=:id_reto";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarPuntuacionPorRetoHQL");
                query.SetParameter ("id_reto", id_reto);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void RelationerPuntuacionEvento (int p_Puntuacion_OID, int p_evento_OID)
{
        WhateverGenNHibernate.EN.Whatever.PuntuacionEN puntuacionEN = null;
        try
        {
                SessionInitializeTransaction ();
                puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), p_Puntuacion_OID);
                puntuacionEN.Evento = (WhateverGenNHibernate.EN.Whatever.EventoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.EventoEN), p_evento_OID);

                puntuacionEN.Evento.Puntuacion.Add (puntuacionEN);



                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelationerPuntuacionReto (int p_Puntuacion_OID, int p_reto_OID)
{
        WhateverGenNHibernate.EN.Whatever.PuntuacionEN puntuacionEN = null;
        try
        {
                SessionInitializeTransaction ();
                puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), p_Puntuacion_OID);
                puntuacionEN.Reto = (WhateverGenNHibernate.EN.Whatever.RetoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.RetoEN), p_reto_OID);

                puntuacionEN.Reto.Puntuacion.Add (puntuacionEN);



                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnrelationerPuntuacionEvento (int p_Puntuacion_OID, int p_evento_OID)
{
        try
        {
                SessionInitializeTransaction ();
                WhateverGenNHibernate.EN.Whatever.PuntuacionEN puntuacionEN = null;
                puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), p_Puntuacion_OID);

                if (puntuacionEN.Evento.ID == p_evento_OID) {
                        puntuacionEN.Evento = null;
                }
                else
                        throw new ModelException ("The identifier " + p_evento_OID + " in p_evento_OID you are trying to unrelationer, doesn't exist in PuntuacionEN");

                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void UnrelationerPuntuacionReto (int p_Puntuacion_OID, int p_reto_OID)
{
        try
        {
                SessionInitializeTransaction ();
                WhateverGenNHibernate.EN.Whatever.PuntuacionEN puntuacionEN = null;
                puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), p_Puntuacion_OID);

                if (puntuacionEN.Reto.ID == p_reto_OID) {
                        puntuacionEN.Reto = null;
                }
                else
                        throw new ModelException ("The identifier " + p_reto_OID + " in p_reto_OID you are trying to unrelationer, doesn't exist in PuntuacionEN");

                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarComentarioPorUsuario (int ? id_usuario)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN as pun WHERE pun.Usuario.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarComentarioPorUsuarioHQL");
                query.SetParameter ("id_usuario", id_usuario);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public WhateverGenNHibernate.EN.Whatever.PuntuacionEN FiltrarPuntuacionPorUsuarioYGymkana (int? id_gym, int ? id_usuario)
{
        WhateverGenNHibernate.EN.Whatever.PuntuacionEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN as pun WHERE pun.Gymkana.ID=:id_gym and pun.Usuario.ID=:id_usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarPuntuacionPorUsuarioYGymkanaHQL");
                query.SetParameter ("id_gym", id_gym);
                query.SetParameter ("id_usuario", id_usuario);


                result = query.UniqueResult<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarPuntuacionPorGymkana (int ? id_gym)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PuntuacionEN self where FROM PuntuacionEN as pun WHERE pun.Gymkana.ID=:id_gym";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PuntuacionENfiltrarPuntuacionPorGymkanaHQL");
                query.SetParameter ("id_gym", id_gym);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void RelationerPuntuacionGymkana (int p_Puntuacion_OID, int p_gymkana_OID)
{
        WhateverGenNHibernate.EN.Whatever.PuntuacionEN puntuacionEN = null;
        try
        {
                SessionInitializeTransaction ();
                puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), p_Puntuacion_OID);
                puntuacionEN.Gymkana = (WhateverGenNHibernate.EN.Whatever.GymkanaEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.GymkanaEN), p_gymkana_OID);

                puntuacionEN.Gymkana.Puntuacion.Add (puntuacionEN);



                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnrelationerPuntuacionGymkana (int p_Puntuacion_OID, int p_gymkana_OID)
{
        try
        {
                SessionInitializeTransaction ();
                WhateverGenNHibernate.EN.Whatever.PuntuacionEN puntuacionEN = null;
                puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), p_Puntuacion_OID);

                if (puntuacionEN.Gymkana.ID == p_gymkana_OID) {
                        puntuacionEN.Gymkana = null;
                }
                else
                        throw new ModelException ("The identifier " + p_gymkana_OID + " in p_gymkana_OID you are trying to unrelationer, doesn't exist in PuntuacionEN");

                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
