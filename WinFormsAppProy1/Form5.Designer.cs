
namespace WinFormsAppProy1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonPdf = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            buttonReg3 = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            buttonLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonPdf
            // 
            buttonPdf.BackColor = Color.Lime;
            buttonPdf.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPdf.Location = new Point(687, 304);
            buttonPdf.Name = "buttonPdf";
            buttonPdf.Size = new Size(97, 57);
            buttonPdf.TabIndex = 0;
            buttonPdf.Text = "Realizar compra";
            buttonPdf.UseVisualStyleBackColor = false;
            buttonPdf.Click += buttonPdf_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(588, 182);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(282, 11);
            label1.Name = "label1";
            label1.Size = new Size(289, 37);
            label1.TabIndex = 2;
            label1.Text = " ORDEN DE COMPRA ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(198, 388);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 3;
            label2.Text = "Importe 6%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(198, 420);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 4;
            label3.Text = "Total";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Aquamarine;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(440, 360);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 8;
            label4.Text = "valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(198, 356);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 9;
            label5.Text = "SubTotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Aquamarine;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(440, 393);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 10;
            label6.Text = "valor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Aquamarine;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(440, 424);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 11;
            label7.Text = "valor";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ActiveCaption;
            dateTimePicker1.Location = new Point(532, 84);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(248, 107);
            label9.Name = "label9";
            label9.Size = new Size(135, 45);
            label9.TabIndex = 18;
            label9.Text = "Usuario";
            // 
            // buttonReg3
            // 
            buttonReg3.BackColor = SystemColors.ControlDark;
            buttonReg3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReg3.ForeColor = Color.FromArgb(192, 0, 0);
            buttonReg3.Location = new Point(10, 418);
            buttonReg3.Margin = new Padding(3, 2, 3, 2);
            buttonReg3.Name = "buttonReg3";
            buttonReg3.Size = new Size(91, 30);
            buttonReg3.TabIndex = 19;
            buttonReg3.Text = " Regresar ";
            buttonReg3.UseVisualStyleBackColor = false;
            buttonReg3.Click += buttonReg3_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(664, 199);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 20;
            label8.Text = " Efectivo ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(664, 238);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Black;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 192, 0);
            label10.Location = new Point(627, 238);
            label10.Name = "label10";
            label10.Size = new Size(27, 21);
            label10.TabIndex = 22;
            label10.Text = " $ ";
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = SystemColors.ControlDark;
            buttonLimpiar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLimpiar.ForeColor = Color.FromArgb(192, 0, 0);
            buttonLimpiar.Location = new Point(664, 387);
            buttonLimpiar.Margin = new Padding(3, 2, 3, 2);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(133, 30);
            buttonLimpiar.TabIndex = 23;
            buttonLimpiar.Text = "Limpiar Carrito\r\n";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo2;
            ClientSize = new Size(869, 500);
            Controls.Add(buttonLimpiar);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(buttonReg3);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonPdf);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button buttonPdf;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Button buttonReg3;
        private Label label8;
        private TextBox textBox1;
        private Label label10;
        private Button buttonLimpiar;
    }
}