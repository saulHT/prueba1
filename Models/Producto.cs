using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProyect.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
