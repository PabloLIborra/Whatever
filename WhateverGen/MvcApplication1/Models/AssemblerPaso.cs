using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerPaso
    {
        public Paso ConvertENToModelUI(PasoEN pasen)
        {
            if (pasen != null)
            {

                AssemblerMapa assM = new AssemblerMapa();
                Paso paso = new Paso();
                paso.Numero = pasen.Gymkana.NumPasos;
                paso.Descripcion = pasen.Descripcion;

                //atributos ocultos
                paso.Mapa = null;
                if (pasen.Mapa != null)
                {
                    paso.Latitud = pasen.Mapa.Latitud;
                    paso.Longitud = pasen.Mapa.Longitud;
                    paso.Zoom = pasen.Mapa.Zoom;
                    paso.Mapa = assM.ConvertENToModelUI(pasen.Mapa);
                } 
                paso.idGymkana = pasen.Gymkana.ID;
                paso.id = pasen.ID;

                return paso;
            }
            else
            {
                return null;
            }

        }
        public IList<Paso> ConvertListENToModel(IList<PasoEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {
                IList<Paso> paslist = new List<Paso>();
                foreach (PasoEN pasen in ens)
                {
                    paslist.Add(ConvertENToModelUI(pasen));
                }
                return paslist;
            }
            else
            {
                return null;
            }
        }

    }
}
