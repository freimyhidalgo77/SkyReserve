using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class Origen
    {

        [Key] 
        public int OrigenId { get; set; }

        [Required(ErrorMessage = "Favor ingrese un origen.")]
        public string? origen { get; set; }

    }
}
