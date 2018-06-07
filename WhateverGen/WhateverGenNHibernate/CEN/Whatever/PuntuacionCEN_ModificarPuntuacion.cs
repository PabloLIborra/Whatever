
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Puntuacion_modificarPuntuacion) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class PuntuacionCEN
{
public void ModificarPuntuacion (int puntuacion, int id_puntuacion)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Puntuacion_modificarPuntuacion) ENABLED START*/
        PuntuacionEN punten = new PuntuacionEN ();

        punten = GetID (id_puntuacion);
        punten.Puntuacion = puntuacion;
        _IPuntuacionCAD.Modify (punten);

        /*PROTECTED REGION END*/
}
}
}
