
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_cambiarFoto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public bool CambiarFoto (int p_oid, string foto)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_cambiarFoto) ENABLED START*/

        // Write here your custom code...

        UsuarioEN user = GetID (p_oid);
        String anteriorFoto = user.Foto;

        Modify (user.ID, user.Nombre, user.Edad, user.Sexo, user.Facebook, user.Instagram, user.Twitter, user.Contrasena, user.Email, foto);

        if (!anteriorFoto.Equals (user.Foto)) {
                return true;
        }
        return false;
        /*PROTECTED REGION END*/
}
}
}
