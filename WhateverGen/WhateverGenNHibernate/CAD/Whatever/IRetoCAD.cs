
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IRetoCAD
{
RetoEN ReadOIDDefault (int ID
                       );

void ModifyDefault (RetoEN reto);




int New_ (RetoEN reto);

void Modify (RetoEN reto);


void Destroy (int ID
              );


System.Collections.Generic.IList<RetoEN> GetAll (int first, int size);


RetoEN GetID (int ID
              );





System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.RetoEN> FiltrarRetoPorUsuario (int ? id_usu);
}
}
