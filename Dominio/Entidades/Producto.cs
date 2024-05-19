using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{

    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        public bool Exportable { get; set; }

        public decimal PrecioVenta { get; set; }

        public int LaboratorioNumero { get; set; }

        // Navigation properties
        public Laboratorio Laboratorio { get; set; }
        public ICollection<Formula> Formulas { get; set; }
    }
}