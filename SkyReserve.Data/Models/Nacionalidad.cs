using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class Nacionalidad
    {
        [Key]

        public int NacionalidadId { get; set; }

        [Required(ErrorMessage = "Favor de seleccionar un pais.")]
        public string? Pais { get; set; }



    }
}
