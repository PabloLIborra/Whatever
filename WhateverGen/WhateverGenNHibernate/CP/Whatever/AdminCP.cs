
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using WhateverGenNHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;


namespace WhateverGenNHibernate.CP.Whatever
{
public partial class AdminCP : BasicCP
{
public AdminCP() : base ()
{
}

public AdminCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
