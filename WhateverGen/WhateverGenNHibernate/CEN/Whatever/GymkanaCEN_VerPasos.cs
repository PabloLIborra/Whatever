
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Gymkana_verPasos) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class GymkanaCEN
{
public System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> VerPasos (int id_gym)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Gymkana_verPasos) ENABLED START*/

        // Write here your custom code...

        PasoCEN paso = new PasoCEN ();

        System.Collections.Generic.IList<PasoEN> pasos;
        pasos = paso.VerPasos (id_gym);
        return pasos;
        /*PROTECTED REGION END*/
}
}
}
