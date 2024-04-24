using System.ComponentModel.DataAnnotations;

namespace RaulCruz_PruebaProgreso1.Models
{
    public class RC_Tabla1
    {
        public int RCId { get; set; }

        [Required]
        public string? RCName { get; set; }

        [Range(0.01, 9999.99)]
        public decimal RCValor { get; set; }
        public DateTime RCFechaInicio { get; set; }
        public bool RCBoleano { get; set; }
    }
}
