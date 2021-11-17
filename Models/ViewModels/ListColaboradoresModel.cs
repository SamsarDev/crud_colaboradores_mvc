using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCCrud.Models
{
    public class ListColaboradoresModel
    {
        [Key]
        public int ID_Colaborador { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string GradoAcademico { get; set; }
        public string Direccion { get; set; }

    }
}