using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerPuntuacion
    {
        public Puntuacion ConvertENToModelUI(PuntuacionEN punten)
        {
            if (punten != null)
            {
                Puntuacion punt = new Puntuacion();
                punt.id = punten.Id;
                punt.Puntos = punten.Puntuacion;
                punt.idUsuario = punten.Usuario.ID;

                if (punten.Reto != null)
                {
                    punt.idReto = punten.Reto.ID;
                    punt.idActividad = punt.idReto;
                    punt.Actividad = punten.Reto.Titulo;
                }
                else if (punten.Evento != null)
                {
                    punt.idEvento = punten.Evento.ID;
                    punt.idActividad = punt.idEvento;
                    punt.Actividad = punten.Evento.Titulo;
                }
                else if (punten.Gymkana != null)
                {
                    punt.idGymkana = punten.Gymkana.ID;
                    punt.idActividad = punt.idGymkana;
                    punt.Actividad = punten.Gymkana.Titulo;
                }

                return punt;
            }
            else
            {
                return null;
            }
        }

        public IList<Puntuacion> ConvertListENToModel(IList<PuntuacionEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {
                IList<Puntuacion> retlist = new List<Puntuacion>();
                foreach (PuntuacionEN reten in ens)
                {
                    retlist.Add(ConvertENToModelUI(reten));
                }
                return retlist;
            }
            else
            {
                return null;
            }
        }
    }
}