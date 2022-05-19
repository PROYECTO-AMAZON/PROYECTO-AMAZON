using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROYECTO_AMAZON{


    public class CARRERA{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required(ErrorMessage = "Ingrese la fecha de la carrera")]
        [Display(Name = "Fecha de la Carrera")]
        public string fecCarrera { get; set; }

        public string semana { get; set; }

        [Required(ErrorMessage = "Ingrese su distancia recorrida en metros")]
        [Display(Name = "Distancia (en m)")]
        public double distancia { get; set; }

        [Required(ErrorMessage = "Ingrese su tiempo de carrera en segundos")]
        [Display(Name = "Tiempo (en s)")]
        public double tiempo { get; set; }

        
        public string nombre_particpante { get; set; }

        
        // public string ape_particpante { get; set; }
    }
}