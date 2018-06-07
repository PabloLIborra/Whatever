
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_Registro) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public bool Registro (WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_Registro) ENABLED START*/

        if (FiltrarUsuarioPorNombre (usuario.Nombre) == null) {
                usuario.Contrasena = Utils.Util.GetEncondeMD5 (usuario.Contrasena);
                _IUsuarioCAD.New_ (usuario);
                return true;
        }
        return false;
        /*PROTECTED REGION END*/
}
}
}
