
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Evento_verEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class EventoCEN
{
public WhateverGenNHibernate.EN.Whatever.EventoEN VerEvento (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Evento_verEvento) ENABLED START*/

        // Write here your custom code...


        System.Collections.Generic.IList<EventoEN> eventos;
        EventoEN salida = new EventoEN ();

        eventos = GetAll (0, 0);
        salida = GetID (p_oid);
        return salida;
        /*PROTECTED REGION END*/
}
}
}
