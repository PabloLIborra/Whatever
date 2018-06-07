
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Gymkana_modificarGymkana) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class GymkanaCEN
{
public void ModificarGymkana (WhateverGenNHibernate.EN.Whatever.GymkanaEN gym, WhateverGenNHibernate.EN.Whatever.MapaEN mapa)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Gymkana_modificarGymkana) ENABLED START*/

        GymkanaCAD gymk = new GymkanaCAD ();
        MapaCAD map = new MapaCAD ();

        gymk.Modify (gym);
        map.Modify (mapa);

        /*PROTECTED REGION END*/
}
}
}
