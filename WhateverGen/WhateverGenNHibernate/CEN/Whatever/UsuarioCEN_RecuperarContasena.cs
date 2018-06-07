
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_recuperarContasena) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public int RecuperarContasena (string correo, string nombre)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_recuperarContasena) ENABLED START*/

        // Write here your custom code...

        System.Collections.Generic.IList<UsuarioEN> list;
        list = FiltrarNombreCorreo (nombre, correo);
        foreach (UsuarioEN element in list) {
                return element.ID;
        }
        return -1;
        /*PROTECTED REGION END*/
}
}
}
