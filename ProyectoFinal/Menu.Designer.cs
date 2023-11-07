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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.plControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEquipo
            // 
            this.btnEquipo.Location = new System.Drawing.Point(372, 16);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(105, 32);
            this.btnEquipo.TabIndex = 2;
            this.btnEquipo.Text = "F12 Equipo";
            this.btnEquipo.UseVisualStyleBackColor = true;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(129, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(92, 30);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuario.Image")));
            this.pbUsuario.Location = new System.Drawing.Point(12, 12);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(111, 127);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 0;
            this.pbUsuario.TabStop = false;
            // 
            // msQuitarBarra
            // 
            this.msQuitarBarra.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msQuitarBarra.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msQuitarBarra.Location = new System.Drawing.Point(0, 0);
            this.msQuitarBarra.Name = "msQuitarBarra";
            this.msQuitarBarra.Size = new System.Drawing.Size(778, 36);
            this.msQuitarBarra.TabIndex = 3;
            this.msQuitarBarra.Text = "menuStrip1";
            this.msQuitarBarra.Visible = false;
            // 
            // plControles
            // 
            this.plControles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.plControles.Controls.Add(this.button4);
            this.plControles.Controls.Add(this.button3);
            this.plControles.Controls.Add(this.button2);
            this.plControles.Controls.Add(this.button1);
            this.plControles.Controls.Add(this.label1);
            this.plControles.Controls.Add(this.btnVenta);
            this.plControles.Controls.Add(this.btnClientes);
            this.plControles.Controls.Add(this.pbUsuario);
            this.plControles.Controls.Add(this.btnEquipo);
            this.plControles.Controls.Add(this.lblUsuario);
            this.plControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.plControles.Location = new System.Drawing.Point(0, 0);
            this.plControles.Name = "plControles";
            this.plControles.Size = new System.Drawing.Size(778, 150);
            this.plControles.TabIndex = 5;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(241, 54);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(157, 32);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "F11 Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(241, 16);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(105, 32);
            this.btnVenta.TabIndex = 4;
            this.btnVenta.Text = "F12 Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(129, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "F12 Inventario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "F12 Inventario";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "F12 Inventario";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(576, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "F12 Inventario";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.plControles);
            this.Controls.Add(this.msQuitarBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.msQuitarBarra;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}