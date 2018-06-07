
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


/*PROTECTED REGION ID(usingWhateverGenNHibernate.CEN.Whatever_Usuario_BorrarUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CEN.Whatever
{
public partial class UsuarioCEN
{
public void BorrarUsuario (int p_oid)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CEN.Whatever_Usuario_BorrarUsuario) ENABLED START*/

        // Write here your custom code...

        UsuarioCAD usu = new UsuarioCAD ();
        EventoCAD eve = new EventoCAD ();
        EventoCEN evec = new EventoCEN ();
        RetoCAD ret = new RetoCAD ();
        RetoCEN retc = new RetoCEN ();
        PuntuacionCAD pun = new PuntuacionCAD ();
        ReporteCAD rep = new ReporteCAD ();
        ComentarioCAD com = new ComentarioCAD ();

        System.Collections.Generic.IList<EventoEN> eventos;
        System.Collections.Generic.IList<RetoEN> retos;
        System.Collections.Generic.IList<PuntuacionEN> puntuaciones;
        System.Collections.Generic.IList<ReporteEN> reportes;
        System.Collections.Generic.IList<ComentarioEN> comentarios;

        usu.Destroy (p_oid);

        eventos = eve.FiltrarPorUsuario (p_oid);
        foreach (EventoEN element in eventos) {
                evec.BorrarEvento (element.ID);
        }

        retos = ret.FiltrarPorUsuario (p_oid);
        foreach (RetoEN element in retos) {
                retc.BorrarReto (element.ID);
        }

        puntuaciones = pun.FiltrarPorUsuario (p_oid);
        foreach (PuntuacionEN element in puntuaciones) {
                pun.Destroy (element.Id);
        }

        reportes = rep.FiltrarPorUsuario (p_oid);
        foreach (ReporteEN element in reportes) {
                rep.Destroy (element.ID);
        }

        comentarios = com.FiltrarPorUsuario (p_oid);
        foreach (ComentarioEN element in comentarios) {
                rep.Destroy (element.ID);
        }

        /*PROTECTED REGION END*/
}
}
}
