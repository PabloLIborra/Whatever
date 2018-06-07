using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Comentario
    {
        /*    
        COMENTARIO EN
        private string texto;
        private string creador;
        private int iD;
        private WhateverGenNHibernate.EN.Whatever.UsuarioEN comentario_usuario;
        private WhateverGenNHibernate.EN.Whatever.EventoEN comentario_evento2;
        private WhateverGenNHibernate.EN.Whatever.RetoEN comentario_reto;
        
        public void CrearComentarioParaEvento (ComentarioEN comentario, int id_evento)
        public void CrearComentarioParaReto (ComentarioEN comentario, int id_reto) 
        
         */

        //private string creador;
        [Display(Prompt = "Creador del comentario", Description = "Creador del comentario", Name = "Creador")]
        [Required(ErrorMessage = "Debe indicar un creador para el comentario")]
        [StringLength(maximumLength: 40, ErrorMessage = "El nombre no puede tener más de 40 caracteres")]
        public string Creador { get; set; }

        //private string nombre;
        [Display(Prompt = "Texto del comentario", Description = "Texto del comentario", Name = "Texto")]
        [Required(ErrorMessage = "Debe indicar un texto para el comentario")]
        [StringLength(maximumLength: 300, ErrorMessage = "El texto no puede tener más de 300 caracteres")]
        public string Texto { get; set; }
       
        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [ScaffoldColumn(false)]
        public int idGymkana { get; set; }

        //private WhateverGenNHibernate.EN.Whatever.UsuarioEN usuario;
        [Required(ErrorMessage = "Debe indicar un creador para el comentario")]
        public UsuarioEN usuario;

        //private WhateverGenNHibernate.EN.Whatever.EventoEN evento;
        [ScaffoldColumn(false)]
        public int idEvento;

        //private WhateverGenNHibernate.EN.Whatever.RetoEN reto;
        [ScaffoldColumn(false)]
        public int idReto;

    }
}

