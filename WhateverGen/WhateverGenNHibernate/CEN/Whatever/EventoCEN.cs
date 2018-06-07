

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
 *      Definition of the class EventoCEN
 *
 */
public partial class EventoCEN
{
private IEventoCAD _IEventoCAD;

public EventoCEN()
{
        this._IEventoCAD = new EventoCAD ();
}

public EventoCEN(IEventoCAD _IEventoCAD)
{
        this._IEventoCAD = _IEventoCAD;
}

public IEventoCAD get_IEventoCAD ()
{
        return this._IEventoCAD;
}

public int New_ (string p_Titulo, string p_descripcion, Nullable<DateTime> p_fecha, double p_precio, int p_usuario)
{
        EventoEN eventoEN = null;
        int oid;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.Titulo = p_Titulo;

        eventoEN.Descripcion = p_descripcion;

        eventoEN.Fecha = p_fecha;

        eventoEN.Precio = p_precio;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids ID
                eventoEN.Usuario = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                eventoEN.Usuario.ID = p_usuario;
        }

        //Call to EventoCAD

        oid = _IEventoCAD.New_ (eventoEN);
        return oid;
}

public void Modify (int p_Evento_OID, string p_Titulo, string p_descripcion, Nullable<DateTime> p_fecha, double p_precio)
{
        EventoEN eventoEN = null;

        //Initialized EventoEN
        eventoEN = new EventoEN ();
        eventoEN.ID = p_Evento_OID;
        eventoEN.Titulo = p_Titulo;
        eventoEN.Descripcion = p_descripcion;
        eventoEN.Fecha = p_fecha;
        eventoEN.Precio = p_precio;
        //Call to EventoCAD

        _IEventoCAD.Modify (eventoEN);
}

public void Destroy (int ID
                     )
{
        _IEventoCAD.Destroy (ID);
}

public System.Collections.Generic.IList<EventoEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<EventoEN> list = null;

        list = _IEventoCAD.GetAll (first, size);
        return list;
}
public EventoEN GetID (int ID
                       )
{
        EventoEN eventoEN = null;

        eventoEN = _IEventoCAD.GetID (ID);
        return eventoEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> FiltrarEventoPorUsuario (int ? id_usu)
{
        return _IEventoCAD.FiltrarEventoPorUsuario (id_usu);
}
public void AnadirMapa (int p_Evento_OID, int p_mapa_OID)
{
        //Call to EventoCAD

        _IEventoCAD.AnadirMapa (p_Evento_OID, p_mapa_OID);
}
public void EliminarMapa (int p_Evento_OID, int p_mapa_OID)
{
        //Call to EventoCAD

        _IEventoCAD.EliminarMapa (p_Evento_OID, p_mapa_OID);
}
}
}
