namespace WinFormsAppProy1
{
    partial class Form6
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
            label1 = new Label();
            labelGanancias = new Label();
            label2 = new Label();
            buttonATRAS = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 56);
            label1.TabIndex = 13;
            // 
            // labelGanancias
            // 
            labelGanancias.AutoSize = true;
            labelGanancias.BackColor = Color.Transparent;
            labelGanancias.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGanancias.Location = new Point(313, 184);
            labelGanancias.Name = "labelGanancias";
            labelGanancias.Size = new Size(25, 28);
            labelGanancias.TabIndex = 16;
            labelGanancias.Text = "=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 176);
            label2.Name = "label2";
            label2.Size = new Size(295, 40);
            label2.TabIndex = 15;
            label2.Text = "Total de Compras ";
            // 
            // buttonATRAS
            // 
            buttonATRAS.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonATRAS.ForeColor = Color.Red;
            buttonATRAS.Location = new Point(490, 350);
            buttonATRAS.Name = "buttonATRAS";
            buttonATRAS.Size = new Size(148, 34);
            buttonATRAS.TabIndex = 17;
            buttonATRAS.Text = "REGRESAR";
            buttonATRAS.UseVisualStyleBackColor = true;
            buttonATRAS.Click += buttonATRAS_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(493, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(186, 89);
            label8.Name = "label8";
            label8.Size = new Size(179, 26);
            label8.TabIndex = 28;
            label8.Text = " \"Corte y Clase\"  ";
            label8.Click += label8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(120, 20);
            label3.Name = "label3";
            label3.Size = new Size(321, 56);
            label3.TabIndex = 31;
            label3.Text = "\"   VENTAS   \"";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._0286a9cebbf70d7d92b7ca5f8022973c1;
            ClientSize = new Size(650, 407);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(buttonATRAS);
            Controls.Add(labelGanancias);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelGanancias;
        private Label label2;
        private Button buttonATRAS;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label3;
    }
}