
using System;
// Definición clase UsuarioEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class UsuarioEN
{
/**
 *	Atributo iD
 */
private int iD;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo edad
 */
private int edad;



/**
 *	Atributo sexo
 */
private string sexo;



/**
 *	Atributo facebook
 */
private string facebook;



/**
 *	Atributo instagram
 */
private string instagram;



/**
 *	Atributo twitter
 */
private string twitter;



/**
 *	Atributo reto
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> reto;



/**
 *	Atributo reporte
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte;



/**
 *	Atributo puntuacion
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario;



/**
 *	Atributo evento
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> evento;



/**
 *	Atributo contrasena
 */
private String contrasena;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo foto
 */
private string foto;



/**
 *	Atributo gymkana
 */
private System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.GymkanaEN> gymkana;



/**
 *	Atributo admin
 */
private WhateverGenNHibernate.EN.Whatever.AdminEN admin;






public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual int Edad {
        get { return edad; } set { edad = value;  }
}



public virtual string Sexo {
        get { return sexo; } set { sexo = value;  }
}



public virtual string Facebook {
        get { return facebook; } set { facebook = value;  }
}



public virtual string Instagram {
        get { return instagram; } set { instagram = value;  }
}



public virtual string Twitter {
        get { return twitter; } set { twitter = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> Reto {
        get { return reto; } set { reto = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> Reporte {
        get { return reporte; } set { reporte = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> Evento {
        get { return evento; } set { evento = value;  }
}



public virtual String Contrasena {
        get { return contrasena; } set { contrasena = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual string Foto {
        get { return foto; } set { foto = value;  }
}



public virtual System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.GymkanaEN> Gymkana {
        get { return gymkana; } set { gymkana = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.AdminEN Admin {
        get { return admin; } set { admin = value;  }
}





public UsuarioEN()
{
        reto = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.RetoEN>();
        reporte = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ReporteEN>();
        puntuacion = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.PuntuacionEN>();
        comentario = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.ComentarioEN>();
        evento = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.EventoEN>();
        gymkana = new System.Collections.Generic.List<WhateverGenNHibernate.EN.Whatever.GymkanaEN>();
}



public UsuarioEN(int iD, string nombre, int edad, string sexo, string facebook, string instagram, string twitter, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> reto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> evento, String contrasena, string email, string foto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.GymkanaEN> gymkana, WhateverGenNHibernate.EN.Whatever.AdminEN admin
                 )
{
        this.init (ID, nombre, edad, sexo, facebook, instagram, twitter, reto, reporte, puntuacion, comentario, evento, contrasena, email, foto, gymkana, admin);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (ID, usuario.Nombre, usuario.Edad, usuario.Sexo, usuario.Facebook, usuario.Instagram, usuario.Twitter, usuario.Reto, usuario.Reporte, usuario.Puntuacion, usuario.Comentario, usuario.Evento, usuario.Contrasena, usuario.Email, usuario.Foto, usuario.Gymkana, usuario.Admin);
}

private void init (int ID
                   , string nombre, int edad, string sexo, string facebook, string instagram, string twitter, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> reto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ReporteEN> reporte, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> puntuacion, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> comentario, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> evento, String contrasena, string email, string foto, System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.GymkanaEN> gymkana, WhateverGenNHibernate.EN.Whatever.AdminEN admin)
{
        this.ID = ID;


        this.Nombre = nombre;

        this.Edad = edad;

        this.Sexo = sexo;

        this.Facebook = facebook;

        this.Instagram = instagram;

        this.Twitter = twitter;

        this.Reto = reto;

        this.Reporte = reporte;

        this.Puntuacion = puntuacion;

        this.Comentario = comentario;

        this.Evento = evento;

        this.Contrasena = contrasena;

        this.Email = email;

        this.Foto = foto;

        this.Gymkana = gymkana;

        this.Admin = admin;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
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
