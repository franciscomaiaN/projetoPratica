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

    public partial class FrmPrincipal : Form
    {
        private Aluno aluno = null;
        private Professor professor = null;
        private string[,] aula;

        public Aluno Aluno
        {
            get
            {
                return this.aluno;
            }
            set
            {
                if (value != null)
                    this.aluno = value;
            }
        }

        public Professor Professor
        {
            get
            {
                return this.professor;
            }
            set
            {
                if (value != null)
                    this.professor = value;
            }
        }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Shown(object sender, EventArgs e)
        {
            if(this.aluno == null)
            {
                this.Hide();
                Login lg = new Login();
                lg.FormClosed += (s, args) => {
                    if (lg.Aluno != null)
                    {
                        this.Show();
                        this.Aluno = lg.Aluno;
                        this.lblUser.Text = this.aluno.Usuario;
                        this.lblNome.Text = this.aluno.Nome;
                        this.lblIdade.Text = this.aluno.Idade + " anos";
                        label4.Visible = true;
                    }
                    else
                        if (lg.Professor != null)
                        {
                            this.Show();
                            this.Professor = lg.Professor;
                            this.lblUser.Text = this.professor.Usuario;
                            this.lblNome.Text = this.professor.Nome;
                            label4.Visible = false;
                        }
                        else
                            this.Close();
                };
                lg.Show();               
            }
        }

        private void alunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            this.aluno = null;
            this.Hide();
            Login lg = new Login();
            lg.FormClosed += (s, args) => {

                if (lg.Aluno != null)
                {
                    this.Show();
                    this.Aluno = lg.Aluno;
                    this.lblUser.Text = this.aluno.Usuario;
                    this.lblNome.Text =  this.aluno.Nome;
                    this.lblIdade.Text = this.aluno.Idade + " anos";
                    label4.Visible = true;
                    lblIdade.Visible = true;
                }
                else
                    if (lg.Professor != null)
                    {
                        this.Show();
                        this.Professor = lg.Professor;
                        this.lblUser.Text = this.professor.Usuario;
                        this.lblNome.Text = this.professor.Nome;
                        label4.Visible = false;
                        lblIdade.Visible = false;
                    }
                    else
                        this.Close();
            };
            lg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPort_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            string[] aulas = Aulas.GetAulas("Portugues");

            this.aula = new string[12, (aulas.Length/12)];

            Label lblNome = new Label();
            lblNome.Text = "Aulas de Portugues";
            lblNome.Width = 250;
            lblNome.Top = 10;
            lblNome.Left = 420;
            this.Controls.Add(lblNome);

            int top = 80;
            Button[] buttons = new Button[aulas.Length];
            for(int i = 0; i < aulas.Length; i++)
            {
                int j = 0;
                this.aula[j][i] = aulas[i];

                if ((i + 1) % 12 == 0) j++;
                if (i <= 12)
                {
                    this.aula[0][i] = aulas[i];
                    buttons[i] = new Button();
                    buttons[i].Text = aulas[i];

                    buttons[i].Top = top;
                    if ((i + 1) % 3 == 0)
                    {
                        top += 70;
                        buttons[i].Left = 590;
                    }
                    else
                        if ((i + 1) % 3 == 1)
                        buttons[i].Left = 310;
                    else
                        buttons[i].Left = 450;

                    buttons[i].Width = 120;
                    buttons[i].Height = 50;
                    this.Controls.Add(buttons[i]);
                }
            }
        }
    }
}
