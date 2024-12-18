using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic; 

namespace WinFormsAppProy1
{
    public class Admon
    {
        private MySqlConnection connection;

        public Admon()
        {
            this.Connect();
        }
        
        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=proyectof; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public List<Proyectof> consulta()
        {
            List<Proyectof> data = new List<Proyectof>();
            Proyectof item;
            int id;
            string nombre;
            string cuenta;
            string contraseña;
            int monto;
            try
            {
                string query = "SELECT * FROM dts";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    contraseña = Convert.ToString(reader["contraseña"]) ?? "";
                    monto = Convert.ToInt32(reader["monto"]);

                    item = new Proyectof(id, nombre, cuenta, contraseña, monto);
                    data.Add(item);

                }
                reader.Close();
                data.ForEach((p) =>
                {
                    //MessageBox.Show(p.Id + "," + p.Producto + "," + p.Imagen + "," + p.Precio);

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return data;
        }
    }
}
