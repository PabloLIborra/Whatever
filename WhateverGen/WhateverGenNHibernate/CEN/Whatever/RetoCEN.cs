

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
 *      Definition of the class RetoCEN
 *
 */
public partial class RetoCEN
{
private IRetoCAD _IRetoCAD;

public RetoCEN()
{
        this._IRetoCAD = new RetoCAD ();
}

public RetoCEN(IRetoCAD _IRetoCAD)
{
        this._IRetoCAD = _IRetoCAD;
}

public IRetoCAD get_IRetoCAD ()
{
        return this._IRetoCAD;
}

public int New_ (string p_titulo, string p_descripcion, string p_tipo, double p_precio, string p_imagen, int p_usuario)
{
        RetoEN retoEN = null;
        int oid;

        //Initialized RetoEN
        retoEN = new RetoEN ();
        retoEN.Titulo = p_titulo;

        retoEN.Descripcion = p_descripcion;

        retoEN.Tipo = p_tipo;

        retoEN.Precio = p_precio;

        retoEN.Imagen = p_imagen;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids ID
                retoEN.Usuario = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                retoEN.Usuario.ID = p_usuario;
        }

        //Call to RetoCAD

        oid = _IRetoCAD.New_ (retoEN);
        return oid;
}

public void Modify (int p_Reto_OID, string p_titulo, string p_descripcion, string p_tipo, double p_precio, string p_imagen)
{
        RetoEN retoEN = null;

        //Initialized RetoEN
        retoEN = new RetoEN ();
        retoEN.ID = p_Reto_OID;
        retoEN.Titulo = p_titulo;
        retoEN.Descripcion = p_descripcion;
        retoEN.Tipo = p_tipo;
        retoEN.Precio = p_precio;
        retoEN.Imagen = p_imagen;
        //Call to RetoCAD

        _IRetoCAD.Modify (retoEN);
}

public void Destroy (int ID
                     )
{
        _IRetoCAD.Destroy (ID);
}

public System.Collections.Generic.IList<RetoEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<RetoEN> list = null;

        list = _IRetoCAD.GetAll (first, size);
        return list;
}
public RetoEN GetID (int ID
                     )
{
        RetoEN retoEN = null;

        retoEN = _IRetoCAD.GetID (ID);
        return retoEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> FiltrarRetoPorUsuario (int ? id_usu)
{
        return _IRetoCAD.FiltrarRetoPorUsuario (id_usu);
}
}
}
