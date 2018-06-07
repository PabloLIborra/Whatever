
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Reto_verReto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class RetoCEN
{
public WhateverGenNHibernate.EN.Whatever.RetoEN VerReto (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Reto_verReto) ENABLED START*/

        // Write here your custom code...

        RetoEN salida = new RetoEN ();

        salida = GetID (p_oid);

        return salida;
        /*PROTECTED REGION END*/
}
}
}
