using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class ClaseVuelo
    {

        [Key] 
        public int ClaseVueloId { get; set; }

        [Required(ErrorMessage = "Favor ingrese una clase de vuelo.")]
        public string? descripcionClase { get; set; }
    }
}
