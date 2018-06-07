
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_hacerAdmin) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public void HacerAdmin (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_hacerAdmin) ENABLED START*/

        // Write here your custom code...
        AdminCEN admincen = new AdminCEN ();
        UsuarioEN usuen = new UsuarioEN ();

        usuen = GetID (p_oid);
        Destroy (p_oid);
        admincen.New_ ( usuen.Nombre, usuen.Seguidores, usuen.Edad, usuen.Sexo, usuen.Facebook, usuen.Instagram, usuen.Historial, usuen.Contrasena, usuen.Email, usuen.Foto);
        /*PROTECTED REGION END*/
}
}
}
