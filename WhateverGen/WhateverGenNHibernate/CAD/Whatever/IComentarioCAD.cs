
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (int ID
                             );

void ModifyDefault (ComentarioEN comentario);



int New_ (ComentarioEN comentario);

void Destroy (int ID
              );


System.Collections.Generic.IList<ComentarioEN> GetAll (int first, int size);


ComentarioEN GetID (int ID
                    );



void Modify (ComentarioEN comentario);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> FiltrarComentarioPorUsuario (int ? id_usuario);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> FiltrarComentarioPorReto (int ? id_reto);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> FiltrarComentarioPorEvento (int ? id_evento);






void RelationerComentarioEvento (int p_Comentario_OID, int p_evento_OID);

void RelationerComentarioReto (int p_Comentario_OID, int p_reto_OID);

void UnrelationerComentarioEvento (int p_Comentario_OID, int p_evento_OID);

void UnrelationerComentarioReto (int p_Comentario_OID, int p_reto_OID);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.ComentarioEN> FiltrarComentarioPorGymkana (int ? id_gym);




void RelationerComentarioGymkana (int p_Comentario_OID, int p_gymkana_OID);

void UnrelationerComentarioGymkana (int p_Comentario_OID, int p_gymkana_OID);
}
}
