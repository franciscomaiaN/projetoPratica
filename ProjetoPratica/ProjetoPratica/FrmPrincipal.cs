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
        private int pag;

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

        private void adicionaBotoes(string[] nomes)
        {
            
        }

        private void btnPort_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            string[] aulas = Aulas.GetAulas(((Button)sender).Text);

            Label lblNomeMat = new Label();
            lblNomeMat.Text = "Aulas de "+ ((Button)sender).Text; 
            lblNomeMat.Width = 250;
            lblNomeMat.Top = 10;
            lblNomeMat.Left = 440;
            this.Controls.Add(lblNomeMat);

            string[] nomes;
            if (aulas.Length >= 12) nomes = new string[12];
            else nomes = new string[aulas.Length];

            for (int i = 0; i < 12 && i < aulas.Length; i++)
                    nomes[i] = aulas[i];         

            int top = 80;
            Button[] buttons = new Button[nomes.Length];
            for (int i = 0; i < nomes.Length; i++)
            {
                int j = 0;

                if ((i + 1) % 12 == 0) j++;

                if (i < 12)
                {
                    buttons[i] = new Button();
                    buttons[i].Text = nomes[i];

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
                    buttons[i].Click += (s, args) =>
                    {
                        Form1 form1 = new Form1(((Button)s).Text);
                        form1.FormClosed += (se, ags) => 
                        {
                            this.Show();
                        };
                        form1.Show();
                        this.Hide();
                    };
                    this.Controls.Add(buttons[i]);
                }
            }

            this.pag = 0;

            Button voltar = new Button();
            voltar.Text = "Voltar";
            voltar.Width = 100;
            voltar.Height = 30;
            voltar.Left = 310;
            voltar.Top = 390;
            voltar.Click += (s, args) =>
            {
                groupBox2.Show();
                this.pag = 0;
                this.Controls.Remove(voltar);
                this.Controls.Remove(lblNomeMat);
                foreach (Button button in buttons) this.Controls.Remove(button);
            };
            this.Controls.Add(voltar);

            Button pagAnt = new Button();
            pagAnt.Text = "<<<";
            pagAnt.Width = 70;
            pagAnt.Height = 30;
            pagAnt.Left = 440;
            pagAnt.Top = 390;
            pagAnt.Enabled = false;

            Button pagDep = new Button();
            pagDep.Text = ">>>";
            pagDep.Width = 70;
            pagDep.Height = 30;
            pagDep.Left = 520;
            pagDep.Top = 390;
            if (this.pag == (int)Math.Ceiling((float)aulas.Length / 12)) pagDep.Enabled = false;
            pagDep.Click += (s, args) =>
            {
                this.pag++;
                pagAnt.Enabled = true;
                if (this.pag == (int)Math.Ceiling((float)(aulas.Length / 12))) pagDep.Enabled = false;

                foreach(Button button in buttons)this.Controls.Remove(button);

                if (aulas.Length - this.pag * 12 >= 12) nomes = new string[12];
                else nomes = new string[aulas.Length - this.pag * 12];

                int z = -1;
                for (int i = this.pag * 12; i < (this.pag * 12)+12 && i < aulas.Length; i++)
                    nomes[++z] = aulas[i];
 
                top = 80;
                buttons = new Button[12];
                for (int i = 0;i < nomes.Length; i++)
                {
                    int j = 0;

                    if ((i + 1) % 12 == 0) j++;

                    if (i < 12)
                    {
                        buttons[i] = new Button();
                        buttons[i].Text = nomes[i];

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
            };
            pagAnt.Click += (s, args) =>
            {
                this.pag--;
                if (this.pag == 0) pagAnt.Enabled = false;
                pagDep.Enabled = true;

                foreach (Button button in buttons) this.Controls.Remove(button);

                if (aulas.Length - this.pag * 12 >= 12) nomes = new string[12];
                else nomes = new string[aulas.Length - this.pag * 12];

                int z = -1;
                for (int i = this.pag * 12; i < (this.pag * 12)+12 && i < aulas.Length; i++)
                    nomes[++z] = aulas[i];

                top = 80;
                buttons = new Button[12];
                for (int i = 0; i < nomes.Length; i++)
                {
                    int j = 0;

                    if ((i + 1) % 12 == 0) j++;

                    if (i < 12)
                    {
                        buttons[i] = new Button();
                        buttons[i].Text = nomes[i];

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
            };
            this.Controls.Add(pagAnt);
            this.Controls.Add(pagDep);

            if (this.professor != null)
            {
                Button novaAula = new Button();
                novaAula.Text = "Nova Aula";
                novaAula.Width = 100;
                novaAula.Height = 30;
                novaAula.Left = 610;
                novaAula.Top = 390;
                novaAula.Click += (s, args) =>
                {
                    CriarMateria frmNovaMat = new CriarMateria();
                    frmNovaMat.Show();
                };
                this.Controls.Add(novaAula);
            }
        }
    }
}
