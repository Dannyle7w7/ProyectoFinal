namespace ProyectoFinal.Submenus.Carrito
{
    partial class Productos
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnEnviaAcarrito = new System.Windows.Forms.Button();
            this.DvgProductos = new System.Windows.Forms.DataGridView();
            this.plTop = new System.Windows.Forms.Panel();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidadtotal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DvgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Location = new System.Drawing.Point(547, 533);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(168, 42);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEnviaAcarrito
            // 
            this.btnEnviaAcarrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviaAcarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(214)))), ((int)(((byte)(180)))));
            this.btnEnviaAcarrito.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEnviaAcarrito.Location = new System.Drawing.Point(347, 533);
            this.btnEnviaAcarrito.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviaAcarrito.Name = "btnEnviaAcarrito";
            this.btnEnviaAcarrito.Size = new System.Drawing.Size(161, 42);
            this.btnEnviaAcarrito.TabIndex = 18;
            this.btnEnviaAcarrito.Text = "Enviar a carrito";
            this.btnEnviaAcarrito.UseVisualStyleBackColor = false;
            this.btnEnviaAcarrito.Click += new System.EventHandler(this.btnEnviaAcarrito_Click);
            // 
            // DvgProductos
            // 
            this.DvgProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(214)))), ((int)(((byte)(180)))));
            this.DvgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgProductos.GridColor = System.Drawing.Color.Black;
            this.DvgProductos.Location = new System.Drawing.Point(16, 136);
            this.DvgProductos.Margin = new System.Windows.Forms.Padding(4);
            this.DvgProductos.Name = "DvgProductos";
            this.DvgProductos.Size = new System.Drawing.Size(992, 231);
            this.DvgProductos.TabIndex = 20;
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(1020, 42);
            this.plTop.TabIndex = 21;
            // 
            // TxtProducto
            // 
            this.TxtProducto.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.TxtProducto.Location = new System.Drawing.Point(16, 77);
            this.TxtProducto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(991, 25);
            this.TxtProducto.TabIndex = 23;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblProducto.Location = new System.Drawing.Point(186, 383);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(192, 28);
            this.lblProducto.TabIndex = 24;
            this.lblProducto.Text = "Nombre producto :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(153, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Introduce la cantidad :";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.TxtCantidad.Location = new System.Drawing.Point(393, 428);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(267, 29);
            this.TxtCantidad.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(289, 472);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Precio :  $";
            // 
            // lblCantidadtotal
            // 
            this.lblCantidadtotal.AutoSize = true;
            this.lblCantidadtotal.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCantidadtotal.Location = new System.Drawing.Point(399, 472);
            this.lblCantidadtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadtotal.Name = "lblCantidadtotal";
            this.lblCantidadtotal.Size = new System.Drawing.Size(58, 30);
            this.lblCantidadtotal.TabIndex = 29;
            this.lblCantidadtotal.Text = "0.00";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(393, 383);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 30);
            this.lblNombre.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Da doble click sobre el Nombre para seleccionar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ingresa algun nombre para comenzar la busqueda:";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 603);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCantidadtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.DvgProductos);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnEnviaAcarrito);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnEnviaAcarrito;
        private System.Windows.Forms.DataGridView DvgProductos;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadtotal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}