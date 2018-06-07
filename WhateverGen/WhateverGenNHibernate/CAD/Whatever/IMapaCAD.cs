
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IMapaCAD
{
MapaEN ReadOIDDefault (int id
                       );

void ModifyDefault (MapaEN mapa);




int New_ (MapaEN mapa);

System.Collections.Generic.IList<MapaEN> GetAll (int first, int size);


MapaEN GetID (int id
              );


void Modify (MapaEN mapa);


void Destroy (int id
              );


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.MapaEN> FiltrarTodosMapasParaEventos ();


WhateverGenNHibernate.EN.Whatever.MapaEN FiltrarMapaPorPaso (int ? id_paso);


WhateverGenNHibernate.EN.Whatever.MapaEN FiltrarMapaPorEvento (int ? id_evento);






void RelationerMapaPaso (int p_Mapa_OID, int p_paso_OID);

void RelationerMapaEvento (int p_Mapa_OID, int p_evento_OID);

void UnrelationerMapaPaso (int p_Mapa_OID, int p_paso_OID);

void UnrelationerMapaEvento (int p_Mapa_OID, int p_evento_OID);
}
}
