
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_cambiarCorreo) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public bool CambiarCorreo (int p_oid, string correo)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_cambiarCorreo) ENABLED START*/

        // Write here your custom code...

        UsuarioEN user = GetID (p_oid);
        String aux = user.Email;

        Modify (p_oid, user.Nombre, user.Edad, user.Sexo, user.Facebook, user.Instagram, user.Twitter, user.Contrasena, correo, user.Foto);

        if (!aux.Equals (user.Email)) {
                return true;
        }
        return false;
        /*PROTECTED REGION END*/
}
}
}
