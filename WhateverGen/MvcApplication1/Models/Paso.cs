using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WhateverGenNHibernate.EN.Whatever;


namespace MvcApplication1.Models
{
    public class Paso
    {

        /*
        private string descripcion;
        private WhateverGenNHibernate.EN.Whatever.GymkanaEN gymkana_paso2;
        private WhateverGenNHibernate.EN.Whatever.MapaEN paso;
        private int iD;
        */
        //public void AnadirPaso (int id_gym, string descripcion, int latitud, int longitud, int zoom)

        
        //numero del paso
        [Display(Prompt = "Numero", Description = "Nuemro del paso", Name = "Numero")]
        public int Numero { get; set; }

        //id Gymkana
        [Display(Prompt = "Id Gymkana", Description = "Id de la Gymkana", Name = "IdGymkana")]
        public int idGymkana { get; set; }
        
        //private string descripcion;
        [Display(Prompt = "Descripción del paso", Description = "Descripción del paso", Name = "Descripcion")]
        [Required(ErrorMessage = "Debe indicar una descripción para el paso")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }

        //Latitud
        [Display(Prompt = "Latitud del evento", Description = "Latitud del evento", Name = "Latitud")]
        [Required(ErrorMessage = "Debe indicar una latitud para el evento")]
        //[DataType(DataType.Custom, ErrorMessage = "La latitud debe ser numerica")]
        [Range(-90.00000000, 90.00000000, ErrorMessage = "El valor de {0} tiene que ser correcto e ir entre {1} y {2}")]
        public string Latitud { get; set; }

        //Longitud
        [Display(Prompt = "Longitud del evento", Description = "Longitud del evento", Name = "Longitud")]
        [Required(ErrorMessage = "Debe indicar una longitud para el evento")]
        //[DataType(DataType.Currency, ErrorMessage = "La longitud debe ser numerica")]
        [Range(-180.00000000, 180.00000000, ErrorMessage = "El valor de {0} tiene que ser correcto e ir entre {1} y {2}")]
        public string Longitud { get; set; }

        //Zoom
        [Display(Prompt = "Zoom para el mapa", Description = "Zoom para el mapa", Name = "Zoom")]
        [Required(ErrorMessage = "Debe indicar un zoom para el mapa")]
        [Range(minimum: 2, maximum: 20, ErrorMessage = "El zoom debe ser mayor que 2 y menor de 20")]
        public int Zoom { get; set; }

        //private WhateverGenNHibernate.EN.Whatever.MapaEN paso;
        [Display(Prompt = "Mapa del paso", Description = "Mapa del paso", Name = "Mapa ")]
        public Mapa Mapa{ get; set; }

        //private int iD;
        [ScaffoldColumn(false)]
        public int id { get; set; }




    }
}