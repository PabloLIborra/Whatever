
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Comentario_crearComentarioParaEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class ComentarioCP : BasicCP
{
public int CrearComentarioParaEvento (int id_evento, string texto, int id_usuario)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Comentario_crearComentarioParaEvento) ENABLED START*/

        IComentarioCAD comentarioCAD = null;
        ComentarioCEN comentarioCEN = null;



        try
        {
                SessionInitializeTransaction ();
                comentarioCAD = new ComentarioCAD (session);
                comentarioCEN = new  ComentarioCEN (comentarioCAD);



                // Write here your custom transaction ...
                UsuarioCAD usucad = new UsuarioCAD (session);
                UsuarioEN usu = usucad.GetID (id_usuario);
                int id = comentarioCEN.New_ (texto, usu.Nombre, id_usuario);
                comentarioCAD.RelationerComentarioEvento (id, id_evento);


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
