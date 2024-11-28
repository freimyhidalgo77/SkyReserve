using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class Hora
    {
        [Key]
        public int HoraID { get; set; }

        [Required(ErrorMessage = "Favor seleccione una hora de viaje.")]
        public double horaViaje {  get; set; }   //Lapso de horas disponibles en las que el cliente puede viajar

    }
}
