using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class Destino
    {

        [Key]

        public int DestinoId { get; set; }

        [Required(ErrorMessage = "Favor seleccione un destino.")]
        public string? destino { get; set; }


    }
}
