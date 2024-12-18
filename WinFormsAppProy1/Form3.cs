using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WinFormsAppProy1
{
    public partial class Form3 : Form
    {
        private List<Productos> data; // Declaramos la lista 'data' como campo de clase

        public Form3()
        {
            InitializeComponent();
            data = new List<Productos>(); // Inicializamos la lista
        }

        private void buttonReg2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando Sesion");
            this.Hide();
            this.Close(); // Cierra Form3
            FormIngreso f2 = new FormIngreso();
            f2.ShowDialog(); // Muestra Form2 como modal
        }

        private void buttonAGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(this.textBoxID.Text);
                string imagen = this.textBoxIMAGEN.Text;
                string descripcion = this.textBoxDESCRIPCION.Text;
                int precio = Convert.ToInt32(this.textBoxPRECIO.Text);
                int existencia = Convert.ToInt32(this.textBoxEXISTENCIA.Text);

                BaseDatos obj1 = new BaseDatos();
                obj1.insertar(ID, imagen, descripcion, precio, existencia);
                MessageBox.Show("Producto agregado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDatos obj = new BaseDatos();
                data = obj.consulta(); // Obtenemos los datos actuales de la base

                // Verificamos si hay al menos 6 productos
                if (data.Count <= 6)
                {
                    MessageBox.Show("No se pueden eliminar productos. Debe haber al menos 6 productos en el sistema.",
                                    "Restricción",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Salimos del método sin realizar la eliminación
                }

                // Procedemos con la eliminación si hay más de 6 productos
                int idEliminar = Convert.ToInt32(this.textBoxELIMINAR.Text);
                obj.eliminarConConfirmacion(idEliminar);
                this.textBoxELIMINAR.Clear();
                MessageBox.Show("Producto eliminado exitosamente.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        private void buttonCONSULTAR_Click(object sender, EventArgs e)
        {
            try
            {
                BaseDatos obj = new BaseDatos();
                data = obj.consulta(); // Obtenemos los datos de la base

                // Ordenamos los datos por el campo de existencia (de menor a mayor)
                var dataOrdenada = data.OrderBy(p => p.Existencia).ToList();

                // Limpiamos el RichTextBox y configuramos la fuente monoespaciada
                this.richTextBoxINFODATOS.Clear();
                this.richTextBoxINFODATOS.Font = new Font("Consolas", 10, FontStyle.Regular);

                // Encabezado de la tabla
                this.richTextBoxINFODATOS.AppendText(
                    String.Format("{0,-5} {1,-15} {2,-20} {3,-10} {4,-10}\n",
                        "ID", "Imagen", "Descripción", "Precio", "Existencia")
                );
                this.richTextBoxINFODATOS.AppendText(new string('-', 65) + "\n"); // Línea divisoria

                // Mostramos los datos ordenados
                foreach (var producto in dataOrdenada)
                {
                    this.richTextBoxINFODATOS.AppendText(
                        String.Format("{0,-5} {1,-15} {2,-20} {3,-10} {4,-10}\n",
                            producto.Id,
                            producto.Imagen,
                            producto.Descripcion,
                            producto.Precio,
                            producto.Existencia)
                    );
                }

                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVENTASTOTALES_Click(object sender, EventArgs e)
        {
            Form6 f1 = new Form6();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
