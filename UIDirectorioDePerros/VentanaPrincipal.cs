using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BnsDirectorioDePerros;

namespace UIDirectorioDePerros
{
    public partial class VentanaPrincipal : Form
    {
        public Directorio DirectorioPrincipal { get; set; }
        public VentanaPrincipal()
        {
            InitializeComponent();
            DirectorioPrincipal = new Directorio();
            CargarPanelPrincipal();
        }

        private void CargarPanelPrincipal()
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarDuenio = new AgregarDuenio();
            panelPrincipal.Controls.Add(agregarDuenio);
        }

        private void btnAgregarDuenio_Click(object sender, EventArgs e)
        {
            CargarPanelPrincipal();
        }

        private void btnAgregarPerro_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarPerro = new AgregarPerro();
            panelPrincipal.Controls.Add(agregarPerro);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl  verPerros = new VerPerros();
            panelPrincipal.Controls.Add(verPerros);
        }
    }
}
