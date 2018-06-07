
using System;
// Definición clase AdminEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class AdminEN
{
/**
 *	Atributo usuario
 */
private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo iD
 */
private int iD;






public virtual WhateverGenNHibernate.EN.Whatever.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}





public AdminEN()
{
}



public AdminEN(int iD, WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, string nombre
               )
{
        this.init (ID, usuario, nombre);
}


public AdminEN(AdminEN admin)
{
        this.init (ID, admin.Usuario, admin.Nombre);
}

private void init (int ID
                   , WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario, string nombre)
{
        this.ID = ID;


        this.Usuario = usuario;

        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdminEN t = obj as AdminEN;
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
