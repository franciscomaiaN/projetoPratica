namespace ProjetoPratica
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGeo = new System.Windows.Forms.Button();
            this.btnHist = new System.Windows.Forms.Button();
            this.btnCie = new System.Windows.Forms.Button();
            this.btnMat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeslogar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeslogar.Location = new System.Drawing.Point(81, 385);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(107, 39);
            this.btnDeslogar.TabIndex = 0;
            this.btnDeslogar.Text = "Sair";
            this.btnDeslogar.UseVisualStyleBackColor = false;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblIdade);
            this.groupBox1.Controls.Add(this.btnDeslogar);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-3, -20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 460);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(15, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(15, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::ProjetoPratica.Properties.Resources.kokoro;
            this.pictureBox1.Location = new System.Drawing.Point(81, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdade.Location = new System.Drawing.Point(104, 280);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(101, 19);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "                       ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(104, 244);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(101, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "                       ";
            this.lblNome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(104, 209);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(101, 19);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "                       ";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGeo);
            this.groupBox2.Controls.Add(this.btnHist);
            this.groupBox2.Controls.Add(this.btnCie);
            this.groupBox2.Controls.Add(this.btnMat);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnPort);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(230, -20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 454);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnGeo
            // 
            this.btnGeo.BackColor = System.Drawing.Color.Gold;
            this.btnGeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeo.Location = new System.Drawing.Point(118, 263);
            this.btnGeo.Name = "btnGeo";
            this.btnGeo.Size = new System.Drawing.Size(334, 42);
            this.btnGeo.TabIndex = 5;
            this.btnGeo.Text = "Geografia";
            this.btnGeo.UseVisualStyleBackColor = false;
            // 
            // btnHist
            // 
            this.btnHist.BackColor = System.Drawing.Color.Black;
            this.btnHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHist.Location = new System.Drawing.Point(118, 203);
            this.btnHist.Name = "btnHist";
            this.btnHist.Size = new System.Drawing.Size(334, 42);
            this.btnHist.TabIndex = 4;
            this.btnHist.Text = "História";
            this.btnHist.UseVisualStyleBackColor = false;
            // 
            // btnCie
            // 
            this.btnCie.BackColor = System.Drawing.Color.Green;
            this.btnCie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCie.Location = new System.Drawing.Point(118, 323);
            this.btnCie.Name = "btnCie";
            this.btnCie.Size = new System.Drawing.Size(334, 42);
            this.btnCie.TabIndex = 3;
            this.btnCie.Text = "Ciências";
            this.btnCie.UseVisualStyleBackColor = false;
            // 
            // btnMat
            // 
            this.btnMat.BackColor = System.Drawing.Color.Red;
            this.btnMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMat.Location = new System.Drawing.Point(118, 147);
            this.btnMat.Name = "btnMat";
            this.btnMat.Size = new System.Drawing.Size(334, 42);
            this.btnMat.TabIndex = 2;
            this.btnMat.Text = "Matemática";
            this.btnMat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matérias";
            // 
            // btnPort
            // 
            this.btnPort.BackColor = System.Drawing.Color.Blue;
            this.btnPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPort.Location = new System.Drawing.Point(118, 90);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(334, 42);
            this.btnPort.TabIndex = 0;
            this.btnPort.Text = "Português";
            this.btnPort.UseVisualStyleBackColor = false;
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);
            // 
            // FrmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(745, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ue";
            this.Shown += new System.EventHandler(this.FrmPrincipal_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGeo;
        private System.Windows.Forms.Button btnHist;
        private System.Windows.Forms.Button btnCie;
        private System.Windows.Forms.Button btnMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUser;
    }
}

