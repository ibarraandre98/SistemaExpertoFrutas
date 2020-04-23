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
            String query = "es_fruta(" +
                "FRUTA," +
                cbForma.Text.ToString() + "," +
                cbColores.Text.ToString() + "," +
                cbPiedra.Text.ToString() + "," +
                cbAcido.Text.ToString() + "," +
                cbTallo.Text.ToString()+
                ")";


            PlQuery consulta = new PlQuery(query);
            foreach (PlQueryVariables z in consulta.SolutionVariables)
            {
                labelFruta.Text = z["FRUTA"].ToString();
            }
            if (labelFruta.Text.Equals("manzana"))
            {
                pbImagen.Image = Properties.Resources.manzana;
            }
            if (labelFruta.Text.Equals("platano"))
            {
                pbImagen.Image = Properties.Resources.platano;
            }
            if (labelFruta.Text.Equals("limon"))
            {
                pbImagen.Image = Properties.Resources.limon;
            }
            if (labelFruta.Text.Equals("pera"))
            {
                pbImagen.Image = Properties.Resources.pera;
            }
            if (labelFruta.Text.Equals("ciruela"))
            {
                pbImagen.Image = Properties.Resources.ciruela;
            }
            if (labelFruta.Text.Equals("uva"))
            {
                pbImagen.Image = Properties.Resources.uva;
            }
            if (labelFruta.Text.Equals("naranja"))
            {
                pbImagen.Image = Properties.Resources.naranja;
            }
            if (labelFruta.Text.Equals("mandarina"))
            {
                pbImagen.Image = Properties.Resources.mandarina;
            }
            if (labelFruta.Text.Equals("mango"))
            {
                pbImagen.Image = Properties.Resources.mango;
            }
            if (labelFruta.Text.Equals("cereza"))
            {
                pbImagen.Image = Properties.Resources.cereza;
            }
            PlEngine.PlCleanup();
        }
    }
}
