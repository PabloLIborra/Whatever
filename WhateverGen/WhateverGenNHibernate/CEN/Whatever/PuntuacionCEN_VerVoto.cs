
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Puntuacion_verVoto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class PuntuacionCEN
{
public int VerVoto (int id_usuario, int id_gym, int id_reto)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Puntuacion_verVoto) ENABLED START*/

        // Write here your custom code...

        if (id_gym != -1 && id_reto == -1) {
                PuntuacionCEN punt = new PuntuacionCEN ();
                PuntuacionEN puntuacionBuena = new PuntuacionEN ();

                System.Collections.Generic.IList<PuntuacionEN> listaP;
                listaP = FiltrarEvento (id_gym, id_usuario);
                foreach (PuntuacionEN element in listaP) {
                        return element.Puntuacion;
                }
                return -1;
        }
        else{
                PuntuacionCEN punt = new PuntuacionCEN ();
                PuntuacionEN puntuacionBuena = new PuntuacionEN ();

                System.Collections.Generic.IList<PuntuacionEN> listaP;
                listaP = FiltrarReto (id_reto, id_usuario);
                foreach (PuntuacionEN element in listaP) {
                        return element.Puntuacion;
                }
                return -1;
        }
        /*PROTECTED REGION END*/
}
}
}
