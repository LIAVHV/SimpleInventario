using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleInventario.Models
{
    public class Unidades
    {
        [Key]
        public int UnidadesId { get; set; }

        [Index(IsUnique = true)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "La {0} excede los caracteres permitidos de {1} ")]
        public string Unidad { get; set; }
    }
}
