using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conteo_camaras.Entities
{
    public class Conteo_Seguridad
    {
        [Key]
        public int Id_conteo { get; set; }
        public string nombre_camara { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public DateTime Fecha_hora { get; set; }
        public int Cantidad_vehiculos { get; set; }

    }
}
