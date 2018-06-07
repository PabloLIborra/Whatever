
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Usuario_BorrarUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class UsuarioCP : BasicCP
{
public void BorrarUsuario (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Usuario_BorrarUsuario) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;



        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new  UsuarioCEN (usuarioCAD);


                EventoCAD eve = new EventoCAD (session);
                EventoCP evec = new EventoCP (session);
                RetoCAD ret = new RetoCAD (session);
                RetoCP retc = new RetoCP (session);
                GymkanaCAD gym = new GymkanaCAD (session);
                GymkanaCP gymc = new GymkanaCP (session);

                System.Collections.Generic.IList<EventoEN> eventos;
                System.Collections.Generic.IList<RetoEN> retos;
                System.Collections.Generic.IList<GymkanaEN> gymkanas;


                eventos = eve.FiltrarEventoPorUsuario (p_oid);
                foreach (EventoEN element in eventos) {
                        evec.BorrarEvento (element.ID);
                }

                retos = ret.FiltrarRetoPorUsuario (p_oid);
                foreach (RetoEN element in retos) {
                        retc.BorrarReto (element.ID);
                }

                gymkanas = gym.FiltrarGymkanaPorUsuario (p_oid);
                foreach (GymkanaEN element in gymkanas) {
                        gymc.BorrarGymkana (element.ID);
                }


                usuarioCAD.Destroy (p_oid);

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
