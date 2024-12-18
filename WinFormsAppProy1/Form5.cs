using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static WinFormsAppProy1.Form4;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WinFormsAppProy1
{
    public partial class Form5 : Form
    {
        public const double V = 0.06;
        public static decimal Ganancias = 0;

        //private Label labelTotal;
        private List<ProductoSeleccionado> productosSeleccionados;
        private List<Productos> productos; // Lista completa de 
        public Form5(List<ProductoSeleccionado> productosSeleccionados, List<Productos> productos)
        {
            InitializeComponent();
            this.productosSeleccionados = productosSeleccionados;
            this.productos = productos; // Guardar referencia a la lista completa
            CargarDataGridView();
        }

        private void CargarDataGridView()
        {

            // Agregar columnas al DataGridView
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Descripcion", "Descripción");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Total", "Total");

            // Agregar datos al DataGridView
            foreach (ProductoSeleccionado producto in productosSeleccionados)
            {
                dataGridView1.Rows.Add(producto.Id, producto.Description, producto.Cantidad, producto.Precio, producto.Cantidad * producto.Precio);
            }

            // Calcular el total
            decimal subtotal = 0, total = 0, importe = 0;
            foreach (ProductoSeleccionado producto in productosSeleccionados)
            {
                subtotal += producto.Cantidad * producto.Precio;
            }

            importe = subtotal * (decimal)V;
            total = importe + subtotal;

            // Agregar el total general
            label4.Text = $"${subtotal}";
            label6.Text = $"${importe}";
            label7.Text = $"${total}";

        }


        private void buttonPdf_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPdf_Click_1(object sender, EventArgs e)
        {
            // Ruta donde se guardarán los archivos PDF
            string folderPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\PDF"));
            if (!Directory.Exists(folderPath))
            {
                // Si la carpeta no existe, crearla
                Directory.CreateDirectory(folderPath);
            }

            // Obtener el siguiente número de factura disponible
            int facturaNumber = GetNextFacturaNumber(folderPath);
            string pdfPath = Path.Combine(folderPath, $"Factura{facturaNumber}.pdf"); // Definir la ruta del PDF

            // Crear el documento PDF
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));

            // Validar el dinero recibido
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("No se ha introducido ninguna cantidad.");
                return;
            }

            decimal dineroRecibido;
            if (!decimal.TryParse(textBox1.Text, out dineroRecibido))
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
                return;
            }

            decimal subtotal = 0, total = 0, importe = 0;
            foreach (ProductoSeleccionado producto in productosSeleccionados)
            {
                subtotal += producto.Cantidad * producto.Precio;
            }

            importe = subtotal * (decimal)V;
            total = importe + subtotal;

            // Validar si el dinero recibido es suficiente
            if (dineroRecibido < total)
            {
                MessageBox.Show("Lo sentimos, los fondos son insuficientes.");
            }
            else
            {
                // Abrir el documento para agregar contenido
                document.Open();

                // Ruta de la imagen (logo)
                string imagePath = @"C:\Users\ANGEL\Desktop\ProyectoFinal\ProyectoFinal\WinFormsAppProy1\imagenes\logo.jpeg";

                // Crear el objeto de imagen usando iTextSharp
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagePath);
                logo.ScaleToFit(100f, 100f);  // Ajustar tamaño de la imagen
                logo.SetAbsolutePosition(30f, document.PageSize.Height - 120f);  // Ajustar posición de la imagen
                document.Add(logo);  // Agregar la imagen al documento

                // Espaciado después de la imagen (se puede ajustar el valor)
                document.Add(new Paragraph("\n\n"));

                // Agregar el texto "Corte y Clase" centrado
                Paragraph title = new Paragraph("Corte y Clase")
                {
                    Alignment = Element.ALIGN_CENTER,
                    Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f)
                };
                document.Add(title);

                // Agregar la fecha y hora actual centrado
                Paragraph dateTime = new Paragraph($"Fecha y Hora: {DateTime.Now:dd/MM/yyyy HH:mm}")
                {
                    Alignment = Element.ALIGN_CENTER,
                    Font = FontFactory.GetFont(FontFactory.HELVETICA, 12f)
                };
                document.Add(dateTime);

                // Agregar un poco de espacio antes de la tabla
                document.Add(new Paragraph("\n\n"));

                // Crear una tabla con 4 columnas (para ID, Descripción, Cantidad, Total)
                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100; // Hace que la tabla ocupe el 100% del ancho de la página
                float[] widths = new float[] { 1f, 3f, 1f, 2f }; // Definir el ancho de cada columna
                table.SetWidths(widths);

                // Agregar los encabezados de la tabla
                table.AddCell(new PdfPCell(new Phrase("ID", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Descripción", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Cantidad", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Total", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { HorizontalAlignment = Element.ALIGN_CENTER });

                // Agregar los productos a la tabla
                foreach (ProductoSeleccionado producto in productosSeleccionados)
                {
                    table.AddCell(new PdfPCell(new Phrase(producto.Id.ToString())) { HorizontalAlignment = Element.ALIGN_LEFT });
                    table.AddCell(new PdfPCell(new Phrase(producto.Description)) { HorizontalAlignment = Element.ALIGN_LEFT });
                    table.AddCell(new PdfPCell(new Phrase(producto.Cantidad.ToString())) { HorizontalAlignment = Element.ALIGN_LEFT });
                    table.AddCell(new PdfPCell(new Phrase($"${producto.Cantidad * producto.Precio}")) { HorizontalAlignment = Element.ALIGN_LEFT });
                }

                // Agregar la tabla al documento
                document.Add(table);

                // Agregar el total y otros datos
                document.Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------"));
                document.Add(new Paragraph($"Subtotal: ${subtotal}") { Alignment = Element.ALIGN_RIGHT });
                document.Add(new Paragraph($"IVA: ${importe}") { Alignment = Element.ALIGN_RIGHT });
                document.Add(new Paragraph($"Total: ${total}") { Alignment = Element.ALIGN_RIGHT });
                document.Add(new Paragraph($"Dinero Recibido: ${dineroRecibido}") { Alignment = Element.ALIGN_RIGHT });
                document.Add(new Paragraph($"Cambio: ${dineroRecibido - total}") { Alignment = Element.ALIGN_RIGHT });
                document.Add(new Paragraph("-----------------------------------------------------------------------------------------------------------------"));
                document.Add(new Paragraph("¡Gracias por su compra!") { Alignment = Element.ALIGN_CENTER });

                // Cerrar el documento PDF
                document.Close();
                MessageBox.Show("Nueva compra en proceso ... ");
                // Intentar abrir el PDF con la aplicación predeterminada
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(pdfPath)
                    {
                        UseShellExecute = true // Esto asegura que el sistema use la aplicación predeterminada para abrir PDFs
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el archivo: {ex.Message}");
                }

                // Actualizar las existencias de los productos en la base de datos
                BaseDatos baseDatos = new BaseDatos();
                foreach (ProductoSeleccionado producto in productosSeleccionados)
                {
                    Productos productoOriginal = productos.FirstOrDefault(p => p.Id == producto.Id);
                    if (productoOriginal != null)
                    {
                        productoOriginal.Existencia -= producto.Cantidad;
                        baseDatos.ActualizarExistencia(producto.Id, productoOriginal.Existencia);
                    }
                }

                // Mostrar mensaje y cerrar el formulario
                this.Close();
                Form4 f4 = new Form4();
                decimal cambio = dineroRecibido - total;
                Ganancias += total; // Actualizar las ganancias totales
                MessageBox.Show(" ¡GRACIAS POR SU PREFERENCIA! \n ESPERAMOS QUE DISFRUTE DE SU COMPRA :D ");
                f4.ShowDialog();
            }
        }



        // Método para obtener el siguiente número de factura
        private int GetNextFacturaNumber(string folderPath)
        {
            // Obtener todos los archivos PDF en la carpeta
            string[] files = Directory.GetFiles(folderPath, "Factura*.pdf");

            // Obtener el número más alto de factura
            int maxNumber = 0;
            foreach (string file in files)
            {
                // Obtener el número de factura del nombre del archivo
                string fileName = Path.GetFileNameWithoutExtension(file);
                if (fileName.StartsWith("Factura"))
                {
                    string numberPart = fileName.Substring(7); // Extraer el número después de "Factura"
                    if (int.TryParse(numberPart, out int number))
                    {
                        maxNumber = Math.Max(maxNumber, number);
                    }
                }
            }

            // El siguiente número de factura será el más alto encontrado + 1
            return maxNumber + 1;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {

            // Limpiar la lista de productos seleccionados
            productosSeleccionados.Clear();

            // Limpiar las filas del DataGridView
            dataGridView1.Rows.Clear();

            // Mostrar mensaje indicando que el carrito se ha limpiado
            MessageBox.Show("Se ha limpiado todo el carrito de compras.");
        }
        private void buttonReg3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
