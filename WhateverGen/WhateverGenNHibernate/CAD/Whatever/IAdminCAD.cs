
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IAdminCAD
{
AdminEN ReadOIDDefault (int ID
                        );

void ModifyDefault (AdminEN admin);



int New_ (AdminEN admin);

void Modify (AdminEN admin);


void Destroy (int ID
              );


System.Collections.Generic.IList<AdminEN> GetAll (int first, int size);


AdminEN GetID (int ID
               );
}
}
