
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Comentario_crearComentarioParaGymkana) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class ComentarioCP : BasicCP
{
public int CrearComentarioParaGymkana (int id_gym, string texto, int id_usuario)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Comentario_crearComentarioParaGymkana) ENABLED START*/

        IComentarioCAD comentarioCAD = null;
        ComentarioCEN comentarioCEN = null;

        int result = -1;


        try
        {
                SessionInitializeTransaction ();
                comentarioCAD = new ComentarioCAD (session);
                comentarioCEN = new  ComentarioCEN (comentarioCAD);


                UsuarioCAD usucad = new UsuarioCAD (session);
                UsuarioEN usu = usucad.GetID (id_usuario);
                int id = comentarioCEN.New_ (texto, usu.Nombre, id_usuario);
                comentarioCAD.RelationerComentarioGymkana (id, id_gym);



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
