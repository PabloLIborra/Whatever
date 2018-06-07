

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
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int New_ (string p_texto, string p_creador, int p_usuario)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Texto = p_texto;

        comentarioEN.Creador = p_creador;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids ID
                comentarioEN.Usuario = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                comentarioEN.Usuario.ID = p_usuario;
        }

        //Call to ComentarioCAD

        oid = _IComentarioCAD.New_ (comentarioEN);
        return oid;
}

public void Destroy (int ID
                     )
{
        _IComentarioCAD.Destroy (ID);
}

public System.Collections.Generic.IList<ComentarioEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> list = null;

        list = _IComentarioCAD.GetAll (first, size);
        return list;
}
public ComentarioEN GetID (int ID
                           )
{
        ComentarioEN comentarioEN = null;

        comentarioEN = _IComentarioCAD.GetID (ID);
        return comentarioEN;
}

public void Modify (int p_Comentario_OID, string p_texto, string p_creador)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.ID = p_Comentario_OID;
        comentarioEN.Texto = p_texto;
        comentarioEN.Creador = p_creador;
        //Call to ComentarioCAD

        _IComentarioCAD.Modify (comentarioEN);
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> FiltrarComentarioPorUsuario (int ? id_usuario)
{
        return _IComentarioCAD.FiltrarComentarioPorUsuario (id_usuario);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> FiltrarComentarioPorReto (int ? id_reto)
{
        return _IComentarioCAD.FiltrarComentarioPorReto (id_reto);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> FiltrarComentarioPorEvento (int ? id_evento)
{
        return _IComentarioCAD.FiltrarComentarioPorEvento (id_evento);
}
public void RelationerComentarioEvento (int p_Comentario_OID, int p_evento_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.RelationerComentarioEvento (p_Comentario_OID, p_evento_OID);
}
public void RelationerComentarioReto (int p_Comentario_OID, int p_reto_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.RelationerComentarioReto (p_Comentario_OID, p_reto_OID);
}
public void UnrelationerComentarioEvento (int p_Comentario_OID, int p_evento_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.UnrelationerComentarioEvento (p_Comentario_OID, p_evento_OID);
}
public void UnrelationerComentarioReto (int p_Comentario_OID, int p_reto_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.UnrelationerComentarioReto (p_Comentario_OID, p_reto_OID);
}
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> FiltrarComentarioPorGymkana (int ? id_gym)
{
        return _IComentarioCAD.FiltrarComentarioPorGymkana (id_gym);
}
public void RelationerComentarioGymkana (int p_Comentario_OID, int p_gymkana_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.RelationerComentarioGymkana (p_Comentario_OID, p_gymkana_OID);
}
public void UnrelationerComentarioGymkana (int p_Comentario_OID, int p_gymkana_OID)
{
        //Call to ComentarioCAD

        _IComentarioCAD.UnrelationerComentarioGymkana (p_Comentario_OID, p_gymkana_OID);
}
}
}
