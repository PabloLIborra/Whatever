using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Puntuacion
    {
        //public void CrearPuntuacionParaReto (int id_reto, int puntuacion)
        //public void CrearPuntuacionParaEvento (int id_evento, int puntuacion)

        //public int id;
        [ScaffoldColumn(false)]
        public int id{ get; set; }

        [ScaffoldColumn(false)]
        public int idGymkana { get; set; }

        //public WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario;
        [ScaffoldColumn(false)]
        public int idUsuario { get; set; }

        //public WhateverGenNHibernate.EN.Whatever.RetoEN reto;
        [ScaffoldColumn(false)]
        public int idReto { get; set; }

        //public WhateverGenNHibernate.EN.Whatever.EventoEN evento;
        [ScaffoldColumn(false)]
        public int idEvento { get; set; }

        [ScaffoldColumn(false)]
        public int idActividad { get; set; }

        //Nombre que se mostrara al lado del numero
        [Display(Prompt = "Actividad", Description = "Actividad puntuada")]
        [Required(ErrorMessage = "Debe indicar una actividad puntuada")]
        public string Actividad { get; set; }

        //public int puntuacion;
        [Display(Prompt = "Puntuacion", Description = "Puntuacion", Name = "Puntuacion")]
        [Required(ErrorMessage="Debe añadir una puntuación")]
        [Range(0, 5, ErrorMessage = "El valor de {0} tiene que ser correcto e ir entre {1} y {2}")]
        public int Puntos { get; set; }
    }
}