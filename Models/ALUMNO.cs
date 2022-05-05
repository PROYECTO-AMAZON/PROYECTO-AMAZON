using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROYECTO_AMAZON{
    public class ALUMNO{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage = "Ingrese su nombre")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Ingrese su apellido paterno")]
        [Display(Name = "Apellido Paterno")]
        public string apePat { get; set; }
        [Required(ErrorMessage = "Ingrese su apellido materno")]
        [Display(Name = "Apellido Materno")]
        public string apeMat { get; set; }
        [Required(ErrorMessage = "Ingrese su fecha de nacimiento")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateOnly fechaNac { get; set; }
        [Required(ErrorMessage = "Ingrese su N° de DNI")]
        [Display(Name = "DNI")]
        public string dni { get; set; }
        [Required(ErrorMessage = "Ingrese su género")]
        [Display(Name = "Género")]
        public char genero { get; set; }
        [Required(ErrorMessage = "Ingrese su N° de celular")]
        [Display(Name = "Celular")]
        public string celular { get; set; }
        [Required(ErrorMessage = "Ingrese su departamento de residencia")]
        [Display(Name = "Departamento")]
        public string departamento { get; set; }
        [Required(ErrorMessage = "Ingrese su provincia de residencia")]
        [Display(Name = "Provincia")]
        public string provincia { get; set; }
        [Required(ErrorMessage = "Ingrese su distrito de residencia")]
        [Display(Name = "Distrito")]
        public string distrito { get; set; }
        [Required(ErrorMessage = "Ingrese su email")]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Ingrese su contraseña")]
        [Display(Name = "Contraseña")]
        public string contrasena { get; set; }
    }
}