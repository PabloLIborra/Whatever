
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Admin_borrarEvento) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class AdminCP : BasicCP
{
public void BorrarEvento (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Admin_borrarEvento) ENABLED START*/

        IAdminCAD adminCAD = null;
        AdminCEN adminCEN = null;



        try
        {
                SessionInitializeTransaction ();
                adminCAD = new AdminCAD (session);
                adminCEN = new  AdminCEN (adminCAD);



                EventoCAD evento = new EventoCAD (session);
                MapaCAD mapa = new MapaCAD (session);

                System.Collections.Generic.IList<MapaEN> aux;
                aux = mapa.FiltrarPorEvento (p_oid);
                int id_mapa = -1;

                foreach (MapaEN element in aux) {
                        id_mapa = element.Id;
                        mapa.Destroy (id_mapa);
                }


                evento.Destroy (p_oid);



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
