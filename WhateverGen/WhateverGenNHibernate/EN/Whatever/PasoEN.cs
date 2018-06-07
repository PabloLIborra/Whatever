
using System;
// Definición clase PasoEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class PasoEN
{
/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo iD
 */
private int iD;



/**
 *	Atributo gymkana
 */
private WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana;



/**
 *	Atributo mapa
 */
private WhateverGenNHibernate.EN.Whatever.MapaEN mapa;






public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual int ID {
        get { return iD; } set { iD = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.GymkanaEN Gymkana {
        get { return gymkana; } set { gymkana = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.MapaEN Mapa {
        get { return mapa; } set { mapa = value;  }
}





public PasoEN()
{
}



public PasoEN(int iD, string descripcion, WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana, WhateverGenNHibernate.EN.Whatever.MapaEN mapa
              )
{
        this.init (ID, descripcion, gymkana, mapa);
}


public PasoEN(PasoEN paso)
{
        this.init (ID, paso.Descripcion, paso.Gymkana, paso.Mapa);
}

private void init (int ID
                   , string descripcion, WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana, WhateverGenNHibernate.EN.Whatever.MapaEN mapa)
{
        this.ID = ID;


        this.Descripcion = descripcion;

        this.Gymkana = gymkana;

        this.Mapa = mapa;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PasoEN t = obj as PasoEN;
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
