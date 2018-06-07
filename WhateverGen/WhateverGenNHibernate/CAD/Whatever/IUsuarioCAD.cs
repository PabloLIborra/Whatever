
using System;
using WhateverGenNHibernate.EN.Whatever;

namespace WhateverGenNHibernate.CAD.Whatever
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (int ID
                          );

void ModifyDefault (UsuarioEN usuario);







int New_ (UsuarioEN usuario);

void Modify (UsuarioEN usuario);


void Destroy (int ID
              );


System.Collections.Generic.IList<UsuarioEN> GetAll (int first, int size);


UsuarioEN GetID (int ID
                 );



System.Collections.Generic.IList<WhateverGenNHibernate.EN.Whatever.UsuarioEN> FiltrarNombreCorreo (string nombre, string correo);







WhateverGenNHibernate.EN.Whatever.UsuarioEN FiltrarUsuarioPorNombre (string nombre);
}
}
