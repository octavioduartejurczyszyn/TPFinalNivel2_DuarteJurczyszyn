using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }
        public string Nombre { set; get; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Código")]
        public string Codigo { set; get; }
        public string ImagenUrl { get; set; }
        public decimal Precio { set; get; }
    }
}
