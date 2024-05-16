using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleInventario.Models
{
    public class Entradas
    {
        [Key]
        public int EntradasId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int FKProductosId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal Cantidad { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal TotalImporte { get; set; }

        [ForeignKey(nameof(FKProductosId))]
        public virtual Productos Productos { get; set; }

    }
}
