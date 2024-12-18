using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProy1
{
    public class Productos
    {
        private int id;
        private string imagen;
        private string descripcion;
        private int precio;
        private int existencia;

        public Productos() { }

        public Productos(int id, string imagen, string descripcion, int precio, int existencia)
        {
            this.id = id;
            this.imagen = imagen;
            this.descripcion = descripcion;
            this.precio = precio;
            this.existencia = existencia;
        }

        public int Id { get => id; set => id = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Existencia { get => existencia; set => existencia = value; }
    }
}

