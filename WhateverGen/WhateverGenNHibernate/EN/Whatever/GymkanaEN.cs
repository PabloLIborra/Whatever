
using System;
// Definición clase GymkanaEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class GymkanaEN
{
/**
 *	Atributo numPasos
 */
private int numPasos;



/**
 *	Atributo paso
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> paso;



/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario;



/**
 *	Atributo puntuacion
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion;



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
 *	Atributo usuario
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario;



/**
 *	Atributo iD
 */
private int iD;






public virtual int NumPasos {
        get { return numPasos; } set { numPasos = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> Paso {
        get { return paso; } set { paso = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



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



public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}





public GymkanaEN()
{
        paso = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.PasoEN>();
        reporte = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
        comentario = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ComentarioEN>();
        puntuacion = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
}



public GymkanaEN(int iD, int numPasos, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> paso, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, string titulo, string descripcion, Nullable<DateTime> fecha, double precio, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario
                 )
{
        this.init (ID, numPasos, paso, reporte, comentario, puntuacion, titulo, descripcion, fecha, precio, usuario);
}


public GymkanaEN(GymkanaEN gymkana)
{
        this.init (ID, gymkana.NumPasos, gymkana.Paso, gymkana.Reporte, gymkana.Comentario, gymkana.Puntuacion, gymkana.Titulo, gymkana.Descripcion, gymkana.Fecha, gymkana.Precio, gymkana.Usuario);
}

private void init (int ID
                   , int numPasos, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> paso, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, string titulo, string descripcion, Nullable<DateTime> fecha, double precio, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario)
{
        this.ID = ID;


        this.NumPasos = numPasos;

        this.Paso = paso;

        this.Reporte = reporte;

        this.Comentario = comentario;

        this.Puntuacion = puntuacion;

        this.Titulo = titulo;

        this.Descripcion = descripcion;

        this.Fecha = fecha;

        this.Precio = precio;

        this.Usuario = usuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        GymkanaEN t = obj as GymkanaEN;
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
