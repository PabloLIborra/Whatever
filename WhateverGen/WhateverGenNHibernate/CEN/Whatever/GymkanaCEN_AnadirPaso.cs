
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Gymkana_anadirPaso) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class GymkanaCEN
{
public void AnadirPaso (int id_gym, string descripcion, int latitud, int longitud, int zoom)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Gymkana_anadirPaso) ENABLED START*/

        // Write here your custom code...

        PasoCEN paso = new PasoCEN ();
        MapaCEN mapa = new MapaCEN ();
        int aux = -1;
        int aux2 = -1;

        System.Collections.Generic.IList<PasoEN> pasos;
        pasos = paso.GetAll (0, 0);
        aux = pasos [pasos.Count - 1].ID;
        paso.New_ (descripcion, aux + 1, id_gym);

        System.Collections.Generic.IList<MapaEN> mapas;
        mapas = mapa.GetAll (0, 0);

        aux2 = mapas [mapas.Count - 1].Id;
        mapa.New_ (id_gym, aux2 + 1, aux + 1, latitud, longitud, zoom);
        /*PROTECTED REGION END*/
}
}
}
