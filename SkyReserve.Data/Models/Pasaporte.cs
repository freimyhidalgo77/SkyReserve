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

        public string? PaisResidencia { get; set; }

        public string? NumeroPasaporte  { get; set; }

        public string? EmitidoPor { get; set; }

        public DateTime FechaExpiracion { get; set; }

        public string? PaisNacimiento { get; set; }

        public string? CiudadNacimiento { get; set; }

        [ForeignKey("PasaporteId")]
        public ICollection<PasaporteDetalle> PasaporteDetalle { get; set; } = new List<PasaporteDetalle>();



    }
}
