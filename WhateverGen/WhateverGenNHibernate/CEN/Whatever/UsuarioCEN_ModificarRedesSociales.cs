
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_ModificarRedesSociales) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public void ModificarRedesSociales (string insta, string facebook, string twitter, int id_usuario)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_ModificarRedesSociales) ENABLED START*/

        // Write here your custom code...

        UsuarioEN usuen = new UsuarioEN ();

        usuen = _IUsuarioCAD.GetID (id_usuario);
        usuen.Facebook = facebook;
        usuen.Twitter = twitter;
        usuen.Instagram = insta;
        _IUsuarioCAD.Modify (usuen);

        /*PROTECTED REGION END*/
}
}
}
