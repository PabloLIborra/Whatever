
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IGymkanaCAD
{
GymkanaEN ReadOIDDefault (int ID
                          );

void ModifyDefault (GymkanaEN gymkana);





System.Collections.Generic.IList<GymkanaEN> GetAll (int first, int size);


GymkanaEN GetID (int ID
                 );





System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.GymkanaEN> FiltrarGymkanaPorUsuario (int ? id_usu);


int New_ (GymkanaEN gymkana);

void Modify (GymkanaEN gymkana);


void Destroy (int ID
              );
}
}
