
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IPuntuacionCAD
{
PuntuacionEN ReadOIDDefault (int id
                             );

void ModifyDefault (PuntuacionEN puntuacion);



int New_ (PuntuacionEN puntuacion);

System.Collections.Generic.IList<PuntuacionEN> GetPuntuaciones (int first, int size);


PuntuacionEN GetID (int id
                    );


WhateverGenNHibernate.EN.Whatever.PuntuacionEN FiltrarPuntuacionPorUsuarioYReto (int? id_reto, int ? id_usuario);


WhateverGenNHibernate.EN.Whatever.PuntuacionEN FiltrarPuntuacionPorEventoYUsuario (int? id_evento, int ? id_usuario);



void Modify (PuntuacionEN puntuacion);


void Destroy (int id
              );


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarPuntuacionPorEvento (int ? id_evento);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarPuntuacionPorReto (int ? id_reto);






void RelationerPuntuacionEvento (int p_Puntuacion_OID, int p_evento_OID);

void RelationerPuntuacionReto (int p_Puntuacion_OID, int p_reto_OID);



void UnrelationerPuntuacionEvento (int p_Puntuacion_OID, int p_evento_OID);

void UnrelationerPuntuacionReto (int p_Puntuacion_OID, int p_reto_OID);

System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarComentarioPorUsuario (int ? id_usuario);


WhateverGenNHibernate.EN.Whatever.PuntuacionEN FiltrarPuntuacionPorUsuarioYGymkana (int? id_gym, int ? id_usuario);


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PuntuacionEN> FiltrarPuntuacionPorGymkana (int ? id_gym);




void RelationerPuntuacionGymkana (int p_Puntuacion_OID, int p_gymkana_OID);


void UnrelationerPuntuacionGymkana (int p_Puntuacion_OID, int p_gymkana_OID);
}
}
