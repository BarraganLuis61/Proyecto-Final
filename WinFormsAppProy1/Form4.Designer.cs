namespace WinFormsAppProy1
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            buttonReg3 = new Button();
            pictureBox1 = new PictureBox();
            labelSlogan = new Label();
            buttonCarrito = new Button();
            flowLayoutPanelProductos = new FlowLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label5 = new Label();
            lblhora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonReg3
            // 
            buttonReg3.BackColor = Color.Black;
            buttonReg3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReg3.ForeColor = Color.Brown;
            buttonReg3.Location = new Point(882, 554);
            buttonReg3.Margin = new Padding(3, 2, 3, 2);
            buttonReg3.Name = "buttonReg3";
            buttonReg3.Size = new Size(87, 32);
            buttonReg3.TabIndex = 10;
            buttonReg3.Text = "Log Out";
            buttonReg3.UseVisualStyleBackColor = false;
            buttonReg3.Click += buttonReg3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // labelSlogan
            // 
            labelSlogan.AutoSize = true;
            labelSlogan.BackColor = Color.Transparent;
            labelSlogan.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSlogan.ForeColor = SystemColors.ButtonHighlight;
            labelSlogan.Location = new Point(285, 11);
            labelSlogan.Name = "labelSlogan";
            labelSlogan.Size = new Size(326, 22);
            labelSlogan.TabIndex = 12;
            labelSlogan.Text = " \" La elegancia hace al hombre \" ";
            // 
            // buttonCarrito
            // 
            buttonCarrito.Image = Properties.Resources.carri1;
            buttonCarrito.Location = new Point(851, 46);
            buttonCarrito.Name = "buttonCarrito";
            buttonCarrito.Size = new Size(90, 69);
            buttonCarrito.TabIndex = 13;
            buttonCarrito.UseVisualStyleBackColor = true;
            buttonCarrito.Click += buttonCarrito_Click;
            // 
            // flowLayoutPanelProductos
            // 
            flowLayoutPanelProductos.Location = new Point(93, 135);
            flowLayoutPanelProductos.Name = "flowLayoutPanelProductos";
            flowLayoutPanelProductos.Size = new Size(848, 411);
            flowLayoutPanelProductos.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(677, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(285, 63);
            label2.Name = "label2";
            label2.Size = new Size(491, 45);
            label2.TabIndex = 17;
            label2.Text = "Usuario  |  Catálogo disponible ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(367, 40);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 19;
            label5.Text = " \"Corte y Clase\"  ";
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblhora.ForeColor = SystemColors.ButtonHighlight;
            lblhora.Location = new Point(780, 28);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(65, 24);
            lblhora.TabIndex = 20;
            lblhora.Text = "HORA";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(677, 28);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 21;
            label1.Text = "HORA:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(994, 562);
            Controls.Add(label1);
            Controls.Add(lblhora);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(flowLayoutPanelProductos);
            Controls.Add(buttonCarrito);
            Controls.Add(labelSlogan);
            Controls.Add(pictureBox1);
            Controls.Add(buttonReg3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReg3;
        private PictureBox pictureBox1;
        private Label labelSlogan;
        private Button buttonCarrito;
        private FlowLayoutPanel flowLayoutPanelProductos;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label5;
        private Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}