using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SbsSW.SwiPlCs;

namespace SistemaExpertoFrutas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstElementComboBox();
        }

        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            inicializarProlog();
            adivinar();
        }

        private void inicializarProlog()
        {
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
            String[] p = { "-q", "-f", @"frutas.pl" };
            PlEngine.Initialize(p);
        }

        private void firstElementComboBox()
        {
            cbColores.SelectedIndex = 0;
            cbForma.SelectedIndex = 0;
            cbAcido.SelectedIndex = 0;
            cbTallo.SelectedIndex = 0;
            cbPiedra.SelectedIndex = 0;
        }

        public void adivinar()
        {

            String nForma = cbForma.Text.ToString();
            if (nForma.Equals("esfera aplanada"))
            {
                nForma = "'esfera aplanada'";
            }
            if(nForma.Equals("esfera conica"))
            {
                nForma = "'esfera conica'";
            }
            String query = "es_fruta(" +
                "FRUTA," +
                nForma + "," +
                cbColores.Text.ToString() + "," +
                cbPiedra.Text.ToString() + "," +
                cbAcido.Text.ToString() + "," +
                cbTallo.Text.ToString()+
                ")";

            labelFruta.Text = "";
            PlQuery consulta = new PlQuery(query);
            foreach (PlQueryVariables z in consulta.SolutionVariables)
            {
               //MessageBox.Show(z["FRUTA"].ToString());
                labelFruta.Text = z["FRUTA"].ToString();
                
            }
            if (labelFruta.Text.Equals("manzana"))
            {
                pbImagen.Image = Properties.Resources.manzana;
            }
            else if (labelFruta.Text.Equals("platano"))
            {
                pbImagen.Image = Properties.Resources.platano;
            }
            else if (labelFruta.Text.Equals("limon"))
            {
                pbImagen.Image = Properties.Resources.limon;
            }
            else if (labelFruta.Text.Equals("pera"))
            {
                pbImagen.Image = Properties.Resources.pera;
            }
            else if (labelFruta.Text.Equals("ciruela"))
            {
                pbImagen.Image = Properties.Resources.ciruela;
            }
            else if (labelFruta.Text.Equals("uva"))
            {
                pbImagen.Image = Properties.Resources.uva;
            }
            else if (labelFruta.Text.Equals("naranja"))
            {
                pbImagen.Image = Properties.Resources.naranja;
            }
            else if (labelFruta.Text.Equals("mandarina"))
            {
                pbImagen.Image = Properties.Resources.mandarina;
            }
            else if (labelFruta.Text.Equals("mango"))
            {
                pbImagen.Image = Properties.Resources.mango;
            }
            else if (labelFruta.Text.Equals("cereza"))
            {
                pbImagen.Image = Properties.Resources.cereza;
            }
            else
            {
                pbImagen.Image = null;
                labelFruta.Text = "Ninguna";
                pbImagen.Refresh();
            }
            labelFruta.Text = labelFruta.Text.ToUpperInvariant();
            PlEngine.PlCleanup();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
