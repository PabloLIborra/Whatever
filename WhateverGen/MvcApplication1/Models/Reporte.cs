using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Reporte
    {

        //public void ReportarEvento (int id_usuario, int id_evento, string motivo)
        //public void ReportarReto (int id_usuario, int id_reto, string motivo)

        //private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario_reporte;
        [Display(Prompt = "Usuario del reporte", Description = "Usuario del reporte", Name = "Usuario")]
        public UsuarioEN Usuario { get; set; }

        //private string motivo;
        [Display(Prompt = "Motivo del reporte", Description = "Motivo del reporte", Name = "Motivo")]
        [Required(ErrorMessage = "Debe indicar un motivo para el reporte")]
        [StringLength(maximumLength: 200, ErrorMessage = "El motivo no puede tener más de 200 caracteres")]
        public string Motivo { get; set; }

        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario;
        [ScaffoldColumn(false)]
        public int idUsuario { get; set; }
               
        //private WhateverGenNHibernate.EN.Whatever.RetoEN reto;
        [ScaffoldColumn(false)]
        public int idReto { get; set; }

        //private WhateverGenNHibernate.EN.Whatever.EventoEN evento;
        [ScaffoldColumn(false)]
        public int idEvento { get; set; }

        //id gymkana
        [ScaffoldColumn(false)]
        public int idGymkana { get; set; }

    }
}