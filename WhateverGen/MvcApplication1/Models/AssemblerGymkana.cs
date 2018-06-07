using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CEN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerGymkana
    {
        public Gymkana ConvertENToModelUI(GymkanaEN gymen)
        {
            if (gymen != null)
            {
                AssemblerReporte assR = new AssemblerReporte();
                AssemblerMapa assM = new AssemblerMapa();
                AssemblerComentario assC = new AssemblerComentario();
                AssemblerPaso assP = new AssemblerPaso();
                AssemblerPuntuacion assPu = new AssemblerPuntuacion();
                PuntuacionCEN p = new PuntuacionCEN();
                Gymkana gymkana = new Gymkana();


                gymkana.Titulo = gymen.Titulo;
                gymkana.Descripcion = gymen.Descripcion;
                gymkana.Fecha = gymen.Fecha;
                gymkana.Precio = gymen.Precio;
                gymkana.Creador = gymen.Usuario.Nombre;

                //Puntuaciones
                gymkana.Puntuaciones = null;
                if (gymen.Puntuacion != null)
                {
                    gymkana.Puntuaciones = assPu.ConvertListENToModel(gymen.Puntuacion);
                }

                //comentarios
                gymkana.Comentarios = null;
                if (gymen.Comentario != null)
                    gymkana.Comentarios = assC.ConvertListENToModel(gymen.Comentario);

                //numero de pasos
                gymkana.Numeropasos = gymen.NumPasos;


                //pasos
                gymkana.Pasos = null;
                if (gymen.Paso != null)
                    gymkana.Pasos = assP.ConvertListENToModel(gymen.Paso);



                //atributos ocultos
                gymkana.id = gymen.ID;
                gymkana.usuario = gymen.Usuario;

                //reportes
                gymkana.Reportes = null;
                if (gymen.Reporte != null)
                    gymkana.Reportes = assR.ConvertListENToModel(gymen.Reporte);

                return gymkana;
            }
            else
            {
                return null;
            }


        }
        public IList<Gymkana> ConvertListENToModel(IList<GymkanaEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {
                IList<Gymkana> gymlist = new List<Gymkana>();
                foreach (GymkanaEN gymen in ens)
                {
                    gymlist.Add(ConvertENToModelUI(gymen));
                }
                return gymlist;
            }
            else
            {
                return null;
            }
        }

    }
}
