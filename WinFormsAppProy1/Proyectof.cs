using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppProy1
{
    public class Proyectof
    {
        private int id;
        private string nombre;
        private string cuenta;
        private string contraseña;
        private int monto; 


        public Proyectof(int id, string imagen, string descripcion)
        {

        }

        public Proyectof(int id, string nombre, string cuenta, string contraseña, int monto)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cuenta = cuenta;
            this.Contraseña = contraseña;
            this.Monto = monto;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Monto { get => monto; set => monto = value; }
    }
}
