namespace ProyectoFinal
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.rjMostrar = new ProyectoFinal.Controles_Personalizados.RJToggleButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbNombre = new System.Windows.Forms.PictureBox();
            this.pbUsu = new System.Windows.Forms.PictureBox();
            this.pbID = new System.Windows.Forms.PictureBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rjMostrar
            // 
            this.rjMostrar.AutoSize = true;
            this.rjMostrar.Checked = true;
            this.rjMostrar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rjMostrar.Location = new System.Drawing.Point(499, 351);
            this.rjMostrar.MinimumSize = new System.Drawing.Size(68, 33);
            this.rjMostrar.Name = "rjMostrar";
            this.rjMostrar.OffBackColor = System.Drawing.Color.Gray;
            this.rjMostrar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjMostrar.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjMostrar.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjMostrar.Size = new System.Drawing.Size(68, 33);
            this.rjMostrar.TabIndex = 45;
            this.rjMostrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(172, 349);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pbNombre
            // 
            this.pbNombre.Image = ((System.Drawing.Image)(resources.GetObject("pbNombre.Image")));
            this.pbNombre.Location = new System.Drawing.Point(172, 290);
            this.pbNombre.Name = "pbNombre";
            this.pbNombre.Size = new System.Drawing.Size(39, 35);
            this.pbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNombre.TabIndex = 42;
            this.pbNombre.TabStop = false;
            // 
            // pbUsu
            // 
            this.pbUsu.Image = ((System.Drawing.Image)(resources.GetObject("pbUsu.Image")));
            this.pbUsu.Location = new System.Drawing.Point(172, 221);
            this.pbUsu.Name = "pbUsu";
            this.pbUsu.Size = new System.Drawing.Size(39, 35);
            this.pbUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsu.TabIndex = 40;
            this.pbUsu.TabStop = false;
            // 
            // pbID
            // 
            this.pbID.Image = ((System.Drawing.Image)(resources.GetObject("pbID.Image")));
            this.pbID.Location = new System.Drawing.Point(172, 162);
            this.pbID.Name = "pbID";
            this.pbID.Size = new System.Drawing.Size(39, 35);
            this.pbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbID.TabIndex = 39;
            this.pbID.TabStop = false;
            // 
            // pbFoto
            // 
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(12, 122);
            this.pbFoto.MaximumSize = new System.Drawing.Size(150, 180);
            this.pbFoto.MinimumSize = new System.Drawing.Size(150, 180);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(150, 180);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 37;
            this.pbFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.AutoSize = true;
            this.btnFoto.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFoto.Location = new System.Drawing.Point(12, 316);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(150, 76);
            this.btnFoto.TabIndex = 36;
            this.btnFoto.Text = "Cargar \r\nImagen";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtID.Location = new System.Drawing.Point(217, 163);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(276, 39);
            this.txtID.TabIndex = 34;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(218, 290);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 39);
            this.txtNombre.TabIndex = 33;
            this.txtNombre.Text = "Nombre";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(217, 221);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(276, 39);
            this.txtUsuario.TabIndex = 32;
            this.txtUsuario.Text = "Usuario";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(578, 100);
            this.pnlTitulo.TabIndex = 38;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Beige;
            this.lblTitulo.Location = new System.Drawing.Point(233, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 45);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Perfil";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtContra.ForeColor = System.Drawing.Color.Gray;
            this.txtContra.Location = new System.Drawing.Point(217, 348);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(276, 39);
            this.txtContra.TabIndex = 35;
            this.txtContra.Text = "Contraseña";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(194, 432);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(201, 78);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Actualizar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.Controls.Add(this.rjMostrar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbNombre);
            this.Controls.Add(this.pbUsu);
            this.Controls.Add(this.pbID);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Personalizados.RJToggleButton rjMostrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbNombre;
        private System.Windows.Forms.PictureBox pbUsu;
        private System.Windows.Forms.PictureBox pbID;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnFoto;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.TextBox txtContra;
        public System.Windows.Forms.Button btnModificar;
    }
}