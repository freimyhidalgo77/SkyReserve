using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class Accesibilidad
    {

        [Key] 
        public int AccesibilidadId { get; set; }

        [Required(ErrorMessage = "Favor ingrese una descripcion.")]
        public string? Descripcion { get; set; }

    }
}
