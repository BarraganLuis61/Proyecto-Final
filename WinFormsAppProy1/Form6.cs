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
    public partial class Form6 : Form
    {
        private System.Windows.Forms.Timer timer;

        public Form6()
        {
            InitializeComponent();
            this.Load += labelGanancias_Click;
        }


        private void buttonATRAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regresando...");
            this.Hide();
            Form3 f2 = new Form3();
            f2.ShowDialog();
        }

        private void labelGanancias_Click(object sender, EventArgs e)
        {
            labelGanancias.Text = $" ${Form5.Ganancias}";
        }

        private BaseDatos baseDatos;
        private int usuarioActualId; // ID del usuario actual, obtenido desde Form5

        


        private void labelGanancias_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


    }
}
