namespace ProyectoFinal.Submenus.Trabajadores
{
    partial class Trabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trabajadores));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.rdTodos = new System.Windows.Forms.RadioButton();
            this.rdActivo = new System.Windows.Forms.RadioButton();
            this.rdInactivo = new System.Windows.Forms.RadioButton();
            this.plTop = new System.Windows.Forms.Panel();
            this.tlpBusquedayAgregar = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.pbTrabajadores = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tlpBusquedayAgregar.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(214)))), ((int)(((byte)(180)))));
            this.dgvDatos.ColumnHeadersHeight = 34;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Location = new System.Drawing.Point(16, 257);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(566, 314);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusqueda.Location = new System.Drawing.Point(3, 20);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(562, 39);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.Text = "Búsqueda";
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.Enter += new System.EventHandler(this.txtBusqueda_Enter);
            // 
            // btAgregar
            // 
            this.btAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAgregar.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(571, 3);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(194, 74);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Nuevo\r\nEmpleado";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // rdTodos
            // 
            this.rdTodos.AutoSize = true;
            this.rdTodos.Location = new System.Drawing.Point(3, 3);
            this.rdTodos.Name = "rdTodos";
            this.rdTodos.Size = new System.Drawing.Size(102, 35);
            this.rdTodos.TabIndex = 3;
            this.rdTodos.TabStop = true;
            this.rdTodos.Text = "Todos";
            this.rdTodos.UseVisualStyleBackColor = true;
            this.rdTodos.CheckedChanged += new System.EventHandler(this.rdTodos_CheckedChanged);
            // 
            // rdActivo
            // 
            this.rdActivo.AutoSize = true;
            this.rdActivo.Location = new System.Drawing.Point(3, 44);
            this.rdActivo.Name = "rdActivo";
            this.rdActivo.Size = new System.Drawing.Size(115, 35);
            this.rdActivo.TabIndex = 4;
            this.rdActivo.TabStop = true;
            this.rdActivo.Text = "Activos";
            this.rdActivo.UseVisualStyleBackColor = true;
            this.rdActivo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdInactivo
            // 
            this.rdInactivo.AutoSize = true;
            this.rdInactivo.Location = new System.Drawing.Point(3, 85);
            this.rdInactivo.Name = "rdInactivo";
            this.rdInactivo.Size = new System.Drawing.Size(122, 36);
            this.rdInactivo.TabIndex = 5;
            this.rdInactivo.TabStop = true;
            this.rdInactivo.Text = "Inactivo";
            this.rdInactivo.UseVisualStyleBackColor = true;
            this.rdInactivo.CheckedChanged += new System.EventHandler(this.rdInactivo_CheckedChanged);
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(800, 151);
            this.plTop.TabIndex = 7;
            // 
            // tlpBusquedayAgregar
            // 
            this.tlpBusquedayAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBusquedayAgregar.ColumnCount = 2;
            this.tlpBusquedayAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBusquedayAgregar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpBusquedayAgregar.Controls.Add(this.btAgregar, 1, 0);
            this.tlpBusquedayAgregar.Controls.Add(this.txtBusqueda, 0, 0);
            this.tlpBusquedayAgregar.Location = new System.Drawing.Point(16, 171);
            this.tlpBusquedayAgregar.Name = "tlpBusquedayAgregar";
            this.tlpBusquedayAgregar.RowCount = 1;
            this.tlpBusquedayAgregar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBusquedayAgregar.Size = new System.Drawing.Size(768, 80);
            this.tlpBusquedayAgregar.TabIndex = 8;
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFiltros.ColumnCount = 1;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Controls.Add(this.rdTodos, 0, 0);
            this.tlpFiltros.Controls.Add(this.rdInactivo, 0, 2);
            this.tlpFiltros.Controls.Add(this.rdActivo, 0, 1);
            this.tlpFiltros.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.tlpFiltros.Location = new System.Drawing.Point(588, 257);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 3;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFiltros.Size = new System.Drawing.Size(196, 125);
            this.tlpFiltros.TabIndex = 9;
            // 
            // pbTrabajadores
            // 
            this.pbTrabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTrabajadores.Image = ((System.Drawing.Image)(resources.GetObject("pbTrabajadores.Image")));
            this.pbTrabajadores.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbTrabajadores.InitialImage")));
            this.pbTrabajadores.Location = new System.Drawing.Point(589, 390);
            this.pbTrabajadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbTrabajadores.Name = "pbTrabajadores";
            this.pbTrabajadores.Size = new System.Drawing.Size(192, 181);
            this.pbTrabajadores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrabajadores.TabIndex = 10;
            this.pbTrabajadores.TabStop = false;
            // 
            // Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pbTrabajadores);
            this.Controls.Add(this.tlpFiltros);
            this.Controls.Add(this.tlpBusquedayAgregar);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Trabajadores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajadores";
            this.Load += new System.EventHandler(this.Trabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tlpBusquedayAgregar.ResumeLayout(false);
            this.tlpBusquedayAgregar.PerformLayout();
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrabajadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.RadioButton rdTodos;
        private System.Windows.Forms.RadioButton rdActivo;
        private System.Windows.Forms.RadioButton rdInactivo;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.TableLayoutPanel tlpBusquedayAgregar;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.PictureBox pbTrabajadores;
    }
}