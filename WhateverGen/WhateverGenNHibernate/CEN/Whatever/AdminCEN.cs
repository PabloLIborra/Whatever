

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
 *      Definition of the class AdminCEN
 *
 */
public partial class AdminCEN
{
private IAdminCAD _IAdminCAD;

public AdminCEN()
{
        this._IAdminCAD = new AdminCAD ();
}

public AdminCEN(IAdminCAD _IAdminCAD)
{
        this._IAdminCAD = _IAdminCAD;
}

public IAdminCAD get_IAdminCAD ()
{
        return this._IAdminCAD;
}

public int New_ (int p_usuario, string p_nombre, int p_ID)
{
        AdminEN adminEN = null;
        int oid;

        //Initialized AdminEN
        adminEN = new AdminEN ();

        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids ID
                adminEN.Usuario = new WhateverGenNHibernate.EN.Whatever.UsuarioEN ();
                adminEN.Usuario.ID = p_usuario;
        }

        adminEN.Nombre = p_nombre;

        adminEN.ID = p_ID;

        //Call to AdminCAD

        oid = _IAdminCAD.New_ (adminEN);
        return oid;
}

public void Modify (int p_Admin_OID, string p_nombre)
{
        AdminEN adminEN = null;

        //Initialized AdminEN
        adminEN = new AdminEN ();
        adminEN.ID = p_Admin_OID;
        adminEN.Nombre = p_nombre;
        //Call to AdminCAD

        _IAdminCAD.Modify (adminEN);
}

public void Destroy (int ID
                     )
{
        _IAdminCAD.Destroy (ID);
}

public System.Collections.Generic.IList<AdminEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<AdminEN> list = null;

        list = _IAdminCAD.GetAll (first, size);
        return list;
}
public AdminEN GetID (int ID
                      )
{
        AdminEN adminEN = null;

        adminEN = _IAdminCAD.GetID (ID);
        return adminEN;
}
}
}
