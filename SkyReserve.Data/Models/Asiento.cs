using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class Asiento
    {
        [Key]

        public int AsientoId { get; set; }

        [ForeignKey("Reserva")]
        public int ReservaId { get; set; }
        public Reserva? Reserva { get; set; }

        [Required(ErrorMessage = "Favor elija una fila .")]
        public string? Fila {  get; set; }
        public string? Letra { get; set; }
        public int Existencia { get; set; }

               

    }
}
