
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Comentario_borrarUnComentario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class ComentarioCP : BasicCP
{
public void BorrarUnComentario (int id_comentario)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Comentario_borrarUnComentario) ENABLED START*/

        IComentarioCAD comentarioCAD = null;
        ComentarioCEN comentarioCEN = null;



        try
        {
                SessionInitializeTransaction ();
                comentarioCAD = new ComentarioCAD (session);
                comentarioCEN = new  ComentarioCEN (comentarioCAD);



                // Write here your custom transaction ...

                EventoEN even = new EventoEN ();
                even = comentarioCAD.GetID (id_comentario).Evento;
                RetoEN reten = new RetoEN ();
                reten = comentarioCAD.GetID (id_comentario).Reto;
                GymkanaEN gymen = new GymkanaEN ();
                gymen = comentarioCAD.GetID (id_comentario).Gymkana;
                if (even != null) {
                        comentarioCAD.UnrelationerComentarioEvento (id_comentario, even.ID);
                        comentarioCAD.Destroy (id_comentario);
                }
                else if (reten != null) {
                        comentarioCAD.UnrelationerComentarioReto (id_comentario, reten.ID);
                        comentarioCAD.Destroy (id_comentario);
                }
                else if (gymen != null) {
                        comentarioCAD.UnrelationerComentarioGymkana (id_comentario, gymen.ID);
                        comentarioCAD.Destroy (id_comentario);
                }


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


        /*PROTECTED REGION END*/
}
}
}
