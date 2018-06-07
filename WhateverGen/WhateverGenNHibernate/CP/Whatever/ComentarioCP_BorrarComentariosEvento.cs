
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Comentario_borrarComentariosEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class ComentarioCP : BasicCP
{
public void BorrarComentariosEvento (int id_evento)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Comentario_borrarComentariosEvento) ENABLED START*/

        IComentarioCAD comentarioCAD = null;
        ComentarioCEN comentarioCEN = null;



        try
        {
                SessionInitializeTransaction ();
                comentarioCAD = new ComentarioCAD (session);
                comentarioCEN = new  ComentarioCEN (comentarioCAD);



                // Write here your custom transaction ...
                System.Collections.Generic.IList<ComentarioEN> comentarios = new System.Collections.Generic.List<ComentarioEN>();
                comentarios = comentarioCAD.FiltrarComentarioPorEvento (id_evento);
                foreach (ComentarioEN element in comentarios) {
                        comentarioCAD.UnrelationerComentarioEvento (element.ID, id_evento);
                        comentarioCAD.Destroy (element.ID);
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
