using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Profesores
    {
        [Key]
        public Int64 id_profesor { get; set; }
        [Required]
        public string nombre_profesor { get; set; }
        [Required]
        public string materia_profesor { get; set; }
    }
}
