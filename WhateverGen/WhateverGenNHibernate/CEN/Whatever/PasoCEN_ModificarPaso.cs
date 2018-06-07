
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Paso_modificarPaso) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class PasoCEN
{
public void ModificarPaso (WhateverGenNHibernate.EN.Whatever.PasoEN paso, WhateverGenNHibernate.EN.Whatever.MapaEN mapa)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Paso_modificarPaso) ENABLED START*/

        PasoCAD pas = new PasoCAD ();
        MapaCAD map = new MapaCAD ();

        pas.Modify (paso);
        map.Modify (mapa);
        /*PROTECTED REGION END*/
}
}
}
