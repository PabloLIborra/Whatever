
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Puntuacion_crearPuntuacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class PuntuacionCEN
{
public void CrearPuntuacion (WhateverGenNHibernate.EN.Whatever.PuntuacionEN puntuacion)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Puntuacion_crearPuntuacion) ENABLED START*/

        _IPuntuacionCAD.New_ (puntuacion);

        /*PROTECTED REGION END*/
}
}
}
