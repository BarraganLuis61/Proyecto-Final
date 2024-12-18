using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppProy1
{
    public partial class Form4 : Form
    {

        private List<ProductoSeleccionado> productosSeleccionados = new List<ProductoSeleccionado>();
        private List<Productos> productos;
        private BaseDatos baseDatos;

        public Form4()
        {
            InitializeComponent();
            baseDatos = new BaseDatos();
            CargarProductos();
            label2.Text = string.Empty;
        }

        private void CargarProductos()
        {
            if (productos == null || productos.Count == 0)
            {
                productos = baseDatos.ObtenerProductos(); // Solo cargar si no está inicializada
            }
            MostrarProductos();
        }



        private void buttonReg3_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Cerrando sesion...");
            // Mostrar Form2
            FormIngreso f2 = new FormIngreso();
            this.Hide();
            f2.ShowDialog(); // Usamos ShowDialog para que sea una ventana modal
            this.Show();
            this.Close();


        }
        private void MostrarProductos()
        {
            flowLayoutPanelProductos.Controls.Clear();
            flowLayoutPanelProductos.Margin = new Padding(0, 20, 0, 20); // Agregar margen superior e inferior

            int contador = 0;
            foreach (Productos producto in productos)
            {
                if (producto.Existencia > 0)
                {
                    Panel panelProducto = new Panel();
                    panelProducto.Width = 200;
                    panelProducto.Height = 200;
                    panelProducto.BorderStyle = BorderStyle.FixedSingle;

                    PictureBox pictureBoxImagen = new PictureBox();
                    pictureBoxImagen.Image = Image.FromFile(System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, @"..\..\..\Resources\" + producto.Imagen)));
                    pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxImagen.Width = 100;
                    pictureBoxImagen.Height = 100;
                    pictureBoxImagen.Location = new Point(50, 20);

                    Label labelDescripcion = new Label();
                    labelDescripcion.Text = producto.Descripcion;
                    labelDescripcion.Location = new Point(20, 130);
                    labelDescripcion.ForeColor = Color.White;

                    Label labelPrecio = new Label();
                    labelPrecio.Text = $"Precio: ${producto.Precio}";
                    labelPrecio.Location = new Point(20, 150);
                    labelPrecio.ForeColor = Color.White;

                    Label labelExistencia = new Label();
                    labelExistencia.Text = $"Existencia: {producto.Existencia}";
                    labelExistencia.Location = new Point(20, 170);
                    labelExistencia.ForeColor = Color.White;

                    NumericUpDown numericUpDownCantidad = new NumericUpDown();
                    numericUpDownCantidad.Location = new Point(120, 145);
                    numericUpDownCantidad.Maximum = producto.Existencia; // Limitar la cantidad máxima a la existencia
                    numericUpDownCantidad.Tag = producto; // Asociar el producto al control para usarlo luego

                    panelProducto.Controls.Add(pictureBoxImagen);
                    panelProducto.Controls.Add(labelDescripcion);
                    panelProducto.Controls.Add(labelPrecio);
                    panelProducto.Controls.Add(labelExistencia);
                    panelProducto.Controls.Add(numericUpDownCantidad);

                    flowLayoutPanelProductos.Controls.Add(panelProducto);

                    contador++;
                }
            }

            // Agregar un espacio abajo
            Panel panelEspacioAbajo = new Panel();
            panelEspacioAbajo.Width = 200;
            panelEspacioAbajo.Height = 20;
            flowLayoutPanelProductos.Controls.Add(panelEspacioAbajo);
        }

        private void buttonCarrito_Click(object sender, EventArgs e)
        {
            productosSeleccionados.Clear(); // Limpiar el carrito antes de agregar nuevos productos seleccionados

            foreach (Control control in flowLayoutPanelProductos.Controls)
            {
                if (control is Panel panelProducto)
                {
                    NumericUpDown numericUpDownCantidad = panelProducto.Controls.OfType<NumericUpDown>().FirstOrDefault();
                    if (numericUpDownCantidad != null && numericUpDownCantidad.Value > 0)
                    {
                        Productos producto = (Productos)numericUpDownCantidad.Tag;

                        int cantidad = (int)numericUpDownCantidad.Value;

                        // Crear objeto para el carrito, pero sin actualizar la existencia aún
                        ProductoSeleccionado productoSeleccionado = new ProductoSeleccionado
                        {
                            Id = producto.Id,
                            Description = producto.Descripcion,
                            Cantidad = cantidad,
                            Precio = producto.Precio
                        };
                        productosSeleccionados.Add(productoSeleccionado);
                    }
                }
            }

            if (productosSeleccionados.Count > 0)
            {
                // Mostrar el formulario del carrito
                Form5 f5 = new Form5(productosSeleccionados, productos); // Pasamos la lista de productos completa también
                this.Hide();
                f5.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No hay productos seleccionados para agregar al carrito.");
            }
        }


        public class ProductoSeleccionado
        {
            public int Id { get; set; }
            public string? Description { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
