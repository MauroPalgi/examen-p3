using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Dominio.Entidades
{
    class DireccionTecnica
    {
        [Key]
        public int NumeroCPU { get; set; }
        public int LaboratorioNumero { get; set; }
        public Laboratorio Laboratorio { get; }

    }
}
