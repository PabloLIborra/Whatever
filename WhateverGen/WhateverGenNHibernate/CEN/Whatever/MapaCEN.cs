

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
 *      Definition of the class MapaCEN
 *
 */
public partial class MapaCEN
{
private IMapaCAD _IMapaCAD;

public MapaCEN()
{
        this._IMapaCAD = new MapaCAD ();
}

public MapaCEN(IMapaCAD _IMapaCAD)
{
        this._IMapaCAD = _IMapaCAD;
}

public IMapaCAD get_IMapaCAD ()
{
        return this._IMapaCAD;
}

public int New_ (string p_latitud, string p_longitud, int p_zoom)
{
        MapaEN mapaEN = null;
        int oid;

        //Initialized MapaEN
        mapaEN = new MapaEN ();
        mapaEN.Latitud = p_latitud;

        mapaEN.Longitud = p_longitud;

        mapaEN.Zoom = p_zoom;

        //Call to MapaCAD

        oid = _IMapaCAD.New_ (mapaEN);
        return oid;
}

public System.Collections.Generic.IList<MapaEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<MapaEN> list = null;

        list = _IMapaCAD.GetAll (first, size);
        return list;
}
public MapaEN GetID (int id
                     )
{
        MapaEN mapaEN = null;

        mapaEN = _IMapaCAD.GetID (id);
        return mapaEN;
}

public void Modify (int p_Mapa_OID, string p_latitud, string p_longitud, int p_zoom)
{
        MapaEN mapaEN = null;

        //Initialized MapaEN
        mapaEN = new MapaEN ();
        mapaEN.Id = p_Mapa_OID;
        mapaEN.Latitud = p_latitud;
        mapaEN.Longitud = p_longitud;
        mapaEN.Zoom = p_zoom;
        //Call to MapaCAD

        _IMapaCAD.Modify (mapaEN);
}

public void Destroy (int id
                     )
{
        _IMapaCAD.Destroy (id);
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> FiltrarTodosMapasParaEventos ()
{
        return _IMapaCAD.FiltrarTodosMapasParaEventos ();
}
public WhateverGenNHibernate.EN.Whatever.MapaEN FiltrarMapaPorPaso (int ? id_paso)
{
        return _IMapaCAD.FiltrarMapaPorPaso (id_paso);
}
public WhateverGenNHibernate.EN.Whatever.MapaEN FiltrarMapaPorEvento (int ? id_evento)
{
        return _IMapaCAD.FiltrarMapaPorEvento (id_evento);
}
public void RelationerMapaPaso (int p_Mapa_OID, int p_paso_OID)
{
        //Call to MapaCAD

        _IMapaCAD.RelationerMapaPaso (p_Mapa_OID, p_paso_OID);
}
public void RelationerMapaEvento (int p_Mapa_OID, int p_evento_OID)
{
        //Call to MapaCAD

        _IMapaCAD.RelationerMapaEvento (p_Mapa_OID, p_evento_OID);
}
public void UnrelationerMapaPaso (int p_Mapa_OID, int p_paso_OID)
{
        //Call to MapaCAD

        _IMapaCAD.UnrelationerMapaPaso (p_Mapa_OID, p_paso_OID);
}
public void UnrelationerMapaEvento (int p_Mapa_OID, int p_evento_OID)
{
        //Call to MapaCAD

        _IMapaCAD.UnrelationerMapaEvento (p_Mapa_OID, p_evento_OID);
}
}
}
