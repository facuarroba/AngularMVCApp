using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Articulo
    {
        public Articulo() { }
        public Articulo(String codigo, String nombre, String descripcion, String marca, String presentacion, String unidad, String origen, string precio)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Marca = marca;
            this.Presentacion = presentacion + " " + unidad;
            this.Origen = origen;
            this.Precio = precio;
        }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Presentacion { get; set; }
        public string Origen { get; set; }
        public string Precio { get; set; }
    }
}