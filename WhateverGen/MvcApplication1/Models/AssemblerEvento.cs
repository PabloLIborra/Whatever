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
    public class AssemblerEvento
    {
        public Evento ConvertENToModelUI(EventoEN even)
        {
            if (even != null)
            {
                AssemblerReporte assR = new AssemblerReporte();
                AssemblerMapa assM = new AssemblerMapa();
                AssemblerComentario assC = new AssemblerComentario();
                AssemblerPuntuacion assP = new AssemblerPuntuacion();
                PuntuacionCEN p = new PuntuacionCEN();
                Evento evento = new Evento();
                evento.Titulo = even.Titulo;
                evento.Descripcion = even.Descripcion;
                evento.Fecha = even.Fecha;
                evento.Precio = even.Precio;
                evento.Creador = even.Usuario.Nombre;
                


                //puntuacion

                evento.Puntuaciones = null;
                if (even.Puntuacion != null)
                {
                    evento.Puntuaciones = assP.ConvertListENToModel(even.Puntuacion);
                }
                //mapa
                evento.Mapa = null;
                if (even.Mapa != null) {
                    evento.Latitud = even.Mapa.Latitud;
                    evento.Longitud = even.Mapa.Longitud;
                    evento.Zoom = even.Mapa.Zoom;
                    evento.Mapa = assM.ConvertENToModelUI(even.Mapa);
                    }
                //comentarios
                evento.Comentarios = null;
                if (even.Comentario != null)
                    evento.Comentarios = assC.ConvertListENToModel(even.Comentario);

                //atributos ocultos
                evento.id = even.ID;
                evento.usuario = even.Usuario;

                //reportes
                evento.Reportes = null;
                if (even.Reporte != null)
                    evento.Reportes = assR.ConvertListENToModel(even.Reporte);

                return evento;
            }
            else
            {
                return null;
            }
        }
        public IList<Evento> ConvertListENToModel(IList<EventoEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {
                IList<Evento> evlist = new List<Evento>();
                foreach (EventoEN even in ens)
                {
                    evlist.Add(ConvertENToModelUI(even));
                }
                return evlist;
            }
            else
            {
                return null;
            }
        }

    }
}