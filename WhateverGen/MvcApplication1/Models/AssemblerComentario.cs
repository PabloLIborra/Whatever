using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class AssemblerComentario
    {
        public Comentario ConvertENToModelUI(ComentarioEN comen)
        {
            if (comen != null)
            {
                Comentario comentario = new Comentario();
                comentario.id = comen.ID;
                comentario.Creador = comen.Creador;
                comentario.Texto = comen.Texto;
                comentario.usuario = comen.Usuario;

                if (comen.Evento != null)
                {
                    comentario.idEvento = comen.Evento.ID;
                }
                else if (comen.Reto != null)
                {
                    comentario.idReto = comen.Reto.ID;
                }
                else if (comen.Gymkana != null)
                {
                    comentario.idGymkana = comen.Gymkana.ID;
                }

                return comentario;
            }
            else
            {
                return null;
            }

        }
        public IList<Comentario> ConvertListENToModel(IList<ComentarioEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {
                IList<Comentario> comlist = new List<Comentario>();
                foreach (ComentarioEN comen in ens)
                {
                    comlist.Add(ConvertENToModelUI(comen));
                }
                return comlist;
            }
            else
            {
                return null;
            }
        }

    }
}
