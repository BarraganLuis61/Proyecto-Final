namespace WinFormsAppProy1
{
    partial class FormIngreso
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
            labelSlogan = new Label();
            pictureBox1 = new PictureBox();
            buttonIngreso = new Button();
            buttonReg = new Button();
            label5 = new Label();
            textBoxCuenta = new TextBox();
            textBoxContraseña = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelSlogan
            // 
            labelSlogan.AutoSize = true;
            labelSlogan.BackColor = Color.Transparent;
            labelSlogan.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSlogan.ForeColor = SystemColors.ButtonHighlight;
            labelSlogan.Location = new Point(300, 127);
            labelSlogan.Name = "labelSlogan";
            labelSlogan.Size = new Size(416, 28);
            labelSlogan.TabIndex = 1;
            labelSlogan.Text = " \" La elegancia hace al hombre \" ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(377, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonIngreso
            // 
            buttonIngreso.BackColor = SystemColors.AppWorkspace;
            buttonIngreso.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIngreso.ForeColor = Color.Black;
            buttonIngreso.Location = new Point(421, 389);
            buttonIngreso.Name = "buttonIngreso";
            buttonIngreso.Size = new Size(153, 69);
            buttonIngreso.TabIndex = 8;
            buttonIngreso.Text = "Ingresar";
            buttonIngreso.UseVisualStyleBackColor = false;
            buttonIngreso.Click += buttonIngreso_Click;
            // 
            // buttonReg
            // 
            buttonReg.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReg.ForeColor = Color.Black;
            buttonReg.Location = new Point(843, 516);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(114, 43);
            buttonReg.TabIndex = 9;
            buttonReg.Text = " Regresar ";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(400, 170);
            label5.Name = "label5";
            label5.Size = new Size(219, 31);
            label5.TabIndex = 18;
            label5.Text = " \"Corte y Clase\"  ";
            // 
            // textBoxCuenta
            // 
            textBoxCuenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCuenta.ForeColor = Color.DarkGray;
            textBoxCuenta.Location = new Point(352, 256);
            textBoxCuenta.Multiline = true;
            textBoxCuenta.Name = "textBoxCuenta";
            textBoxCuenta.Size = new Size(280, 35);
            textBoxCuenta.TabIndex = 19;
            textBoxCuenta.Text = "Cuenta";
            textBoxCuenta.Enter += textBoxCuenta_Enter_1;
            textBoxCuenta.Leave += textBoxCuenta_Leave_1;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContraseña.ForeColor = Color.DarkGray;
            textBoxContraseña.Location = new Point(352, 333);
            textBoxContraseña.Multiline = true;
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(280, 35);
            textBoxContraseña.TabIndex = 20;
            textBoxContraseña.Text = "Contraseña";
            textBoxContraseña.Enter += textBoxContraseña_Enter_1;
            textBoxContraseña.Leave += textBoxContraseña_Leave_1;
            // 
            // FormIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(991, 584);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxCuenta);
            Controls.Add(label5);
            Controls.Add(buttonReg);
            Controls.Add(buttonIngreso);
            Controls.Add(pictureBox1);
            Controls.Add(labelSlogan);
            ForeColor = SystemColors.ControlText;
            Name = "FormIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelSlogan;
        private PictureBox pictureBox1;
        private Button buttonIngreso;
        private Button buttonReg;
        private Label label5;
        private TextBox textBoxCuenta;
        private TextBox textBoxContraseña;
    }
}