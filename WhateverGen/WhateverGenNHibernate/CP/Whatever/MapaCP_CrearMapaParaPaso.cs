
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Mapa_crearMapaParaPaso) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class MapaCP : BasicCP
{
public int CrearMapaParaPaso (int id_paso, string latitud, string longitud, int zoom)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Mapa_crearMapaParaPaso) ENABLED START*/

        IMapaCAD mapaCAD = null;
        MapaCEN mapaCEN = null;



        try
        {
                SessionInitializeTransaction ();
                mapaCAD = new MapaCAD (session);
                mapaCEN = new  MapaCEN (mapaCAD);



                // Write here your custom transaction ...

                int id = mapaCEN.New_ (latitud, longitud, zoom);
                mapaCAD.RelationerMapaPaso (id, id_paso);


                SessionCommit ();
                return id;
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
