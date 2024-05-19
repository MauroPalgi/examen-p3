using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Laboratorio
    {
        [Key]
        public int Numero { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        public int NumeroCPU { get; set; }

        // Navigation property
        public ICollection<Producto> Productos { get; set; }
    }
}
