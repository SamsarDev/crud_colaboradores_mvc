//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCCrud
{
    using System;
    using System.Collections.Generic;
    
    public partial class Colaboradores
    {
        public int ID_Colaborador { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string GradoAcademico { get; set; }
        public string Direccion { get; set; }
        public Nullable<System.DateTime> Fecha_Creacion { get; set; }
        public Nullable<System.DateTime> Fecha_Modificacion { get; set; }
    }
}
