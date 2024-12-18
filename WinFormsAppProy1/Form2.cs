using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsAppProy1
{
    public partial class FormIngreso : Form
    {
        List<Proyectof> datos;

        private string cuenta, cont;

        public FormIngreso()
        {
            InitializeComponent();
        }

        public FormIngreso(string cuenta, string cont)
        {
            this.cuenta = cuenta;
            this.cont = cont;
            InitializeComponent();
            this.textBoxCuenta.Text = this.cuenta;
            this.textBoxCuenta.Text = this.cont;

        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            string cuen = this.textBoxCuenta.Text;
            string cont = this.textBoxContraseña.Text;

            // Cadena de conexión a la base de datos
            string connectionString = "Server=localhost; Database=proyectof; User=root; Password=; SslMode=none;";

            try
            {
                // Establecer la conexión a la base de datos
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    //Verificar si la cuenta y la contraseña son la del administrador 
                    //Verificar si la cuenta y la contraseña son la del administrador 
                    if (cuen == "luisAdmin@gmail.com" && cont == "AdminUAA")
                    {
                        //Se muestra el formulario para el admin
                        Form3 f3 = new Form3();
                        this.Hide();
                        f3.ShowDialog();
                        //this.Show();
                        this.Close();
                    }

                    // Consulta para verificar si la cuenta y la contraseña coinciden
                    string query = "SELECT COUNT(*) FROM dts WHERE cuenta = @cuenta AND contraseña = @contraseña";

                    // Crear el comando SQL
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar los parámetros a la consulta para prevenir inyecciones SQL
                        command.Parameters.AddWithValue("@cuenta", cuen);
                        command.Parameters.AddWithValue("@contraseña", cont);

                        // Ejecutar la consulta y obtener el número de registros que coinciden
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Si la cuenta y la contraseña existen, count será mayor a 0
                        if (count > 0)
                        {
                            MessageBox.Show("BIENVENIDO AL SISTEMA");
                            /// Mostrar el siguiente formulario (Form3)
                            Form4 f4 = new Form4();
                            this.Hide();
                            f4.ShowDialog();
                            //this.Show();
                            this.Close();

                        }
                        else
                        {
                            // Mostrar un mensaje de error si no hay coincidencias
                            MessageBox.Show("Usuario o contraseña incorrectos");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error con la conexión, mostrar un mensaje
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }


        }

        private void pictureBoxIngeso_Click(object sender, EventArgs e)
        {
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Regresando...");

            // Cerrar Form2 
            this.Close();

            // Mostrar Form1
            Form1 f1 = new Form1();
            f1.ShowDialog();  // Mostrar Form1 de forma modal
        }



        //************************************************************ METODOS PARA LA CONTRASEÑA Y CUENTA ********
        // para la cuenta 
        private void textBoxCuenta_Enter_1(object sender, EventArgs e)
        {
            if (textBoxCuenta.Text == "Cuenta")
            {
                textBoxCuenta.Text = "";
                textBoxCuenta.ForeColor = Color.Black; // Color del texto normal
            }
        }

        private void textBoxCuenta_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCuenta.Text))
            {
                textBoxCuenta.Text = "Cuenta";
                textBoxCuenta.ForeColor = Color.Gray; // Color de placeholder
            }
        }
        // para la conraseña
        private void textBoxContraseña_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxContraseña.Text))
            {
                textBoxContraseña.UseSystemPasswordChar = false; // Muestra placeholder
                textBoxContraseña.Text = "Contraseña";
                textBoxContraseña.ForeColor = Color.Gray;
            }
        }

        private void textBoxContraseña_Enter_1(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "Contraseña")
            {
                textBoxContraseña.Text = "";
                textBoxContraseña.ForeColor = Color.Black;
                textBoxContraseña.UseSystemPasswordChar = true; // Oculta la contraseña
            }
        }

        //***********************************************************************
    }
}
