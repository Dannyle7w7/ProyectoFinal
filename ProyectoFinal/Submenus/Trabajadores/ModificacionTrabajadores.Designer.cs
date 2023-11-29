namespace ProyectoFinal.Submenus.Trabajadores
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.pbUsu = new System.Windows.Forms.PictureBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.pbNombre = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.rdActivo = new ProyectoFinal.Controles_Personalizados.RJToggleButton();
            this.rjMostrar = new ProyectoFinal.Controles_Personalizados.RJToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(107, 301);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 51);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(136, 295);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 51);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(146, 116);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(185, 29);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(147, 192);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 29);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtID.Location = new System.Drawing.Point(146, 78);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 29);
            this.txtID.TabIndex = 6;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtContra.ForeColor = System.Drawing.Color.Gray;
            this.txtContra.Location = new System.Drawing.Point(146, 230);
            this.txtContra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(185, 29);
            this.txtContra.TabIndex = 11;
            this.txtContra.Text = "Contraseña";
            this.txtContra.Enter += new System.EventHandler(this.txtContra_Enter);
            this.txtContra.Leave += new System.EventHandler(this.txtContra_Leave);
            // 
            // btnFoto
            // 
            this.btnFoto.AutoSize = true;
            this.btnFoto.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFoto.Location = new System.Drawing.Point(8, 204);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(100, 50);
            this.btnFoto.TabIndex = 15;
            this.btnFoto.Text = "Cargar \r\nImagen";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(8, 78);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbFoto.MaximumSize = new System.Drawing.Size(100, 117);
            this.pbFoto.MinimumSize = new System.Drawing.Size(100, 117);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(100, 117);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 16;
            this.pbFoto.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Beige;
            this.lblTitulo.Location = new System.Drawing.Point(73, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(216, 30);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Registro de Usuario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(385, 65);
            this.pnlTitulo.TabIndex = 20;
            // 
            // pbID
            // 
            this.pbID.Image = ((System.Drawing.Image)(resources.GetObject("pbID.Image")));
            this.pbID.Location = new System.Drawing.Point(116, 77);
            this.pbID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbID.Name = "pbID";
            this.pbID.Size = new System.Drawing.Size(26, 23);
            this.pbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbID.TabIndex = 21;
            this.pbID.TabStop = false;
            // 
            // pbUsu
            // 
            this.pbUsu.Image = ((System.Drawing.Image)(resources.GetObject("pbUsu.Image")));
            this.pbUsu.Location = new System.Drawing.Point(116, 116);
            this.pbUsu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbUsu.Name = "pbUsu";
            this.pbUsu.Size = new System.Drawing.Size(26, 23);
            this.pbUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsu.TabIndex = 22;
            this.pbUsu.TabStop = false;
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Empleado",
            "Jefe"});
            this.cbNivel.Location = new System.Drawing.Point(146, 153);
            this.cbNivel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(185, 29);
            this.cbNivel.TabIndex = 23;
            // 
            // pbNombre
            // 
            this.pbNombre.Image = ((System.Drawing.Image)(resources.GetObject("pbNombre.Image")));
            this.pbNombre.Location = new System.Drawing.Point(116, 192);
            this.pbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbNombre.Name = "pbNombre";
            this.pbNombre.Size = new System.Drawing.Size(26, 23);
            this.pbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNombre.TabIndex = 24;
            this.pbNombre.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(116, 231);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 154);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivo.Location = new System.Drawing.Point(165, 265);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(118, 21);
            this.lblActivo.TabIndex = 29;
            this.lblActivo.Text = "Estado: Activo";
            // 
            // rdActivo
            // 
            this.rdActivo.AutoSize = true;
            this.rdActivo.Checked = true;
            this.rdActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdActivo.Location = new System.Drawing.Point(116, 264);
            this.rdActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdActivo.MinimumSize = new System.Drawing.Size(45, 21);
            this.rdActivo.Name = "rdActivo";
            this.rdActivo.OffBackColor = System.Drawing.Color.Gray;
            this.rdActivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rdActivo.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rdActivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rdActivo.Size = new System.Drawing.Size(45, 21);
            this.rdActivo.TabIndex = 28;
            this.rdActivo.UseVisualStyleBackColor = true;
            this.rdActivo.CheckedChanged += new System.EventHandler(this.rdActivo_CheckedChanged);
            // 
            // rjMostrar
            // 
            this.rjMostrar.AutoSize = true;
            this.rjMostrar.Checked = true;
            this.rjMostrar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjMostrar.Location = new System.Drawing.Point(334, 232);
            this.rjMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjMostrar.MinimumSize = new System.Drawing.Size(45, 21);
            this.rjMostrar.Name = "rjMostrar";
            this.rjMostrar.OffBackColor = System.Drawing.Color.Gray;
            this.rjMostrar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjMostrar.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjMostrar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjMostrar.Size = new System.Drawing.Size(45, 21);
            this.rjMostrar.TabIndex = 27;
            this.rjMostrar.UseVisualStyleBackColor = true;
            this.rjMostrar.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(385, 354);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.rdActivo);
            this.Controls.Add(this.rjMostrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbNombre);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.pbUsu);
            this.Controls.Add(this.pbID);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de empleados";
            this.Load += new System.EventHandler(this.ModificacionTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.PictureBox pbUsu;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.PictureBox pbNombre;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controles_Personalizados.RJToggleButton rjMostrar;
        private Controles_Personalizados.RJToggleButton rdActivo;
        private System.Windows.Forms.Label lblActivo;
    }
}