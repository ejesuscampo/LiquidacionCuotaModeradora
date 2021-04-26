
namespace GUILiquidacionCuota
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuotaModeradoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularCuotaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelEscritorio = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuotaModeradoraToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuotaModeradoraToolStripMenuItem
            // 
            this.cuotaModeradoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularCuotaToolStripMenuItem1,
            this.mostrarRegistroToolStripMenuItem});
            this.cuotaModeradoraToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuotaModeradoraToolStripMenuItem.Name = "cuotaModeradoraToolStripMenuItem";
            this.cuotaModeradoraToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.cuotaModeradoraToolStripMenuItem.Text = "Cuota Moderadora";
            // 
            // calcularCuotaToolStripMenuItem1
            // 
            this.calcularCuotaToolStripMenuItem1.Name = "calcularCuotaToolStripMenuItem1";
            this.calcularCuotaToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.calcularCuotaToolStripMenuItem1.Text = "Calcular Cuota";
            this.calcularCuotaToolStripMenuItem1.Click += new System.EventHandler(this.calcularCuotaToolStripMenuItem1_Click);
            // 
            // mostrarRegistroToolStripMenuItem
            // 
            this.mostrarRegistroToolStripMenuItem.Name = "mostrarRegistroToolStripMenuItem";
            this.mostrarRegistroToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.mostrarRegistroToolStripMenuItem.Text = "Mostrar Registro";
            this.mostrarRegistroToolStripMenuItem.Click += new System.EventHandler(this.mostrarRegistroToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // PanelEscritorio
            // 
            this.PanelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEscritorio.Location = new System.Drawing.Point(0, 30);
            this.PanelEscritorio.Name = "PanelEscritorio";
            this.PanelEscritorio.Size = new System.Drawing.Size(1382, 723);
            this.PanelEscritorio.TabIndex = 2;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.PanelEscritorio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liquidacion Cuota Moderadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuotaModeradoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularCuotaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel PanelEscritorio;
    }
}

