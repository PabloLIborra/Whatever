

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
 *      Definition of the class GymkanaCEN
 *
 */
public partial class GymkanaCEN
{
private IGymkanaCAD _IGymkanaCAD;

public GymkanaCEN()
{
        this._IGymkanaCAD = new GymkanaCAD ();
}

public GymkanaCEN(IGymkanaCAD _IGymkanaCAD)
{
        this._IGymkanaCAD = _IGymkanaCAD;
}

public IGymkanaCAD get_IGymkanaCAD ()
{
        return this._IGymkanaCAD;
}

public System.Collections.Generic.IList<GymkanaEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<GymkanaEN> list = null;

        list = _IGymkanaCAD.GetAll (first, size);
        return list;
}
public GymkanaEN GetID (int ID
                        )
{
        GymkanaEN gymkanaEN = null;

        gymkanaEN = _IGymkanaCAD.GetID (ID);
        return gymkanaEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.GymkanaEN> FiltrarGymkanaPorUsuario (int ? id_usu)
{
        return _IGymkanaCAD.FiltrarGymkanaPorUsuario (id_usu);
}
public int New_ (int p_numPasos, string p_Titulo, string p_descripcion, Nullable<DateTime> p_fecha, double p_precio, int p_usuario)
{
        GymkanaEN gymkanaEN = null;
        int oid;

        //Initialized GymkanaEN
        gymkanaEN = new GymkanaEN ();
        gymkanaEN.NumPasos = p_numPasos;

        gymkanaEN.Titulo = p_Titulo;

        gymkanaEN.Descripcion = p_descripcion;

        gymkanaEN.Fecha = p_fecha;

        gymkanaEN.Precio = p_precio;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids ID
                gymkanaEN.Usuario = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                gymkanaEN.Usuario.ID = p_usuario;
        }

        //Call to GymkanaCAD

        oid = _IGymkanaCAD.New_ (gymkanaEN);
        return oid;
}

public void Modify (int p_Gymkana_OID, int p_numPasos, string p_Titulo, string p_descripcion, Nullable<DateTime> p_fecha, double p_precio)
{
        GymkanaEN gymkanaEN = null;

        //Initialized GymkanaEN
        gymkanaEN = new GymkanaEN ();
        gymkanaEN.ID = p_Gymkana_OID;
        gymkanaEN.NumPasos = p_numPasos;
        gymkanaEN.Titulo = p_Titulo;
        gymkanaEN.Descripcion = p_descripcion;
        gymkanaEN.Fecha = p_fecha;
        gymkanaEN.Precio = p_precio;
        //Call to GymkanaCAD

        _IGymkanaCAD.Modify (gymkanaEN);
}

public void Destroy (int ID
                     )
{
        _IGymkanaCAD.Destroy (ID);
}
}
}
