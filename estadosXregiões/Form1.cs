using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estadosXregiões
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string est = cboLista1.Text.ToString();
            if (est == "São Paulo (SP)" | est == "Rio de Janeiro (RJ)" | est == "Espiranto Santo (ES)" | est== "Minas Gerais (MG)")
            {
                cboSudeste.Items.Add(cboLista1.SelectedItem);
                cboLista1.Items.Remove(cboLista1.SelectedItem);
                lblEst.Text = cboLista1.Items.Count.ToString();
                lblSudeste.Text = cboSudeste.Items.Count.ToString();
            }
            else if (est == "Pará (PA)" | est == "Tocantins (TO)" | est == "Amazonas (AM)" | est == "Amapá (AP)" | est == "Roraima (RR)" | est == "Rondônia (RO)" | est == "Acre (AC)")
            {
                cboNorte.Items.Add(cboLista1.SelectedItem);
                cboLista1.Items.Remove(cboLista1.SelectedItem);
                lblNorte.Text = cboNorte.Items.Count.ToString();
                lblEst.Text = cboLista1.Items.Count.ToString();
            }
            if (est == "Paraíba (PB)" | est == "Pernambuco (PE)" | est == "Maranhão (MA)" | est == "Bahia (BA)" | est == "Alagoas (AL)" | est == "Ceará (CE)" | est == "Rio Grande do Norte (RN)" | est == "Piauí (PI)" | est == "Sergipe (SE)")
            {
                cboNordeste.Items.Add(cboLista1.SelectedItem);
                cboLista1.Items.Remove(cboLista1.SelectedItem);
                lblNordeste.Text = cboNordeste.Items.Count.ToString();
                lblEst.Text = cboLista1.Items.Count.ToString();
            }
            else if (est == "Goiás (GO)" | est == "Mato Grosso do Sul (MS)" | est == "Mato Grosso (MT)" | est == "Distrito Federal (DF)")
            {
                cboCentro.Items.Add(cboLista1.SelectedItem);
                lblEst.Text = cboLista1.Items.Count.ToString();
                cboLista1.Items.Remove(cboLista1.SelectedItem);
                lblCentro.Text = cboCentro.Items.Count.ToString();
            }
            if (est == "Rio Grande do Sul (RS)" | est == "Santa Catarina (SC)" |  est == "Paraná (PR)")
            {
                cboSul.Items.Add(cboLista1.SelectedItem);
                lblEst.Text = cboLista1.Items.Count.ToString();
                cboLista1.Items.Remove(cboLista1.SelectedItem);
                lblSul.Text = cboSul.Items.Count.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboNorte.Items.Add(cboLista1.SelectedItem);
            cboNorte.Items.Remove(cboNorte.SelectedItem);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void cboLista1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboNorte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
