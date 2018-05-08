using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPratica
{
    public partial class CriarMateria : Form
    {
        private string a = "";
        private string b = "";
        private string c = "";
        private string d = "";
        private string anterior = "A";
        private Pergunta[] perguntas = new Pergunta[6];

        public CriarMateria()
        {
            InitializeComponent();
        }

        private void cbxAlternativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (anterior == "A")
                a = txtAlternativa.Text;

            if (anterior == "B")
                b = txtAlternativa.Text;

            if (anterior == "C")
                c = txtAlternativa.Text;

            if (anterior == "D")
                d = txtAlternativa.Text;

            anterior = cbxAlternativa.SelectedText;

            if (anterior == "A")
                txtAlternativa.Text = a;

            if (anterior == "B")
                txtAlternativa.Text = b;

            if (anterior == "C")
                txtAlternativa.Text = c;

            if (anterior == "D")
                txtAlternativa.Text = d;

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Voce deve preencher todos os campos!!");
                return;
            }

            if (anterior == "A")
                txtAlternativa.Text = a;

            if (anterior == "B")
                txtAlternativa.Text = b;

            if (anterior == "C")
                txtAlternativa.Text = c;

            if (anterior == "D")
                txtAlternativa.Text = d;



            if (string.IsNullOrWhiteSpace(a))
            {
                MessageBox.Show("Voce deve preencher todas as alternativas!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(b))
            {
                MessageBox.Show("Voce deve preencher todas as alternativas!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(c))
            {
                MessageBox.Show("Voce deve preencher todas as alternativas!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(d))
            {
                MessageBox.Show("Voce deve preencher todas as alternativas!!");
                return;
            }

            if (!rbA.Checked && !rbB.Checked && !rbC.Checked && !rbD.Checked)
            {
                MessageBox.Show("Voce deve selecionar alguma reposta como a certa");
            }
        }
    }
}
