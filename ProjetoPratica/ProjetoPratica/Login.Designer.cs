namespace ProjetoPratica
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFala = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.btnFunc = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.MaskedTextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkProf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFala
            // 
            this.lblFala.AutoSize = true;
            this.lblFala.BackColor = System.Drawing.Color.White;
            this.lblFala.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFala.ForeColor = System.Drawing.Color.Black;
            this.lblFala.Location = new System.Drawing.Point(268, 63);
            this.lblFala.Name = "lblFala";
            this.lblFala.Size = new System.Drawing.Size(0, 32);
            this.lblFala.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(270, 287);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 19);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(350, 240);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 26);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(350, 283);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(227, 26);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFunc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFunc.Location = new System.Drawing.Point(281, 372);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(125, 40);
            this.btnFunc.TabIndex = 6;
            this.btnFunc.Text = "Login";
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ProjetoPratica.Properties.Resources.balao;
            this.pictureBox3.Location = new System.Drawing.Point(198, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(416, 131);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(275, 243);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 19);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Login:";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Location = new System.Drawing.Point(274, 165);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 19);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            this.lblNome.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(350, 162);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(227, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.Visible = false;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.Location = new System.Drawing.Point(350, 325);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(227, 26);
            this.txtConfirmar.TabIndex = 5;
            this.txtConfirmar.Visible = false;
            this.txtConfirmar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmar_KeyPress);
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(243, 329);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(91, 19);
            this.lblConfirmar.TabIndex = 10;
            this.lblConfirmar.Text = "Confirmar:";
            this.lblConfirmar.Visible = false;
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(350, 200);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(227, 26);
            this.txtIdade.TabIndex = 2;
            this.txtIdade.Visible = false;
            this.txtIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdade_KeyPress);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.BackColor = System.Drawing.Color.Transparent;
            this.lblIdade.Location = new System.Drawing.Point(274, 203);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(57, 19);
            this.lblIdade.TabIndex = 12;
            this.lblIdade.Text = "Idade:";
            this.lblIdade.Visible = false;
            // 
            // btnTrocar
            // 
            this.btnTrocar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTrocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrocar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrocar.Location = new System.Drawing.Point(438, 372);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(128, 40);
            this.btnTrocar.TabIndex = 7;
            this.btnTrocar.Text = "Cadastre-se";
            this.btnTrocar.UseVisualStyleBackColor = false;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(99, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 38);
            this.label1.TabIndex = 1000;
            this.label1.Text = "                  \r\n                  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkProf
            // 
            this.chkProf.AutoSize = true;
            this.chkProf.BackColor = System.Drawing.Color.Transparent;
            this.chkProf.Location = new System.Drawing.Point(278, 199);
            this.chkProf.Name = "chkProf";
            this.chkProf.Size = new System.Drawing.Size(127, 23);
            this.chkProf.TabIndex = 1001;
            this.chkProf.Text = "É professor?";
            this.chkProf.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProjetoPratica.Properties.Resources.suamaenovakkj;
            this.ClientSize = new System.Drawing.Size(617, 442);
            this.Controls.Add(this.chkProf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.lblFala);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFala;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkProf;
    }
}