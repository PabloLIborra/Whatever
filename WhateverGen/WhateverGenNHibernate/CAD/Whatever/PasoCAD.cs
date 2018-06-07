
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
 * Clase Paso:
 *
 */

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial class PasoCAD : BasicCAD, IPasoCAD
{
public PasoCAD() : base ()
{
}

public PasoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PasoEN ReadOIDDefault (int ID
                              )
{
        PasoEN pasoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pasoEN = (PasoEN)session.Get (typeof(PasoEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PasoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pasoEN;
}

public System.Collections.Generic.IList<PasoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PasoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PasoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PasoEN>();
                        else
                                result = session.CreateCriteria (typeof(PasoEN)).List<PasoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PasoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PasoEN paso)
{
        try
        {
                SessionInitializeTransaction ();
                PasoEN pasoEN = (PasoEN)session.Load (typeof(PasoEN), paso.ID);

                pasoEN.Descripcion = paso.Descripcion;



                session.Update (pasoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PasoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PasoEN paso)
{
        try
        {
                SessionInitializeTransaction ();
                if (paso.Gymkana != null) {
                        // Argumento OID y no colección.
                        paso.Gymkana = (WhateverGenNHibernate.EN.Whatever.GymkanaEN)session.Load (typeof(WhateverGenNHibernate.EN.Whatever.GymkanaEN), paso.Gymkana.ID);

                        paso.Gymkana.Paso
                        .Add (paso);
                }

                session.Save (paso);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PasoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return paso.ID;
}

public void Modify (PasoEN paso)
{
        try
        {
                SessionInitializeTransaction ();
                PasoEN pasoEN = (PasoEN)session.Load (typeof(PasoEN), paso.ID);

                pasoEN.Descripcion = paso.Descripcion;

                session.Update (pasoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PasoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int ID
                     )
{
        try
        {
                SessionInitializeTransaction ();
                PasoEN pasoEN = (PasoEN)session.Load (typeof(PasoEN), ID);
                session.Delete (pasoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PasoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<PasoEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<PasoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PasoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PasoEN>();
                else
                        result = session.CreateCriteria (typeof(PasoEN)).List<PasoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PasoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: GetID
//Con e: PasoEN
public PasoEN GetID (int ID
                     )
{
        PasoEN pasoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pasoEN = (PasoEN)session.Get (typeof(PasoEN), ID);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PasoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pasoEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> FiltrarPasoPorGymkana (int ? id_gym)
{
        System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PasoEN self where FROM PasoEN as pas WHERE pas.Gymkana.ID=:id_gym";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PasoENfiltrarPasoPorGymkanaHQL");
                query.SetParameter ("id_gym", id_gym);

                result = query.List<WhateverGenNHibernate.EN.Whatever.PasoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is WhateverGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new WhateverGenNHibernate.Exceptions.DataLayerException ("Error in PasoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
