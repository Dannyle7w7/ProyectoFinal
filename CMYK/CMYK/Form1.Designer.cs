namespace CMYK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label11 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NupCyan = new NumericUpDown();
            NupMagenta = new NumericUpDown();
            NupBlack = new NumericUpDown();
            NupYellow = new NumericUpDown();
            BtnGenerar = new Button();
            PanelColor = new Panel();
            label5 = new Label();
            Decimal = new TextBox();
            BtnBuscar = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            NupRed = new NumericUpDown();
            NupGreen = new NumericUpDown();
            NupBlue = new NumericUpDown();
            BtnRGB = new Button();
            label10 = new Label();
            btnCalcular = new Button();
            lblResultadoBlack = new Label();
            lblResultadoYellow = new Label();
            lblResultadoMagenta = new Label();
            lblResultadoCyan = new Label();
            label1 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            PanelColordef = new Panel();
            label12 = new Label();
            label14 = new Label();
            lbcodigo = new Label();
            BtnEnviaraCarrito = new Button();
            txtCantidadTotalLitros = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)NupCyan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupMagenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupBlack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 52);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 0;
            label11.Text = "Cyan";
            label11.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 88);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Magenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 124);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Yellow";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 160);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Black";
            // 
            // NupCyan
            // 
            NupCyan.Location = new Point(104, 52);
            NupCyan.Margin = new Padding(3, 2, 3, 2);
            NupCyan.Name = "NupCyan";
            NupCyan.Size = new Size(48, 23);
            NupCyan.TabIndex = 4;
            NupCyan.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // NupMagenta
            // 
            NupMagenta.Location = new Point(104, 88);
            NupMagenta.Margin = new Padding(3, 2, 3, 2);
            NupMagenta.Name = "NupMagenta";
            NupMagenta.Size = new Size(48, 23);
            NupMagenta.TabIndex = 5;
            // 
            // NupBlack
            // 
            NupBlack.Location = new Point(104, 158);
            NupBlack.Margin = new Padding(3, 2, 3, 2);
            NupBlack.Name = "NupBlack";
            NupBlack.Size = new Size(48, 23);
            NupBlack.TabIndex = 7;
            // 
            // NupYellow
            // 
            NupYellow.Location = new Point(104, 122);
            NupYellow.Margin = new Padding(3, 2, 3, 2);
            NupYellow.Name = "NupYellow";
            NupYellow.Size = new Size(48, 23);
            NupYellow.TabIndex = 6;
            // 
            // BtnGenerar
            // 
            BtnGenerar.Location = new Point(39, 210);
            BtnGenerar.Margin = new Padding(3, 2, 3, 2);
            BtnGenerar.Name = "BtnGenerar";
            BtnGenerar.Size = new Size(116, 22);
            BtnGenerar.TabIndex = 8;
            BtnGenerar.Text = "Generar Color";
            BtnGenerar.UseVisualStyleBackColor = true;
            BtnGenerar.Click += btnGenerateColor_Click;
            // 
            // PanelColor
            // 
            PanelColor.Location = new Point(449, 180);
            PanelColor.Margin = new Padding(3, 2, 3, 2);
            PanelColor.Name = "PanelColor";
            PanelColor.Size = new Size(82, 33);
            PanelColor.TabIndex = 9;
            PanelColor.Paint += PanelColor_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 98);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 10;
            label5.Text = "Clave Hexadecimal";
            // 
            // Decimal
            // 
            Decimal.Location = new Point(209, 115);
            Decimal.Margin = new Padding(3, 2, 3, 2);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(150, 23);
            Decimal.TabIndex = 11;
            Decimal.TextChanged += TxtHexa_TextChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(382, 114);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(70, 22);
            BtnBuscar.TabIndex = 12;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += btnConvertirHexadecimal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 42);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 13;
            label6.Text = "Red";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(292, 42);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 14;
            label7.Text = "Green";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(374, 42);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 15;
            label8.Text = "Blue";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(87, 16);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 16;
            label9.Text = "CMYK";
            label9.Click += label9_Click;
            // 
            // NupRed
            // 
            NupRed.Location = new Point(211, 64);
            NupRed.Margin = new Padding(3, 2, 3, 2);
            NupRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NupRed.Name = "NupRed";
            NupRed.Size = new Size(43, 23);
            NupRed.TabIndex = 17;
            // 
            // NupGreen
            // 
            NupGreen.Location = new Point(291, 62);
            NupGreen.Margin = new Padding(3, 2, 3, 2);
            NupGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NupGreen.Name = "NupGreen";
            NupGreen.Size = new Size(43, 23);
            NupGreen.TabIndex = 18;
            // 
            // NupBlue
            // 
            NupBlue.Location = new Point(374, 64);
            NupBlue.Margin = new Padding(3, 2, 3, 2);
            NupBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NupBlue.Name = "NupBlue";
            NupBlue.Size = new Size(43, 23);
            NupBlue.TabIndex = 19;
            NupBlue.ValueChanged += NupBlue_ValueChanged;
            // 
            // BtnRGB
            // 
            BtnRGB.Location = new Point(440, 62);
            BtnRGB.Margin = new Padding(3, 2, 3, 2);
            BtnRGB.Name = "BtnRGB";
            BtnRGB.Size = new Size(91, 22);
            BtnRGB.TabIndex = 20;
            BtnRGB.Text = "Buscar";
            BtnRGB.UseVisualStyleBackColor = true;
            BtnRGB.Click += btnConvertirRGB_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(297, 18);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 21;
            label10.Text = "RGB";
            label10.Click += label10_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(219, 533);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 30);
            btnCalcular.TabIndex = 22;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultadoBlack
            // 
            lblResultadoBlack.AutoSize = true;
            lblResultadoBlack.Location = new Point(337, 496);
            lblResultadoBlack.Name = "lblResultadoBlack";
            lblResultadoBlack.Size = new Size(38, 15);
            lblResultadoBlack.TabIndex = 27;
            lblResultadoBlack.Text = "Black:";
            // 
            // lblResultadoYellow
            // 
            lblResultadoYellow.AutoSize = true;
            lblResultadoYellow.Location = new Point(337, 464);
            lblResultadoYellow.Name = "lblResultadoYellow";
            lblResultadoYellow.Size = new Size(44, 15);
            lblResultadoYellow.TabIndex = 26;
            lblResultadoYellow.Text = "Yellow:";
            // 
            // lblResultadoMagenta
            // 
            lblResultadoMagenta.AutoSize = true;
            lblResultadoMagenta.Location = new Point(337, 432);
            lblResultadoMagenta.Name = "lblResultadoMagenta";
            lblResultadoMagenta.Size = new Size(57, 15);
            lblResultadoMagenta.TabIndex = 25;
            lblResultadoMagenta.Text = "Magenta:";
            // 
            // lblResultadoCyan
            // 
            lblResultadoCyan.AutoSize = true;
            lblResultadoCyan.Location = new Point(337, 402);
            lblResultadoCyan.Name = "lblResultadoCyan";
            lblResultadoCyan.Size = new Size(37, 15);
            lblResultadoCyan.TabIndex = 24;
            lblResultadoCyan.Text = "Cyan:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 505);
            label1.Name = "label1";
            label1.Size = new Size(166, 19);
            label1.TabIndex = 28;
            label1.Text = "Ingrese cantidad de litros:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(337, 366);
            label13.Name = "label13";
            label13.Size = new Size(194, 19);
            label13.TabIndex = 30;
            label13.Text = "Cantidad de pintura necesaria:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // PanelColordef
            // 
            PanelColordef.Location = new Point(39, 366);
            PanelColordef.Margin = new Padding(3, 2, 3, 2);
            PanelColordef.Name = "PanelColordef";
            PanelColordef.Size = new Size(262, 123);
            PanelColordef.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(449, 158);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 32;
            label12.Text = "Color:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(39, 336);
            label14.Name = "label14";
            label14.Size = new Size(60, 21);
            label14.TabIndex = 33;
            label14.Text = "Codigo";
            // 
            // lbcodigo
            // 
            lbcodigo.AutoSize = true;
            lbcodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbcodigo.Location = new Point(97, 336);
            lbcodigo.Name = "lbcodigo";
            lbcodigo.Size = new Size(13, 21);
            lbcodigo.TabIndex = 34;
            lbcodigo.Text = ":";
            // 
            // BtnEnviaraCarrito
            // 
            BtnEnviaraCarrito.Location = new Point(337, 533);
            BtnEnviaraCarrito.Name = "BtnEnviaraCarrito";
            BtnEnviaraCarrito.Size = new Size(144, 30);
            BtnEnviaraCarrito.TabIndex = 35;
            BtnEnviaraCarrito.Text = "Enviar a Carrito";
            BtnEnviaraCarrito.UseVisualStyleBackColor = true;
            // 
            // txtCantidadTotalLitros
            // 
            txtCantidadTotalLitros.FormattingEnabled = true;
            txtCantidadTotalLitros.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            txtCantidadTotalLitros.Location = new Point(39, 538);
            txtCantidadTotalLitros.Name = "txtCantidadTotalLitros";
            txtCantidadTotalLitros.Size = new Size(166, 23);
            txtCantidadTotalLitros.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 579);
            Controls.Add(txtCantidadTotalLitros);
            Controls.Add(BtnEnviaraCarrito);
            Controls.Add(lbcodigo);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(PanelColordef);
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(lblResultadoBlack);
            Controls.Add(lblResultadoYellow);
            Controls.Add(lblResultadoMagenta);
            Controls.Add(lblResultadoCyan);
            Controls.Add(btnCalcular);
            Controls.Add(label10);
            Controls.Add(BtnRGB);
            Controls.Add(NupBlue);
            Controls.Add(NupGreen);
            Controls.Add(NupRed);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(BtnBuscar);
            Controls.Add(Decimal);
            Controls.Add(label5);
            Controls.Add(PanelColor);
            Controls.Add(BtnGenerar);
            Controls.Add(NupBlack);
            Controls.Add(NupYellow);
            Controls.Add(NupMagenta);
            Controls.Add(NupCyan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label11);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)NupCyan).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupMagenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupBlack).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown NupCyan;
        private NumericUpDown NupMagenta;
        private NumericUpDown NupBlack;
        private NumericUpDown NupYellow;
        private Button BtnGenerar;
        private Panel PanelColor;
        private Label label5;
        private TextBox Decimal;
        private Button BtnBuscar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown NupRed;
        private NumericUpDown NupGreen;
        private NumericUpDown NupBlue;
        private Button BtnRGB;
        private Label label10;
        private Button btnCalcular;
        private Label lblResultadoBlack;
        private Label lblResultadoYellow;
        private Label lblResultadoMagenta;
        private Label lblResultadoCyan;
        private Label label1;
        private Label label13;
        private PictureBox pictureBox1;
        private Panel PanelColordef;
        private Label label12;
        private Label label14;
        private Label lbcodigo;
        private Button BtnEnviaraCarrito;
        private ComboBox txtCantidadTotalLitros;
    }
}