using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class UnidadesMedida
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        // Navigation property
        public ICollection<Formula>? Formulas { get; set; }
    }
}