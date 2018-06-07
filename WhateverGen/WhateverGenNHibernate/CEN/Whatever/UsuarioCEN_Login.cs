
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_Login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public bool Login (string nombre, string password)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_Login) ENABLED START*/

        // Write here your custom code...
        UsuarioCAD usucad = new UsuarioCAD ();
        UsuarioEN usuen = FiltrarUsuarioPorNombre (nombre);

        if (usuen.Contrasena.Equals (Utils.Util.GetEncondeMD5 (password)))
                return true;
        return false;


        /*PROTECTED REGION END*/
}
}
}
