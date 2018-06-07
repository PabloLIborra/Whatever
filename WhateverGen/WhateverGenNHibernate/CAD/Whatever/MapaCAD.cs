
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
 * Clase Mapa:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class MapaCAD : BasicCAD, IMapaCAD
{
public MapaCAD() : base ()
{
}

public MapaCAD(ISession sessionAux) : base (sessionAux)
{
}



public MapaEN ReadOIDDefault (int id
                              )
{
        MapaEN mapaEN = null;

        try
        {
                SessionInitializeTransaction ();
                mapaEN = (MapaEN)session.Get (typeof(MapaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mapaEN;
}

public System.Collections.Generic.IList<MapaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MapaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MapaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MapaEN>();
                        else
                                result = session.CreateCriteria (typeof(MapaEN)).List<MapaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MapaEN mapa)
{
        try
        {
                SessionInitializeTransaction ();
                MapaEN mapaEN = (MapaEN)session.Load (typeof(MapaEN), mapa.Id);



                mapaEN.Latitud = mapa.Latitud;


                mapaEN.Longitud = mapa.Longitud;


                mapaEN.Zoom = mapa.Zoom;

                session.Update (mapaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MapaEN mapa)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (mapa);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mapa.Id;
}

public System.Collections.Generic.IList<MapaEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<MapaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MapaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MapaEN>();
                else
                        result = session.CreateCriteria (typeof(MapaEN)).List<MapaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetID
//Con e: MapaEN
public MapaEN GetID (int id
                     )
{
        MapaEN mapaEN = null;

        try
        {
                SessionInitializeTransaction ();
                mapaEN = (MapaEN)session.Get (typeof(MapaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return mapaEN;
}

public void Modify (MapaEN mapa)
{
        try
        {
                SessionInitializeTransaction ();
                MapaEN mapaEN = (MapaEN)session.Load (typeof(MapaEN), mapa.Id);

                mapaEN.Latitud = mapa.Latitud;


                mapaEN.Longitud = mapa.Longitud;


                mapaEN.Zoom = mapa.Zoom;

                session.Update (mapaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
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
                MapaEN mapaEN = (MapaEN)session.Load (typeof(MapaEN), id);
                session.Delete (mapaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> FiltrarTodosMapasParaEventos ()
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MapaEN self where FROM MapaEN as map WHERE map.Evento.ID!=-1";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MapaENfiltrarTodosMapasParaEventosHQL");

                result = query.List<WhateverGenNHibernate.EN.Whatever.MapaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public WhateverGenNHibernate.EN.Whatever.MapaEN FiltrarMapaPorPaso (int ? id_paso)
{
        WhateverGenNHibernate.EN.Whatever.MapaEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MapaEN self where FROM MapaEN as map WHERE map.Paso.ID=:id_paso";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MapaENFiltrarMapaPorPasoHQL");
                query.SetParameter ("id_paso", id_paso);


                result = query.UniqueResult<WhateverGenNHibernate.EN.Whatever.MapaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public WhateverGenNHibernate.EN.Whatever.MapaEN FiltrarMapaPorEvento (int ? id_evento)
{
        WhateverGenNHibernate.EN.Whatever.MapaEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MapaEN self where FROM MapaEN as map WHERE map.Evento.ID=:id_evento";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MapaENfiltrarMapaPorEventoHQL");
                query.SetParameter ("id_evento", id_evento);


                result = query.UniqueResult<WhateverGenNHibernate.EN.Whatever.MapaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void RelationerMapaPaso (int p_Mapa_OID, int p_paso_OID)
{
        WhateverGenNHibernate.EN.Whatever.MapaEN mapaEN = null;
        try
        {
                SessionInitializeTransaction ();
                mapaEN = (MapaEN)session.Load (typeof(MapaEN), p_Mapa_OID);
                mapaEN.Paso = (WhateverGenNHibernate.EN.Whatever.PasoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.PasoEN), p_paso_OID);

                mapaEN.Paso.Mapa = mapaEN;




                session.Update (mapaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void RelationerMapaEvento (int p_Mapa_OID, int p_evento_OID)
{
        WhateverGenNHibernate.EN.Whatever.MapaEN mapaEN = null;
        try
        {
                SessionInitializeTransaction ();
                mapaEN = (MapaEN)session.Load (typeof(MapaEN), p_Mapa_OID);
                mapaEN.Evento = (WhateverGenNHibernate.EN.Whatever.EventoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.EventoEN), p_evento_OID);

                mapaEN.Evento.Mapa = mapaEN;




                session.Update (mapaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void UnrelationerMapaPaso (int p_Mapa_OID, int p_paso_OID)
{
        try
        {
                SessionInitializeTransaction ();
                WhateverGenNHibernate.EN.Whatever.MapaEN mapaEN = null;
                mapaEN = (MapaEN)session.Load (typeof(MapaEN), p_Mapa_OID);

                if (mapaEN.Paso.ID == p_paso_OID) {
                        mapaEN.Paso = null;
                        WhateverGenNHibernate.EN.Whatever.PasoEN pasoEN = (WhateverGenNHibernate.EN.Whatever.PasoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.PasoEN), p_paso_OID);
                        pasoEN.Mapa = null;
                }
                else
                        throw new ModelException ("The identifier " + p_paso_OID + " in p_paso_OID you are trying to unrelationer, doesn't exist in MapaEN");

                session.Update (mapaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void UnrelationerMapaEvento (int p_Mapa_OID, int p_evento_OID)
{
        try
        {
                SessionInitializeTransaction ();
                WhateverGenNHibernate.EN.Whatever.MapaEN mapaEN = null;
                mapaEN = (MapaEN)session.Load (typeof(MapaEN), p_Mapa_OID);

                if (mapaEN.Evento.ID == p_evento_OID) {
                        mapaEN.Evento = null;
                        WhateverGenNHibernate.EN.Whatever.EventoEN eventoEN = (WhateverGenNHibernate.EN.Whatever.EventoEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.EventoEN), p_evento_OID);
                        eventoEN.Mapa = null;
                }
                else
                        throw new ModelException ("The identifier " + p_evento_OID + " in p_evento_OID you are trying to unrelationer, doesn't exist in MapaEN");

                session.Update (mapaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in MapaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
