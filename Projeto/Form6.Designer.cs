namespace Projeto
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeLivro = new System.Windows.Forms.TextBox();
            this.textBoxContribuidor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxExclusao = new System.Windows.Forms.ComboBox();
            this.labelOutro = new System.Windows.Forms.Label();
            this.textBoxOutro = new System.Windows.Forms.TextBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.label1.Location = new System.Drawing.Point(97, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID do Livro:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonBuscar.Location = new System.Drawing.Point(425, 107);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(150, 27);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.textBoxID.Location = new System.Drawing.Point(188, 107);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(223, 27);
            this.textBoxID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(290, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Excluir Livros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.label3.Location = new System.Drawing.Point(72, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Livro:";
            // 
            // textBoxNomeLivro
            // 
            this.textBoxNomeLivro.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.textBoxNomeLivro.Location = new System.Drawing.Point(188, 147);
            this.textBoxNomeLivro.Name = "textBoxNomeLivro";
            this.textBoxNomeLivro.ReadOnly = true;
            this.textBoxNomeLivro.Size = new System.Drawing.Size(387, 27);
            this.textBoxNomeLivro.TabIndex = 5;
            // 
            // textBoxContribuidor
            // 
            this.textBoxContribuidor.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.textBoxContribuidor.Location = new System.Drawing.Point(188, 190);
            this.textBoxContribuidor.Name = "textBoxContribuidor";
            this.textBoxContribuidor.ReadOnly = true;
            this.textBoxContribuidor.Size = new System.Drawing.Size(387, 27);
            this.textBoxContribuidor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.label4.Location = new System.Drawing.Point(86, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contribuidor:";
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.textBoxAutor.Location = new System.Drawing.Point(188, 232);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.ReadOnly = true;
            this.textBoxAutor.Size = new System.Drawing.Size(387, 27);
            this.textBoxAutor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.label5.Location = new System.Drawing.Point(66, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome do Autor:";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonExcluir.Location = new System.Drawing.Point(397, 356);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(178, 27);
            this.buttonExcluir.TabIndex = 10;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.label6.Location = new System.Drawing.Point(43, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Motivo de Exclusão:";
            // 
            // comboBoxExclusao
            // 
            this.comboBoxExclusao.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.comboBoxExclusao.FormattingEnabled = true;
            this.comboBoxExclusao.Items.AddRange(new object[] {
            "Documento Ilegível.",
            "Livro não correspondente ao nome.",
            "Falta de Páginas.",
            "Outro"});
            this.comboBoxExclusao.Location = new System.Drawing.Point(188, 273);
            this.comboBoxExclusao.Name = "comboBoxExclusao";
            this.comboBoxExclusao.Size = new System.Drawing.Size(387, 27);
            this.comboBoxExclusao.TabIndex = 12;
            this.comboBoxExclusao.SelectedIndexChanged += new System.EventHandler(this.Outro);
            // 
            // labelOutro
            // 
            this.labelOutro.AutoSize = true;
            this.labelOutro.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.labelOutro.Location = new System.Drawing.Point(134, 321);
            this.labelOutro.Name = "labelOutro";
            this.labelOutro.Size = new System.Drawing.Size(50, 19);
            this.labelOutro.TabIndex = 13;
            this.labelOutro.Text = "Outro:";
            this.labelOutro.Visible = false;
            // 
            // textBoxOutro
            // 
            this.textBoxOutro.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.textBoxOutro.Location = new System.Drawing.Point(188, 313);
            this.textBoxOutro.Name = "textBoxOutro";
            this.textBoxOutro.Size = new System.Drawing.Size(387, 27);
            this.textBoxOutro.TabIndex = 14;
            this.textBoxOutro.Visible = false;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F);
            this.buttonVoltar.Location = new System.Drawing.Point(190, 356);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(179, 27);
            this.buttonVoltar.TabIndex = 15;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(496, 28);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(79, 23);
            this.buttonLogout.TabIndex = 43;
            this.buttonLogout.Text = "Sair";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(496, 9);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(0, 16);
            this.labelUsuario.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto.Properties.Resources.Usuario;
            this.pictureBox1.Location = new System.Drawing.Point(446, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 449);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.textBoxOutro);
            this.Controls.Add(this.labelOutro);
            this.Controls.Add(this.comboBoxExclusao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxContribuidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNomeLivro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeLivro;
        private System.Windows.Forms.TextBox textBoxContribuidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxExclusao;
        private System.Windows.Forms.Label labelOutro;
        private System.Windows.Forms.TextBox textBoxOutro;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}