using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCCrud.Models
{
    public class ColaboradorModel
    {
        [Key]
        public int ID_Colaborador { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Estado Civil")] 
        public string EstadoCivil { get; set; }
        [Display(Name = "Grado Académico")]
        public string GradoAcademico { get; set; }
        public string Direccion { get; set; }

    }
}