using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILiquidacionCuota
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object formhijo)
        {
            if (this.PanelEscritorio.Controls.Count > 0)
                this.PanelEscritorio.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelEscritorio.Controls.Add(fh);
            this.PanelEscritorio.Tag = fh;
            fh.Show();
        }

        private void calcularCuotaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CalcularCuota());
        }

        private void mostrarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Consultar());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
