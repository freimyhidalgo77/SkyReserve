using BlazorBootstrap;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class Reserva
    {
        [Key] 
        
        public int ReservaId { get; set; }

        [ForeignKey("Origen")]
        public int OrigenId { get; set; }
        public Origen? Origen { get; set; }


        [ForeignKey("Destino")]
        public int DestinoId { get; set; }
        public Destino? Destino { get; set; }

        public int NumeroPasajeros { get; set; }

        [ForeignKey("AsientoId")]

        public ICollection<Asiento> AsientoDetalle { get; set; } = new List<Asiento>();


    }
}
