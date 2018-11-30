using System.ComponentModel.DataAnnotations;

namespace Aplicacion.Core
{
    public class CasaDTO
    {
        
        public int ID { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required, StringLength(300)]
        public string Calle { get; set; }

        [Required]
        public int NumeroHabitaciones { get; set; }

        [Required]
        public int NumeroBaños { get; set; }

        [Required]
        public int Pisos { get; set; }

        [Required]
        public decimal MetrosCuadrados { get; set; }
    }
}
