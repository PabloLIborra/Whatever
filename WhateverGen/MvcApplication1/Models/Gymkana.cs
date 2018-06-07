using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;

namespace MvcApplication1.Models
{
    public class Gymkana
    {
        /*
        private string titulo;
        private string descripcion;
        private Nullable<DateTime> fecha;
        private int precio;
        private UsuarioEN usuario;
        private IList<PuntuacionEN> puntuaciones;
        private IList<MapaEN> evento_mapa;
        private IList<ComentarioEN> comentario;
        private int numPasos;
        private IList<PasoEN> gymkana_paso;

        private int iD;
        private UsuarioEN usuario;
        private IList<ReporteEN> reporte;
        */

        //public void CrearGymkana (WhateverGenNHibernate.EN.Whatever.GymkanaEN gym, double lat, double lon, int zoom)

        //Titulo
        [Display(Prompt = "Titulo de la gymkana", Description = "Titulo de la gymkana", Name = "Titulo")]
        [Required(ErrorMessage = "Debe indicar un titulo para la gymkana")]
        [StringLength(maximumLength: 100, ErrorMessage = "El titulo no puede tener más de 100 caracteres")]
        public string Titulo { get; set; }

        //Descripcion
        [Display(Prompt = "Descripción de la gymkana", Description = "Descripción de la gymkana", Name = "Descripcion")]
        [Required(ErrorMessage = "Debe indicar una descripción para la gymkana")]
        [StringLength(maximumLength: 200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }

        //Fecha
        [Display(Prompt = "Fecha de la gymkana", Description = "Fecha de la gymkana", Name = "Fecha")]
        [DataType(DataType.Date, ErrorMessage = "La fecha debe ser valida")]
        [Required(ErrorMessage = "Debe indicar una fecha para el evento")]
        public Nullable<DateTime> Fecha { get; set; }

        //Precio
        [Display(Prompt = "Precio de la gymkana", Description = "Precio de la gymkana", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar un precio para el evento")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0.0, maximum: 10000.0, ErrorMessage = "El precio debe ser mayor que cero y menor de 10000")]
        public double Precio { get; set; }

        //Creador
        [Display(Prompt = "Creador", Description = "Nombre del creador de la gymkana", Name = "Creador")]
        public string Creador { get; set; }

        //Latitud
        [Display(Prompt = "Latitud del primer paso", Description = "Latitud del primer paso", Name = "Latitud")]
        [Required(ErrorMessage = "Debe indicar una latitud para el primer paso")]
        //[DataType(DataType.Custom, ErrorMessage = "La latitud debe ser numerica")]
        [Range(-90.00000000, 90.00000000, ErrorMessage = "El valor de {0} tiene que ser correcto e ir entre {1} y {2}")]
        public string Latitud { get; set; }

        //Longitud
        [Display(Prompt = "Longitud del primer paso", Description = "Longitud del primer paso", Name = "Longitud")]
        [Required(ErrorMessage = "Debe indicar una longitud para el primer paso")]
        //[DataType(DataType.Currency, ErrorMessage = "La longitud debe ser numerica")]
        [Range(-180.00000000, 180.00000000, ErrorMessage = "El valor de {0} tiene que ser correcto e ir entre {1} y {2}")]
        public string Longitud { get; set; }

        //Zoom
        [Display(Prompt = "Zoom para el mapa", Description = "Zoom para el mapa", Name = "Zoom")]
        [Required(ErrorMessage = "Debe indicar un zoom para el mapa")]
        [Range(minimum: 2, maximum: 20, ErrorMessage = "El zoom debe ser mayor que 2 y menor de 20")]
        public int Zoom { get; set; }

        //private IList<PuntuacionEN> puntuaciones;
        [Display(Prompt = "Puntuacion", Description = "Puntuacion de la gymkana", Name = "Puntuaciones")]
        public IList<Puntuacion> Puntuaciones { get; set; }

        //private IList<ComentarioEN> comentario;
        [Display(Prompt = "Comentarios", Description = "Comentarios de la gymkana", Name = "Comentario")]
        public IList<Comentario> Comentarios { get; set; }

        //numero de pasos
        [Display(Prompt = "Numero de pasos", Description = "Numero de los pasos de la gymkana", Name = "Numeropasos")]
        public int Numeropasos { get; set; }

        //Paso
        [Display(Prompt = "Pasos", Description = "Pasos de la gymkana", Name = "Pasos")]
        public IList<Paso> Pasos { get; set; }
        
        //private IList<ReporteEN> reporte;
        [Display(Prompt = "Reportes", Description = "Reportes de la gymkana", Name = "Reportes")]
        public IList<Reporte> Reportes { get; set; }
        
        

        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }
        
        //private UsuarioEN usuario;
        [ScaffoldColumn(false)]
        public UsuarioEN usuario { get; set; }

        [ScaffoldColumn(false)]
        public int ultimoPaso { get; set; }
    }
}