namespace ProyectoFinal
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnEquipo = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.msQuitarBarra = new System.Windows.Forms.MenuStrip();
            this.plControles = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.plControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEquipo
            // 
            this.btnEquipo.Location = new System.Drawing.Point(359, 74);
            this.btnEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(140, 26);
            this.btnEquipo.TabIndex = 2;
            this.btnEquipo.Text = "F7 Equipo";
            this.btnEquipo.UseVisualStyleBackColor = true;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(115, 11);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 25);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuario.Image")));
            this.pbUsuario.Location = new System.Drawing.Point(11, 10);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(99, 102);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 0;
            this.pbUsuario.TabStop = false;
            // 
            // msQuitarBarra
            // 
            this.msQuitarBarra.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msQuitarBarra.Location = new System.Drawing.Point(0, 0);
            this.msQuitarBarra.Name = "msQuitarBarra";
            this.msQuitarBarra.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msQuitarBarra.Size = new System.Drawing.Size(692, 29);
            this.msQuitarBarra.TabIndex = 3;
            this.msQuitarBarra.Text = "menuStrip1";
            this.msQuitarBarra.Visible = false;
            // 
            // plControles
            // 
            this.plControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.plControles.Controls.Add(this.btnConfiguracion);
            this.plControles.Controls.Add(this.btnInventario);
            this.plControles.Controls.Add(this.btnCompras);
            this.plControles.Controls.Add(this.btnProveedores);
            this.plControles.Controls.Add(this.lblPuesto);
            this.plControles.Controls.Add(this.btnVenta);
            this.plControles.Controls.Add(this.btnClientes);
            this.plControles.Controls.Add(this.pbUsuario);
            this.plControles.Controls.Add(this.btnEquipo);
            this.plControles.Controls.Add(this.lblUsuario);
            this.plControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.plControles.Location = new System.Drawing.Point(0, 0);
            this.plControles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plControles.Name = "plControles";
            this.plControles.Size = new System.Drawing.Size(692, 120);
            this.plControles.TabIndex = 5;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(512, 43);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(140, 26);
            this.btnConfiguracion.TabIndex = 9;
            this.btnConfiguracion.Text = "F6 Configuracion";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(214, 43);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(140, 26);
            this.btnInventario.TabIndex = 8;
            this.btnInventario.Text = "F4 Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(359, 43);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(140, 26);
            this.btnCompras.TabIndex = 7;
            this.btnCompras.Text = "F5 Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(512, 13);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(140, 26);
            this.btnProveedores.TabIndex = 6;
            this.btnProveedores.Text = "F3 Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPuesto.Location = new System.Drawing.Point(129, 48);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(92, 30);
            this.lblPuesto.TabIndex = 5;
            this.lblPuesto.Text = "Usuario";
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(214, 13);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(140, 26);
            this.btnVenta.TabIndex = 4;
            this.btnVenta.Text = "F1 Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(359, 13);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(140, 26);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "F2 Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 435);
            this.Controls.Add(this.plControles);
            this.Controls.Add(this.msQuitarBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.msQuitarBarra;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.plControles.ResumeLayout(false);
            this.plControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MenuStrip msQuitarBarra;
        private System.Windows.Forms.Panel plControles;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnProveedores;
    }
}