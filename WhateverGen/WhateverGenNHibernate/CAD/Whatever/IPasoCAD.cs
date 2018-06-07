
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IPasoCAD
{
PasoEN ReadOIDDefault (int ID
                       );

void ModifyDefault (PasoEN paso);




int New_ (PasoEN paso);

void Modify (PasoEN paso);


void Destroy (int ID
              );


System.Collections.Generic.IList<PasoEN> GetAll (int first, int size);


PasoEN GetID (int ID
              );



System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.PasoEN> FiltrarPasoPorGymkana (int ? id_gym);
}
}
