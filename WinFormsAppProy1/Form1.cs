using Mysqlx;

namespace WinFormsAppProy1
{
    public partial class Form1 : Form
    {

        List<Proyectof> datos;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            Admon obj = new Admon();
            datos = obj.consulta();

            FormIngreso f2 = new FormIngreso();
            this.Hide();
            f2.ShowDialog();

            obj.Disconnect();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación y todos los formularios abiertos
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
