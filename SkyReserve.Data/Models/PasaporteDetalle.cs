using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class PasaporteDetalle
    {

        [Key]

        [ForeignKey("Pasaporte")]
        public int PasaporteId { get; set; }
        public Pasaporte? Pasaporte { get; set; }



    }
}
