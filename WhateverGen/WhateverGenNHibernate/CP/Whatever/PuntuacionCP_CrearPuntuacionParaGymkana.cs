
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Puntuacion_crearPuntuacionParaGymkana) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class PuntuacionCP : BasicCP
{
public int CrearPuntuacionParaGymkana (int id_evento, int puntuacion, int id_usuario)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Puntuacion_crearPuntuacionParaGymkana) ENABLED START*/

        IPuntuacionCAD puntuacionCAD = null;
        PuntuacionCEN puntuacionCEN = null;

        int result = -1;


        try
        {
                SessionInitializeTransaction ();
                puntuacionCAD = new PuntuacionCAD (session);
                puntuacionCEN = new  PuntuacionCEN (puntuacionCAD);



                // Write here your custom transaction ...


                int id = puntuacionCEN.New_ (id_usuario, puntuacion);
                puntuacionCAD.RelationerPuntuacionGymkana (id, id_evento);


                SessionCommit ();
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
        return result;


        /*PROTECTED REGION END*/
}
}
}
