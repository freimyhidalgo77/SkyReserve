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


        public string Fila

        public string Letra

        public string Existencia

               public string Fila








    }
}
