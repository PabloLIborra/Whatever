

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
 *      Definition of the class PuntuacionCEN
 *
 */
public partial class PuntuacionCEN
{
private IPuntuacionCAD _IPuntuacionCAD;

public PuntuacionCEN()
{
        this._IPuntuacionCAD = new PuntuacionCAD ();
}

public PuntuacionCEN(IPuntuacionCAD _IPuntuacionCAD)
{
        this._IPuntuacionCAD = _IPuntuacionCAD;
}

public IPuntuacionCAD get_IPuntuacionCAD ()
{
        return this._IPuntuacionCAD;
}

public int New_ (int p_usuario, int p_puntuacion)
{
        PuntuacionEN puntuacionEN = null;
        int oid;

        //Initialized PuntuacionEN
        puntuacionEN = new PuntuacionEN ();

        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                puntuacionEN.Usuario = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                puntuacionEN.Usuario.ID = p_usuario;
        }

        puntuacionEN.Puntuacion = p_puntuacion;

        //Call to PuntuacionCAD

        oid = _IPuntuacionCAD.New_ (puntuacionEN);
        return oid;
}

public System.Collections.Generic.IList<PuntuacionEN> GetPuntuaciones (int first, int size)
{
        System.Collections.Generic.IList<PuntuacionEN> list = null;

        list = _IPuntuacionCAD.GetPuntuaciones (first, size);
        return list;
}
public PuntuacionEN GetID (int id
                           )
{
        PuntuacionEN puntuacionEN = null;

        puntuacionEN = _IPuntuacionCAD.GetID (id);
        return puntuacionEN;
}

public WhateverGenNHibernate.EN.Whatever.PuntuacionEN FiltrarPuntuacionPorUsuarioYReto (int? id_reto, int ? id_usuario)
{
        return _IPuntuacionCAD.FiltrarPuntuacionPorUsuarioYReto (id_reto, id_usuario);
}
public WhateverGenNHibernate.EN.Whatever.PuntuacionEN FiltrarPuntuacionPorEventoYUsuario (int? id_evento, int ? id_usuario)
{
        return _IPuntuacionCAD.FiltrarPuntuacionPorEventoYUsuario (id_evento, id_usuario);
}
public void Modify (int p_Puntuacion_OID, int p_puntuacion)
{
        PuntuacionEN puntuacionEN = null;

        //Initialized PuntuacionEN
        puntuacionEN = new PuntuacionEN ();
        puntuacionEN.Id = p_Puntuacion_OID;
        puntuacionEN.Puntuacion = p_puntuacion;
        //Call to PuntuacionCAD

        _IPuntuacionCAD.Modify (puntuacionEN);
}

public void Destroy (int id
                     )
{
        _IPuntuacionCAD.Destroy (id);
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarPuntuacionPorEvento (int ? id_evento)
{
        return _IPuntuacionCAD.FiltrarPuntuacionPorEvento (id_evento);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarPuntuacionPorReto (int ? id_reto)
{
        return _IPuntuacionCAD.FiltrarPuntuacionPorReto (id_reto);
}
public void RelationerPuntuacionEvento (int p_Puntuacion_OID, int p_evento_OID)
{
        //Call to PuntuacionCAD

        _IPuntuacionCAD.RelationerPuntuacionEvento (p_Puntuacion_OID, p_evento_OID);
}
public void RelationerPuntuacionReto (int p_Puntuacion_OID, int p_reto_OID)
{
        //Call to PuntuacionCAD

        _IPuntuacionCAD.RelationerPuntuacionReto (p_Puntuacion_OID, p_reto_OID);
}
public void UnrelationerPuntuacionEvento (int p_Puntuacion_OID, int p_evento_OID)
{
        //Call to PuntuacionCAD

        _IPuntuacionCAD.UnrelationerPuntuacionEvento (p_Puntuacion_OID, p_evento_OID);
}
public void UnrelationerPuntuacionReto (int p_Puntuacion_OID, int p_reto_OID)
{
        //Call to PuntuacionCAD

        _IPuntuacionCAD.UnrelationerPuntuacionReto (p_Puntuacion_OID, p_reto_OID);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarComentarioPorUsuario (int ? id_usuario)
{
        return _IPuntuacionCAD.FiltrarComentarioPorUsuario (id_usuario);
}
public WhateverGenNHibernate.EN.Whatever.PuntuacionEN FiltrarPuntuacionPorUsuarioYGymkana (int? id_gym, int ? id_usuario)
{
        return _IPuntuacionCAD.FiltrarPuntuacionPorUsuarioYGymkana (id_gym, id_usuario);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarPuntuacionPorGymkana (int ? id_gym)
{
        return _IPuntuacionCAD.FiltrarPuntuacionPorGymkana (id_gym);
}
public void RelationerPuntuacionGymkana (int p_Puntuacion_OID, int p_gymkana_OID)
{
        //Call to PuntuacionCAD

        _IPuntuacionCAD.RelationerPuntuacionGymkana (p_Puntuacion_OID, p_gymkana_OID);
}
public void UnrelationerPuntuacionGymkana (int p_Puntuacion_OID, int p_gymkana_OID)
{
        //Call to PuntuacionCAD

        _IPuntuacionCAD.UnrelationerPuntuacionGymkana (p_Puntuacion_OID, p_gymkana_OID);
}
}
}
