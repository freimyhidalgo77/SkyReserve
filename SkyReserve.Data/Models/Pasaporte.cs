using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyReserve.Data.Models
{
    public class Pasaporte
    {
      
        [Key]

        public int PasaporteId { get; set; }

        [Required(ErrorMessage = "Favor ingrese el pais de residencia.")]
        public string? PaisResidencia { get; set; }

        [Required(ErrorMessage = "Favor ingrese el numero de paaaporte.")]
        public string? NumeroPasaporte  { get; set; }

        [Required(ErrorMessage = "Favor ingrese este dato .")]
        public string? EmitidoPor { get; set; }

        [Required(ErrorMessage = "Favor ingrese la fecha de expiracion.")]
        public DateTime FechaExpiracion { get; set; }

        [Required(ErrorMessage = "Favor introduzca su pais de nacimientro.")]
        public string? PaisNacimiento { get; set; }

        [Required(ErrorMessage = "Favor introdiuzca su ciudad de nacimiento.")]
        public string? CiudadNacimiento { get; set; }

        [ForeignKey("PasaporteId")]
        public ICollection<PasaporteDetalle> PasaporteDetalle { get; set; } = new List<PasaporteDetalle>();



    }
}
