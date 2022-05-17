using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROYECTO_AMAZON{


    public class CARRERA{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string semana { get; set; }
        [Required(ErrorMessage = "Ingrese su distancia recorrida en metros")]
        [Display(Name = "Distancia (en m)")]
        public double distancia { get; set; }
        [Required(ErrorMessage = "Ingrese su tiempo de carrera en segundos")]
        [Display(Name = "Tiempo (en s)")]
        public double tiempo { get; set; }
        [Required(ErrorMessage = "Ingrese su ritmo")]
        [Display(Name = "Tiempo (en s)")]
        public int idAlumno { get; set; }
    }
}