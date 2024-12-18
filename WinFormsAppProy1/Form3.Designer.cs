namespace WinFormsAppProy1
{
    partial class Form3
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
            buttonReg2 = new Button();
            textBoxID = new TextBox();
            groupBoxAltas = new GroupBox();
            buttonAGREGAR = new Button();
            textBoxEXISTENCIA = new TextBox();
            textBoxPRECIO = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBoxDESCRIPCION = new TextBox();
            textBoxIMAGEN = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            buttonELIMINAR = new Button();
            label11 = new Label();
            textBoxELIMINAR = new TextBox();
            richTextBoxINFODATOS = new RichTextBox();
            buttonCONSULTAR = new Button();
            buttonVENTASTOTALES = new Button();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            groupBoxAltas.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(35, 30);
            label1.Name = "label1";
            label1.Size = new Size(375, 33);
            label1.TabIndex = 1;
            label1.Text = "Adminsitración del Sistema";
            // 
            // buttonReg2
            // 
            buttonReg2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReg2.ForeColor = Color.Red;
            buttonReg2.Location = new Point(952, 557);
            buttonReg2.Name = "buttonReg2";
            buttonReg2.Size = new Size(108, 30);
            buttonReg2.TabIndex = 10;
            buttonReg2.Text = "Log Out";
            buttonReg2.UseVisualStyleBackColor = true;
            buttonReg2.Click += buttonReg2_Click;
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxID.Location = new Point(147, 25);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(179, 30);
            textBoxID.TabIndex = 11;
            // 
            // groupBoxAltas
            // 
            groupBoxAltas.BackColor = Color.FromArgb(145, 196, 225);
            groupBoxAltas.Controls.Add(buttonAGREGAR);
            groupBoxAltas.Controls.Add(textBoxEXISTENCIA);
            groupBoxAltas.Controls.Add(textBoxPRECIO);
            groupBoxAltas.Controls.Add(label6);
            groupBoxAltas.Controls.Add(label5);
            groupBoxAltas.Controls.Add(label4);
            groupBoxAltas.Controls.Add(textBoxDESCRIPCION);
            groupBoxAltas.Controls.Add(textBoxIMAGEN);
            groupBoxAltas.Controls.Add(label3);
            groupBoxAltas.Controls.Add(label2);
            groupBoxAltas.Controls.Add(textBoxID);
            groupBoxAltas.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxAltas.ForeColor = Color.Navy;
            groupBoxAltas.Location = new Point(12, 97);
            groupBoxAltas.Name = "groupBoxAltas";
            groupBoxAltas.Size = new Size(336, 368);
            groupBoxAltas.TabIndex = 12;
            groupBoxAltas.TabStop = false;
            groupBoxAltas.Text = "ALTAS";
            // 
            // buttonAGREGAR
            // 
            buttonAGREGAR.Font = new Font("Arial Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAGREGAR.ForeColor = Color.RoyalBlue;
            buttonAGREGAR.Location = new Point(212, 331);
            buttonAGREGAR.Name = "buttonAGREGAR";
            buttonAGREGAR.Size = new Size(114, 31);
            buttonAGREGAR.TabIndex = 25;
            buttonAGREGAR.Text = "AGREGAR";
            buttonAGREGAR.UseVisualStyleBackColor = true;
            buttonAGREGAR.Click += buttonAGREGAR_Click;
            // 
            // textBoxEXISTENCIA
            // 
            textBoxEXISTENCIA.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEXISTENCIA.Location = new Point(147, 278);
            textBoxEXISTENCIA.Name = "textBoxEXISTENCIA";
            textBoxEXISTENCIA.Size = new Size(179, 30);
            textBoxEXISTENCIA.TabIndex = 20;
            // 
            // textBoxPRECIO
            // 
            textBoxPRECIO.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPRECIO.Location = new Point(147, 220);
            textBoxPRECIO.Name = "textBoxPRECIO";
            textBoxPRECIO.Size = new Size(179, 30);
            textBoxPRECIO.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(6, 278);
            label6.Name = "label6";
            label6.Size = new Size(116, 24);
            label6.TabIndex = 18;
            label6.Text = "Existencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(23, 220);
            label5.Name = "label5";
            label5.Size = new Size(76, 24);
            label5.TabIndex = 17;
            label5.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(6, 164);
            label4.Name = "label4";
            label4.Size = new Size(134, 24);
            label4.TabIndex = 16;
            label4.Text = "Descripción";
            // 
            // textBoxDESCRIPCION
            // 
            textBoxDESCRIPCION.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDESCRIPCION.Location = new Point(147, 161);
            textBoxDESCRIPCION.Name = "textBoxDESCRIPCION";
            textBoxDESCRIPCION.Size = new Size(179, 30);
            textBoxDESCRIPCION.TabIndex = 15;
            // 
            // textBoxIMAGEN
            // 
            textBoxIMAGEN.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxIMAGEN.Location = new Point(147, 93);
            textBoxIMAGEN.Name = "textBoxIMAGEN";
            textBoxIMAGEN.Size = new Size(179, 30);
            textBoxIMAGEN.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(23, 96);
            label3.Name = "label3";
            label3.Size = new Size(88, 24);
            label3.TabIndex = 13;
            label3.Text = "Imagen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(38, 28);
            label2.Name = "label2";
            label2.Size = new Size(36, 24);
            label2.TabIndex = 12;
            label2.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(145, 196, 225);
            groupBox1.Controls.Add(buttonELIMINAR);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBoxELIMINAR);
            groupBox1.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(12, 482);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 131);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "ELIMINAR";
            // 
            // buttonELIMINAR
            // 
            buttonELIMINAR.Font = new Font("Arial Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonELIMINAR.ForeColor = Color.RoyalBlue;
            buttonELIMINAR.Location = new Point(212, 84);
            buttonELIMINAR.Name = "buttonELIMINAR";
            buttonELIMINAR.Size = new Size(114, 31);
            buttonELIMINAR.TabIndex = 25;
            buttonELIMINAR.Text = "ELIMINAR";
            buttonELIMINAR.UseVisualStyleBackColor = true;
            buttonELIMINAR.Click += buttonELIMINAR_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(63, 50);
            label11.Name = "label11";
            label11.Size = new Size(36, 24);
            label11.TabIndex = 12;
            label11.Text = "ID";
            // 
            // textBoxELIMINAR
            // 
            textBoxELIMINAR.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxELIMINAR.Location = new Point(147, 33);
            textBoxELIMINAR.Name = "textBoxELIMINAR";
            textBoxELIMINAR.Size = new Size(179, 30);
            textBoxELIMINAR.TabIndex = 11;
            // 
            // richTextBoxINFODATOS
            // 
            richTextBoxINFODATOS.Location = new Point(377, 138);
            richTextBoxINFODATOS.Name = "richTextBoxINFODATOS";
            richTextBoxINFODATOS.Size = new Size(683, 286);
            richTextBoxINFODATOS.TabIndex = 22;
            richTextBoxINFODATOS.Text = "";
            // 
            // buttonCONSULTAR
            // 
            buttonCONSULTAR.Font = new Font("Arial Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCONSULTAR.ForeColor = Color.RoyalBlue;
            buttonCONSULTAR.Location = new Point(952, 444);
            buttonCONSULTAR.Name = "buttonCONSULTAR";
            buttonCONSULTAR.Size = new Size(114, 31);
            buttonCONSULTAR.TabIndex = 23;
            buttonCONSULTAR.Text = "CONSULTAR";
            buttonCONSULTAR.UseVisualStyleBackColor = true;
            buttonCONSULTAR.Click += buttonCONSULTAR_Click;
            // 
            // buttonVENTASTOTALES
            // 
            buttonVENTASTOTALES.Font = new Font("Arial Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVENTASTOTALES.ForeColor = Color.RoyalBlue;
            buttonVENTASTOTALES.Location = new Point(832, 558);
            buttonVENTASTOTALES.Name = "buttonVENTASTOTALES";
            buttonVENTASTOTALES.Size = new Size(114, 31);
            buttonVENTASTOTALES.TabIndex = 24;
            buttonVENTASTOTALES.Text = "VER VENTAS ";
            buttonVENTASTOTALES.UseVisualStyleBackColor = true;
            buttonVENTASTOTALES.Click += buttonVENTASTOTALES_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(564, 106);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Britannic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(591, 30);
            label8.Name = "label8";
            label8.Size = new Size(179, 26);
            label8.TabIndex = 26;
            label8.Text = " \"Corte y Clase\"  ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(915, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fnAdm;
            ClientSize = new Size(1072, 617);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(buttonVENTASTOTALES);
            Controls.Add(buttonCONSULTAR);
            Controls.Add(richTextBoxINFODATOS);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxAltas);
            Controls.Add(buttonReg2);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            groupBoxAltas.ResumeLayout(false);
            groupBoxAltas.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonReg2;
        private TextBox textBoxID;
        private GroupBox groupBoxAltas;
        private Label label2;
        private Label label4;
        private TextBox textBoxDESCRIPCION;
        private TextBox textBoxIMAGEN;
        private Label label3;
        private TextBox textBoxEXISTENCIA;
        private TextBox textBoxPRECIO;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private Label label11;
        private TextBox textBoxELIMINAR;
        private RichTextBox richTextBoxINFODATOS;
        private Button buttonCONSULTAR;
        private Button buttonVENTASTOTALES;
        private Button buttonAGREGAR;
        private Button buttonELIMINAR;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
    }
}