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
    public class BaseDatos
    {
        private MySqlConnection connection;
        string connectionString = "Server=localhost; Database=proyectof; User=root; Password=; SslMode=none;";

        public BaseDatos()
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
//******************************** METODOS PARA LA BASE DE DATOS DE INVENTARIO ******************************************
        public void insertar(int id, string imagen, string descripcion, int precio, int existencia)
        {
            string query = "";
            try
            {
                query = "INSERT INTO inventario (id, imagen, descripcion, precio, existencia) VALUES ("
                    + "'" + id + "',"
                    + "'" + imagen + "',"
                    + "'" + descripcion + "',"
                    + "'" + precio + "',"
                    + "'" + existencia + "')";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError al insertar registro: " + ex.Message);
                this.Disconnect();
            }
        }

        public void eliminarConConfirmacion(int id)
        {
            string query = "";
            try
            {
                // Primero obtenemos los datos del producto a eliminar
                query = "SELECT * FROM inventario WHERE ID = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Obtenemos los datos del producto
                    string productoInfo = $"ID: {reader["ID"]}\n" +
                                          $"Imagen: {reader["Imagen"]}\n" +
                                          $"Descripción: {reader["Descripcion"]}\n" +
                                          $"Precio: {reader["Precio"]}\n" +
                                          $"Existencia: {reader["Existencia"]}";

                    reader.Close(); // Cerramos el lector antes de ejecutar otra consulta

                    // Preguntamos al usuario si desea eliminar el producto
                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro de que desea eliminar este producto?\n\n{productoInfo}",
                        "Confirmación de eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Eliminamos el producto
                        query = "DELETE FROM inventario WHERE ID = " + id + ";";
                        cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Producto eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Eliminación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    reader.Close(); // Cerramos el lector si no encontramos el producto
                    MessageBox.Show("No se encontró ningún producto con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Disconnect();
            }
        }



        public List<Productos> ObtenerProductos()
        {
            List<Productos> productos = new List<Productos>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, imagen, descripcion, precio, existencia FROM inventario";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nombre = reader.GetString("imagen");
                    string descripcion = reader.GetString("descripcion");
                    int precio = reader.GetInt32("precio");
                    int existencia = reader.GetInt32("existencia");

                    productos.Add(new Productos(id, nombre, descripcion, precio, existencia));
                }
            }

            return productos;

        }


        public List<Productos> consulta()
        {
            List<Productos> data = new List<Productos>();
            Productos item;
            int id;
            string imagen;
            string descripcion;
            int precio;
            int existencia;

            try
            {
                string query = "SELECT * FROM inventario";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    imagen = Convert.ToString(reader["Imagen"]) ?? "";
                    descripcion = Convert.ToString(reader["Descripcion"]) ?? "";
                    precio = Convert.ToInt32(reader["Precio"]);
                    existencia = Convert.ToInt32(reader["Existencia"]);
                    item = new Productos(id, imagen, descripcion, precio, existencia);
                    data.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

            return data;
        }


        public void ActualizarExistencia(int productoId, int nuevaExistencia)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE inventario SET existencia = @Existencia WHERE id = @ID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Existencia", nuevaExistencia);
                    cmd.Parameters.AddWithValue("@ID", productoId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
