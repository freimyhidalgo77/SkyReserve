using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class VuelosEspeciales
    {

        [Key]

        public int VuelosEspecialesId { get; set; }

        [ForeignKey("Origen")]
        public int OrigenId { get; set; }
        public Origen? Origen { get; set; }


        [ForeignKey("Destino")]
        public int DestinoId { get; set; }
        public Destino? Destino { get; set; }


        public DateTime FechaIda { get; set; }


    }

}
