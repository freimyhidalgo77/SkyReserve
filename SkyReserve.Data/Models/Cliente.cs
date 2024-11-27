using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class Cliente
    {
        [Key]

        public int ClienetId { get; set; }

        [Required(ErrorMessage = "Favor introdiuzca un nombre.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Favor introdiuzca un apellido .")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "Favor seleccione una clase de vuelo.")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Favor seleccione una clase de vuelo.")]
        public string? Genero { get; set; }

        [Required(ErrorMessage = "Favor seleccione una clase de vuelo.")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "Favor seleccione una clase de vuelo.")]
        public string? Accesibilidad { get; set; }

        [Required(ErrorMessage = "Favor seleccione una clase de vuelo.")]
        public string? Email { get; set; }


    }
}
