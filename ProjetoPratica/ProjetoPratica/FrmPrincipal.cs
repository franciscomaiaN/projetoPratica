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

            foreach(string titulo in aulas)
            {

            }
        }
    }
}
