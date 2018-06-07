
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CAD.Whatever;
using WhateverGenNHibernate.CEN.Whatever;



/*PROTECTED REGION ID(usingWhateverGenNHibernate.CP.Whatever_Reporte_Reportar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace WhateverGenNHibernate.CP.Whatever
{
public partial class ReporteCP : BasicCP
{
public void Reportar (int id_usuario, int id_gym, int id_reto, string motivo)
{
        /*PROTECTED REGION ID(WhateverGenNHibernate.CP.Whatever_Reporte_Reportar) ENABLED START*/

        IReporteCAD reporteCAD = null;
        ReporteCEN reporteCEN = null;



        try
        {
                SessionInitializeTransaction ();
                reporteCAD = new ReporteCAD (session);
                reporteCEN = new  ReporteCEN (reporteCAD);



                ReporteEN repor = new ReporteEN ();
                ReporteCAD reporcad = new ReporteCAD (session);
                AdminCAD admincad = new AdminCAD (session);
                AdminCEN admincen = new AdminCEN (admincad);
                GymkanaEN gymen = new GymkanaEN ();
                GymkanaCAD gymcad = new GymkanaCAD (session);
                RetoCAD retocad = new RetoCAD (session);
                RetoEN retoen = new RetoEN ();
                UsuarioEN usuen = new UsuarioEN ();
                UsuarioCAD usucad = new UsuarioCAD (session);

                System.Collections.Generic.IList<AdminEN> admin = new System.Collections.Generic.List<AdminEN>();
                System.Collections.Generic.IList<AdminEN> numadmins = new System.Collections.Generic.List<AdminEN>();
                System.Collections.Generic.IList<ReporteEN> listareporte = new System.Collections.Generic.List<ReporteEN>();
                listareporte = reporcad.GetAll (0, 0);
                //int aux = 0;

                foreach (AdminEN element in admin) {
                        numadmins.Add (element);
                }
                admin = admincen.GetAll (0, 0);
                //aux = listareporte [listareporte.Count - 1].ID;

                repor.Admin_reporte = numadmins;
                repor.Motivo = motivo;
                if (id_gym != -1) {
                        gymen = gymcad.GetID (id_gym);
                }
                else{
                        gymen = null;
                }
                repor.Reporte = gymen;
                if (id_reto != -1) {
                        retoen = retocad.GetID (id_reto);
                }
                else{
                        retoen = null;
                }
                repor.Reporte_reto2 = retoen;
                usuen = usucad.GetID (id_usuario);
                repor.Usuario_reporte = usuen;


                reporcad.New_ (repor);


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
