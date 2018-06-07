
using System;
// Definición clase ComentarioEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class ComentarioEN
{
/**
 *	Atributo texto
 */
private string texto;



/**
 *	Atributo creador
 */
private string creador;



/**
 *	Atributo iD
 */
private int iD;



/**
 *	Atributo usuario
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario;



/**
 *	Atributo evento
 */
private WhateverGenNHibernate.EN.Whatever.EventoEN evento;



/**
 *	Atributo reto
 */
private WhateverGenNHibernate.EN.Whatever.RetoEN reto;



/**
 *	Atributo gymkana
 */
private WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana;






public virtual string Texto {
        get { return texto; } set { texto = value;  }
}



public virtual string Creador {
        get { return creador; } set { creador = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.EventoEN Evento {
        get { return evento; } set { evento = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.RetoEN Reto {
        get { return reto; } set { reto = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.GymkanaEN Gymkana {
        get { return gymkana; } set { gymkana = value;  }
}





public ComentarioEN()
{
}



public ComentarioEN(int iD, string texto, string creador, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, WhateverGenNHibernate.EN.Whatever.EventoEN evento, WhateverGenNHibernate.EN.Whatever.RetoEN reto, WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana
                    )
{
        this.init (ID, texto, creador, usuario, evento, reto, gymkana);
}


public ComentarioEN(ComentarioEN comentario)
{
        this.init (ID, comentario.Texto, comentario.Creador, comentario.Usuario, comentario.Evento, comentario.Reto, comentario.Gymkana);
}

private void init (int ID
                   , string texto, string creador, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, WhateverGenNHibernate.EN.Whatever.EventoEN evento, WhateverGenNHibernate.EN.Whatever.RetoEN reto, WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana)
{
        this.ID = ID;


        this.Texto = texto;

        this.Creador = creador;

        this.Usuario = usuario;

        this.Evento = evento;

        this.Reto = reto;

        this.Gymkana = gymkana;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComentarioEN t = obj as ComentarioEN;
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
