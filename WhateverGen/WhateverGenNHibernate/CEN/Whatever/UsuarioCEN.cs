

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
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public int New_ (string p_nombre, int p_edad, string p_sexo, string p_Facebook, string p_Instagram, string p_Twitter, String p_contrasena, string p_email, string p_foto)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nombre = p_nombre;

        usuarioEN.Edad = p_edad;

        usuarioEN.Sexo = p_sexo;

        usuarioEN.Facebook = p_Facebook;

        usuarioEN.Instagram = p_Instagram;

        usuarioEN.Twitter = p_Twitter;

        usuarioEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);

        usuarioEN.Email = p_email;

        usuarioEN.Foto = p_foto;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.New_ (usuarioEN);
        return oid;
}

public void Modify (int p_Usuario_OID, string p_nombre, int p_edad, string p_sexo, string p_Facebook, string p_Instagram, string p_Twitter, String p_contrasena, string p_email, string p_foto)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.ID = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Edad = p_edad;
        usuarioEN.Sexo = p_sexo;
        usuarioEN.Facebook = p_Facebook;
        usuarioEN.Instagram = p_Instagram;
        usuarioEN.Twitter = p_Twitter;
        usuarioEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);
        usuarioEN.Email = p_email;
        usuarioEN.Foto = p_foto;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);
}

public void Destroy (int ID
                     )
{
        _IUsuarioCAD.Destroy (ID);
}

public System.Collections.Generic.IList<UsuarioEN> GetAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.GetAll (first, size);
        return list;
}
public UsuarioEN GetID (int ID
                        )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.GetID (ID);
        return usuarioEN;
}

public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.UsuarioEN> FiltrarNombreCorreo (string nombre, string correo)
{
        return _IUsuarioCAD.FiltrarNombreCorreo (nombre, correo);
}
public WhateverGenNHibernate.EN.Whatever.UsuarioEN FiltrarUsuarioPorNombre (string nombre)
{
        return _IUsuarioCAD.FiltrarUsuarioPorNombre (nombre);
}
}
}
