
using System;
// Definición clase EventoEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class EventoEN
{
/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo precio
 */
private double precio;



/**
 *	Atributo iD
 */
private int iD;



/**
 *	Atributo usuario
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario;



/**
 *	Atributo puntuacion
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion;



/**
 *	Atributo mapa
 */
private WhateverGenNHibernate.EN.Whatever.MapaEN mapa;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario;



/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte;






public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.MapaEN Mapa {
        get { return mapa; } set { mapa = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}





public EventoEN()
{
        puntuacion = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
        comentario = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ComentarioEN>();
        reporte = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
}



public EventoEN(int iD, string titulo, string descripcion, Nullable<DateTime> fecha, double precio, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, WhateverGenNHibernate.EN.Whatever.MapaEN mapa, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte
                )
{
        this.init (ID, titulo, descripcion, fecha, precio, usuario, puntuacion, mapa, comentario, reporte);
}


public EventoEN(EventoEN evento)
{
        this.init (ID, evento.Titulo, evento.Descripcion, evento.Fecha, evento.Precio, evento.Usuario, evento.Puntuacion, evento.Mapa, evento.Comentario, evento.Reporte);
}

private void init (int ID
                   , string titulo, string descripcion, Nullable<DateTime> fecha, double precio, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, WhateverGenNHibernate.EN.Whatever.MapaEN mapa, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte)
{
        this.ID = ID;


        this.Titulo = titulo;

        this.Descripcion = descripcion;

        this.Fecha = fecha;

        this.Precio = precio;

        this.Usuario = usuario;

        this.Puntuacion = puntuacion;

        this.Mapa = mapa;

        this.Comentario = comentario;

        this.Reporte = reporte;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EventoEN t = obj as EventoEN;
        if (t == null)
                return false;
        if (ID.Equals (t.ID))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.ID.GetHashCode ();
        return hash;
}
}
}
