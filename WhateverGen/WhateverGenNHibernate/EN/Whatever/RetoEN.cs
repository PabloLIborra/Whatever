
using System;
// Definición clase RetoEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class RetoEN
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
 *	Atributo tipo
 */
private string tipo;



/**
 *	Atributo precio
 */
private double precio;



/**
 *	Atributo imagen
 */
private string imagen;



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



public virtual string Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
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



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}





public RetoEN()
{
        puntuacion = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
        comentario = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ComentarioEN>();
        reporte = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
}



public RetoEN(int iD, string titulo, string descripcion, string tipo, double precio, string imagen, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte
              )
{
        this.init (ID, titulo, descripcion, tipo, precio, imagen, usuario, puntuacion, comentario, reporte);
}


public RetoEN(RetoEN reto)
{
        this.init (ID, reto.Titulo, reto.Descripcion, reto.Tipo, reto.Precio, reto.Imagen, reto.Usuario, reto.Puntuacion, reto.Comentario, reto.Reporte);
}

private void init (int ID
                   , string titulo, string descripcion, string tipo, double precio, string imagen, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte)
{
        this.ID = ID;


        this.Titulo = titulo;

        this.Descripcion = descripcion;

        this.Tipo = tipo;

        this.Precio = precio;

        this.Imagen = imagen;

        this.Usuario = usuario;

        this.Puntuacion = puntuacion;

        this.Comentario = comentario;

        this.Reporte = reporte;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RetoEN t = obj as RetoEN;
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
