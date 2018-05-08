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
    public partial class Form1 : Form
    {
        private char[] chr;
        private int i;
        private bool perguntas = false;

        private int pontos = 0;
        private Aula aula = new Aula
            (
                "ATA", "clebao", "Matematica", new Pagina[]
                {
                    new Pagina("    Ata é uma palavra constantemente falada pela população com alto nivel de instrução no brasil.\n    Essa Palavra pode ter muitos significados, como:\n-JOOJ\n-JOOJ\n-JOOJ\n-JOOJ\n\n    Ata é uma palavra constantemente falada pela população com alto nivel de instrução no brasil.\n\n    Essa Palavra pode ter muitos significados, como:\n-JOOJ\n-JOOJ\n-JOOJ\n-JOOJ\n"),
                    new Pagina("    Ata é uma palavra constantemente falada pela população com alto nivel de instrução no brasil.\n    Essa Palavra pode ter muitos significados, como:\n-JOOJ\n-JOOJ\n-JOOJ\n-JOOJ\n\n    Ata é uma palavra constantemente falada pela população com alto nivel de instrução no brasil.\n\n    Essa Palavra pode ter muitos significados, como:\n-JOOJ\n-JOOJ\n-JOOJ\n-JOOJ\n"),
                }, new Pergunta[]
                {
                    new Pergunta("Quem é o jooj1?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA",'A'),
                    new Pergunta("Quem é o jooj2?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA",'A'),
                    new Pergunta("Quem é o jooj3?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA",'A'),
                    new Pergunta("Quem é o jooj4?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA",'A'),
                    new Pergunta("Quem é o jooj5?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA","Jooj?AAAAAAAAA",'A'),
                }
            );
        private int perguntaAtual = -1;
        private int paginaAtual = -1;

        public Form1(string titulo)
        {
            InitializeComponent();
            this.aula = Aulas.GetAula(titulo);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text.ToCharArray()[0] == this.aula.Perguntas[this.perguntaAtual].Certa)
            {
                ((Button)sender).BackColor = Color.Green;
                //korofica certin
                picBKoro.Image = ProjetoPratica.Properties.Resources.carakoro1;
                pontos ++;
            }
            else
            {
                ((Button)sender).BackColor = Color.DarkRed;
                //korofica erradin
                picBKoro.Image = ProjetoPratica.Properties.Resources.carakoro2;
            }
            //desativar os botões
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            Timer timer = new Timer();
            timer.Interval = 1500;
            timer.Enabled = true;
            timer.Tick += (s, args) =>
            {
                btnA.BackColor = Color.DimGray;
                btnB.BackColor = Color.DimGray;
                btnC.BackColor = Color.DimGray;
                btnD.BackColor = Color.DimGray;

                picBKoro.Image = ProjetoPratica.Properties.Resources.carakoro0;

                lblA.Text = "";
                lblB.Text = "";
                lblC.Text = "";
                lblD.Text = "";

                timer.Enabled = false;
                if (this.perguntaAtual == this.aula.Perguntas.Length-1)
                {
                    groupBox1.Visible = false;
                    lblNomeAula.Text = "Você fez " + Convert.ToInt32(1000*this.pontos/this.aula.Perguntas.Length) + " pontos";

                    btnComecar.Enabled = true;
                    btnComecar.Text = "Recomeçar";
                    lblNomeProf.Visible = false;

                    modoPergunta(false);

                    paginaAtual = -1;
                    perguntaAtual = -1;
                    return;
                }
                carregarProxPerg();
            };
        }

        private void carregarProxPerg()
        {
            this.perguntaAtual++;
            this.koroFalar(this.aula.Perguntas[this.perguntaAtual].TextoAlternativa, Color.Black);
        }

        private void koroFalar(string oq, Color cor)
        {
            timer1.Enabled = true;
            i = -1;
            lblContent.Text = "";
            lblContent.ForeColor = cor;

            this.chr = oq.ToArray();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > -1 && i < chr.Length)
            {
                lblContent.Text = lblContent.Text + chr[i];
                i++;
            }
            else if (i < 0)
                i++;
            else
            {
                if (this.perguntas)
                {
                    lblA.Text = this.aula.Perguntas[this.perguntaAtual].AlternativaA;
                    lblB.Text = this.aula.Perguntas[this.perguntaAtual].AlternativaB;
                    lblC.Text = this.aula.Perguntas[this.perguntaAtual].AlternativaC;
                    lblD.Text = this.aula.Perguntas[this.perguntaAtual].AlternativaD;

                    btnA.Enabled = true;
                    btnB.Enabled = true;
                    btnC.Enabled = true;
                    btnD.Enabled = true;
                }
                timer1.Enabled = false;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lblNomeAula.Text = this.aula.Titulo;
            lblNomeProf.Text = this.aula.Professor;
        }

        private void carregarProxPagina()
        {
            this.paginaAtual++;
            koroFalar(this.aula.Paginas[this.paginaAtual].Texto, Color.Black);
        }
        private void carregarAntPagina()
        {
            this.paginaAtual--;
            koroFalar(this.aula.Paginas[this.paginaAtual].Texto, Color.Black);
        }

        private void btnAnt_Click(object sender, EventArgs e)
        { 
            carregarAntPagina();
            if (this.paginaAtual == 0)
                btnAnt.Enabled = false;
            btnProx.Enabled = true;
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            carregarProxPagina();
            if (this.paginaAtual == this.aula.Paginas.Length - 1)
            {
                btnProx.Enabled = false;
                button1.Enabled = true;
            }

            btnAnt.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modoPergunta(true);
            lblA.Text = "";
            lblB.Text = "";
            lblC.Text = "";
            lblD.Text = "";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            carregarProxPerg();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            this.pontos = 0;
            carregarProxPagina();
            btnComecar.Enabled = false;
            if (this.aula.Paginas.Length == 1)
            {
                btnProx.Enabled = false;
                button1.Enabled = true;
            }
        }


        private void modoPergunta(bool b)
        {
            perguntas = b;
            button1.Visible = !b;
            btnProx.Visible = !b;
            btnAnt.Visible = !b;

            btnA.Visible = b;
            btnB.Visible = b;
            btnD.Visible = b;
            btnC.Visible = b;

            lblA.Visible = b;
            lblB.Visible = b;
            lblC.Visible = b;
            lblD.Visible = b;
        }
        private void btnRecomeçar_Click(object sender, EventArgs e)
        {
            modoPergunta(false);
            lblNomeProf.Visible = true;
            lblNomeAula.Text = this.aula.Titulo;
            btnComecar.Enabled = true;

            paginaAtual = -1;
            perguntaAtual = -1;
            btnAnt.Enabled = false;
            btnProx.Enabled = true;
            groupBox1.Visible = false;
        }
    }
}