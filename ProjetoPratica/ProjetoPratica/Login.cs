using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoPratica 
{
    public partial class Login : Form
    {
        private char[] chr = "Faça seu Login!!!!\nNão tem uma conta?".ToArray();
        private int i = -5;
        private Aluno aluno;
        private Professor professor;
        private int modo; //0->Login/ 1-> Cadastro

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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.modo = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > -1 && i < chr.Length)
            {
                lblFala.Text = lblFala.Text + chr[i];
                i++;
            }
            else if (i < 0)
                i++;
            else
                timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.modo == 0)
                {
                    if(chkProf.Checked)
                        this.professor = Professores.Logar(txtUsuario.Text, txtSenha.Text);                       
                    else
                        this.Aluno = Alunos.Logar(txtUsuario.Text, txtSenha.Text);

                    this.Close();

                }
                else
                {
                    if(!txtSenha.Text.Equals(txtConfirmar.Text))
                    {
                        this.koroFalar("Senha digitada diferente\nde sua confirmação!!", Color.Red);
                        return;
                    }
                    if(!int.TryParse(txtIdade.Text, out int idadeAluno))
                    {
                        this.koroFalar("Sua idade tem que ser\num numero inteiro!!", Color.Red);
                        return;
                    }
                    if(idadeAluno > 110 || idadeAluno < 1)
                    {
                        this.koroFalar("Sua idade é inválida!!", Color.Red);
                        return;
                    }


                    Aluno aluninho = new Aluno(txtUsuario.Text, txtNome.Text, txtSenha.Text, idadeAluno);

                    Alunos.Cadastrar(aluninho);

                    koroFalar("Aluno cadastrado com\nsucesso!", Color.Blue);
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    txtConfirmar.Text = "";
                    txtIdade.Text = "";
                    txtNome.Text = "";              
                }
            }
            catch (SqlException)
            {
                this.koroFalar("Usuário já cadastrado!", Color.Red);
            }
            catch (Exception erro)
            {
                this.koroFalar(erro.Message, Color.Red);
            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            if(this.modo == 0)
            {
                btnFunc.Text = "Cadastrar";
                btnTrocar.Text = "Logue-se";

                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtConfirmar.Text = "";
                txtIdade.Text = "";
                txtNome.Text = "";
                chkProf.Checked = false;

                chkProf.Visible = false;
                lblNome.Visible = true;
                lblIdade.Visible = true;
                lblConfirmar.Visible = true;
                txtNome.Visible = true;
                txtConfirmar.Visible = true;
                txtIdade.Visible = true;

                txtNome.Focus();

                this.koroFalar("Cadastre-se!!!!\nJá tem uma conta?", Color.Black);
                this.modo = 1;
            }
            else
            if (this.modo == 1)
            {
                btnFunc.Text = "Login";
                btnTrocar.Text = "Cadastre-se";

                txtUsuario.Text = "";
                txtSenha.Text = "";

                chkProf.Visible = true;
                lblNome.Visible = false;
                lblIdade.Visible = false;
                lblConfirmar.Visible = false;
                txtNome.Visible = false;
                txtConfirmar.Visible = false;
                txtIdade.Visible = false;

                txtUsuario.Focus();

                this.koroFalar("Faça seu Login!!!!\nNão tem uma conta?", Color.Black);
                this.modo = 0;
            }
        }

        private void koroFalar(string oq, Color cor)
        {
            timer1.Enabled = true;
            i = -1;
            lblFala.Text = "";
            lblFala.ForeColor = cor;

            this.chr = oq.ToArray();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
                if (this.modo == 0)
                {
                    e.Handled = true;
                    this.btnFunc.PerformClick();
                }
                else
                {
                    e.Handled = true;
                    this.txtConfirmar.Focus();
                }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                e.Handled = true;
                this.txtSenha.Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                e.Handled = true;
                this.txtIdade.Focus();
            }
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                e.Handled = true;
                this.txtUsuario.Focus();
            }
        }

        private void txtConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                e.Handled = true;
                this.btnFunc.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.koroFalar("NURUNURUHUHUHUHU\nHUHUHUHUHU!!", Color.FromArgb(1,190,190,0));
        }
    }
}
