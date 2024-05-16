using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleInventario.Models
{
    public class Productos
    {
        [Key]
        public int ProductosId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Index(IsUnique = true)]
        [MaxLength(300, ErrorMessage = "La {0} excede los caracteres permitidos de {1} ")]
        public string Nombre { get; set; }

        [DisplayName("Unidad de Medida")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int FkUnidadesId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(0, 9999999, ErrorMessage = "{0} no admite valores negativos, el valor mínimo es {1}, maximo{2}")]
        public decimal Precio { get; set; }

        [Range(0, 9999999, ErrorMessage = "{0} no admite valores negativos, el valor mínimo es {1}, maximo{2}")]
        public decimal Existencia { get; set; }

        [ForeignKey(nameof(FkUnidadesId))]
        public virtual Unidades Unidades { get; set; }

    }
}
