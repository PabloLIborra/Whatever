
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Reto_crearReto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class RetoCEN
{
public void CrearReto (WhateverGenNHibernate.EN.Whatever.RetoEN reto)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Reto_crearReto) ENABLED START*/

        _IRetoCAD.New_ (reto);

        /*PROTECTED REGION END*/
}
}
}
