
using System;
// Definición clase PuntuacionEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class PuntuacionEN
{
/**
 *	Atributo usuario
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario;



/**
 *	Atributo reto
 */
private WhateverGenNHibernate.EN.Whatever.RetoEN reto;



/**
 *	Atributo evento
 */
private WhateverGenNHibernate.EN.Whatever.EventoEN evento;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo puntuacion
 */
private int puntuacion;



/**
 *	Atributo gymkana
 */
private WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana;






public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.RetoEN Reto {
        get { return reto; } set { reto = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.EventoEN Evento {
        get { return evento; } set { evento = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.GymkanaEN Gymkana {
        get { return gymkana; } set { gymkana = value;  }
}





public PuntuacionEN()
{
}



public PuntuacionEN(int id, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, WhateverGenNHibernate.EN.Whatever.RetoEN reto, WhateverGenNHibernate.EN.Whatever.EventoEN evento, int puntuacion, WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana
                    )
{
        this.init (Id, usuario, reto, evento, puntuacion, gymkana);
}


public PuntuacionEN(PuntuacionEN puntuacion)
{
        this.init (Id, puntuacion.Usuario, puntuacion.Reto, puntuacion.Evento, puntuacion.Puntuacion, puntuacion.Gymkana);
}

private void init (int id
                   , WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, WhateverGenNHibernate.EN.Whatever.RetoEN reto, WhateverGenNHibernate.EN.Whatever.EventoEN evento, int puntuacion, WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana)
{
        this.Id = id;


        this.Usuario = usuario;

        this.Reto = reto;

        this.Evento = evento;

        this.Puntuacion = puntuacion;

        this.Gymkana = gymkana;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PuntuacionEN t = obj as PuntuacionEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
