using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Estudiante
    {
        [Key]
        public Int64 id_estudiante { get; set; }
        [Required]
        public string nombre_estudiante { get; set; }
        [Required]
        public string correo_estudiante { get; set; }
    }
}
