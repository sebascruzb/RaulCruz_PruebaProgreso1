using System.ComponentModel.DataAnnotations;

namespace RaulCruz_PruebaProgreso1.Models
{
    public class RC_Tabla1
    {
        [Key]
        public int RCId { get; set; }

        [Required]
        public string? RCNombre { get; set; }

        [Range(0.01, 9999.99)]
        public decimal RCValor { get; set; }
        public DateTime RCFechaInicio { get; set; }
        public bool RCBoleano { get; set; }
    }
}
