
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Comentario_crearComentario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class ComentarioCEN
{
public void CrearComentario (WhateverGenNHibernate.EN.Whatever.ComentarioEN evento)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Comentario_crearComentario) ENABLED START*/

        // Write here your custom code...

        _IComentarioCAD.New_ (evento);


        /*PROTECTED REGION END*/
}
}
}
