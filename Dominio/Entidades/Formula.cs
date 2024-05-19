using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Formula
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Producto")]
        public int ProductoId { get; set; }

        [Required]
        [ForeignKey("Componente")]
        [MaxLength(100)]
        public string NombreComponente { get; set; }

        public int Cantidad { get; set; }

        [Required]
        [ForeignKey("UnidadMedida")]
        public int IdUnidad { get; set; }

        // Navigation properties
        public Producto Producto { get; set; }
        public Componente Componente { get; set; }
        public UnidadesMedida UnidadMedida { get; set; }
    }
}