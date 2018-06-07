
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IEventoCAD
{
EventoEN ReadOIDDefault (int ID
                         );

void ModifyDefault (EventoEN evento);




int New_ (EventoEN evento);

void Modify (EventoEN evento);


void Destroy (int ID
              );


System.Collections.Generic.IList<EventoEN> GetAll (int first, int size);


EventoEN GetID (int ID
                );


System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.EventoEN> FiltrarEventoPorUsuario (int ? id_usu);





void AnadirMapa (int p_Evento_OID, int p_mapa_OID);

void EliminarMapa (int p_Evento_OID, int p_mapa_OID);
}
}
