using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProductos
{
    public class Album : IEntidad
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}