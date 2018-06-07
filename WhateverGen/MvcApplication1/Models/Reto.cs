using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;


namespace MvcApplication1.Models
{
    public class Reto
    {
        /*
         * public void CrearReto (WhateverGenNHibernate.EN.Whatever.RetoEN reto)
         * 
         * 
         * RetoEN
        private string titulo;
        private string descripcion;
        private string tipo;
        private int precio;
        private string imagen;
        private int iD;
        private UsuarioEN usuario;
        private IList<PuntuacionEN> puntuacion;
        private IList<ComentarioEN> comentario;
        private IList<ReporteEN> reporte;
        */

        //private string titulo;
        [Display(Prompt = "Título del reto", Description = "Título del reto", Name = "Titulo")]
        [Required(ErrorMessage = "Debe indicar un titulo para el reto")]
        [StringLength(maximumLength: 200, ErrorMessage = "El titulo no puede tener más de 200 caracteres")]
        public string Titulo { get; set; }

        //private string descripcion;
        [Display(Prompt = "Descripción del reto", Description = "Descripción del reto", Name = "Descripcion")]
        [Required(ErrorMessage = "Debe indicar una descripción para el reto")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }

        //private string tipo;
        [Display(Prompt = "Tipo del reto", Description = "Tipo del reto", Name = "Tipo")]
        [Required(ErrorMessage = "Debe indicar un tipo del reto")]
        [StringLength(maximumLength: 200, ErrorMessage = "El tipo no puede tener más de 200 caracteres")]
        public string Tipo { get; set; }

        //private int precio;
        [Display(Prompt = "Precio del reto", Description = "Precio del reto", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar un precio para el reto")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El precio debe ser mayor que cero y menor de 10000")]
        public double Precio { get; set; }

        //private string imagen;
        [Display(Prompt = "Imagen del reto", Description = "Unidades del reto", Name = "Imagen")]
        [Required(ErrorMessage = "Debe indicar una imagen del reto")]
        public string Imagen { get; set; }

        //Nombre del creador del reto;
        [Display(Prompt = "Creador", Description = "Nombre del creador", Name = "Creador")]
        public string Creador{ get; set; }

        //private IList<PuntuacionEN> puntuacion(LO QUE SE MUESTRA);
        [Display(Prompt = "Puntuacion", Description = "Puntuacion del reto", Name = "Puntuaciones")]
        public IList<Puntuacion> Puntuaciones { get; set; }

        //private IList<ComentarioEN> comentario;       
        [Display(Prompt = "Comentarios", Description = "Comentarios del reto", Name = "Comentarios")]
        public IList<Comentario> Comentarios { get; set; }

        //private IList<ReporteEN> reporte;
        [Display(Prompt = "Reportes", Description = "Reportes del reto", Name = "Reportes")]
        public IList<Reporte> Reportes { get; set; }


        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private UsuarioEN usuario;
        [ScaffoldColumn(false)]
        public UsuarioEN usuario { get; set; }
        
       


        
    }
}
