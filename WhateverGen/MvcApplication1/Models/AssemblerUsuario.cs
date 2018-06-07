using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;
using WhateverGenNHibernate.CP.Whatever;
using WhateverGenNHibernate.CEN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerUsuario {

        public Usuario ConvertENToModelUI(UsuarioEN en)
        {
            if (en != null)
            {
                AssemblerReto assR = new AssemblerReto();
                AssemblerReporte assRep = new AssemblerReporte();
                AssemblerEvento assE = new AssemblerEvento();
                AssemblerComentario assC = new AssemblerComentario();
                AssemblerPuntuacion assPu = new AssemblerPuntuacion();
                AssemblerPaso assP = new AssemblerPaso();

                PuntuacionCEN p = new PuntuacionCEN();
                Usuario usu = new Usuario();
                usu.id = en.ID;
                usu.Nombre = en.Nombre;
                usu.Edad = en.Edad;
                usu.Contrasena = en.Contrasena;
                usu.Email = en.Email;
                usu.Foto = en.Foto;
                usu.Facebook = en.Facebook;
                usu.Twitter = en.Twitter;
                usu.Instagram = en.Instagram;
                usu.sexo = en.Sexo;

                usu.reto = en.Reto;
                usu.evento = en.Evento;
                usu.reporte = en.Reporte;
                usu.puntuacion = en.Puntuacion;


                usu.Retos = null;
                if (en.Reto != null)
                    usu.Retos = assR.ConvertListENToModel(en.Reto);

                usu.Eventos = null;
                if (en.Evento != null)
                    usu.Eventos = assE.ConvertListENToModel(en.Evento);

                usu.Puntuaciones = null;
                if (en.Puntuacion != null)
                    usu.Puntuaciones = assPu.ConvertListENToModel(en.Puntuacion);

                usu.Reportes = null;
                if (en.Reporte != null)
                    usu.Reportes = assRep.ConvertListENToModel(en.Reporte);

                usu.Comentarios = null;
                if (en.Comentario != null)
                    usu.Comentarios = assC.ConvertListENToModel(en.Comentario);

                return usu;
            }
            else
            {
                return null;
            }
        }
        public IList<Usuario> ConvertListENToModel(IList<UsuarioEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {

                IList<Usuario> usu = new List<Usuario>();
                foreach (UsuarioEN en in ens)
                {
                    usu.Add(ConvertENToModelUI(en));
                }
                return usu;
            }
            else
            {
                return null;
            }
        }

    }
}