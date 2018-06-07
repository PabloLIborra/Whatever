
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Reto_modificarReto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class RetoCEN
{
public void ModificarReto (WhateverGenNHibernate.EN.Whatever.RetoEN reto)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Reto_modificarReto) ENABLED START*/

        // Write here your custom code...

        _IRetoCAD.Modify (reto);

        /*PROTECTED REGION END*/
}
}
}
