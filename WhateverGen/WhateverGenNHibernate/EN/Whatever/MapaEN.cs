
using System;
// Definición clase MapaEN
namespace WhateverGenNHibernate.EN.Whatever
{
public partial class MapaEN
{
/**
 *	Atributo evento
 */
private WhateverGenNHibernate.EN.Whatever.EventoEN evento;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo paso
 */
private WhateverGenNHibernate.EN.Whatever.PasoEN paso;



/**
 *	Atributo latitud
 */
private string latitud;



/**
 *	Atributo longitud
 */
private string longitud;



/**
 *	Atributo zoom
 */
private int zoom;






public virtual WhateverGenNHibernate.EN.Whatever.EventoEN Evento {
        get { return evento; } set { evento = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual WhateverGenNHibernate.EN.Whatever.PasoEN Paso {
        get { return paso; } set { paso = value;  }
}



public virtual string Latitud {
        get { return latitud; } set { latitud = value;  }
}



public virtual string Longitud {
        get { return longitud; } set { longitud = value;  }
}



public virtual int Zoom {
        get { return zoom; } set { zoom = value;  }
}





public MapaEN()
{
}



public MapaEN(int id, WhateverGenNHibernate.EN.Whatever.EventoEN evento, WhateverGenNHibernate.EN.Whatever.PasoEN paso, string latitud, string longitud, int zoom
              )
{
        this.init (Id, evento, paso, latitud, longitud, zoom);
}


public MapaEN(MapaEN mapa)
{
        this.init (Id, mapa.Evento, mapa.Paso, mapa.Latitud, mapa.Longitud, mapa.Zoom);
}

private void init (int id
                   , WhateverGenNHibernate.EN.Whatever.EventoEN evento, WhateverGenNHibernate.EN.Whatever.PasoEN paso, string latitud, string longitud, int zoom)
{
        this.Id = id;


        this.Evento = evento;

        this.Paso = paso;

        this.Latitud = latitud;

        this.Longitud = longitud;

        this.Zoom = zoom;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MapaEN t = obj as MapaEN;
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
