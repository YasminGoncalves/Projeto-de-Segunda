using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class Form5 : Form
    {
        public Form5(string usuario)
        {
            InitializeComponent();
            labelUsuario.Text = usuario;
            textBoxUsuario.Text = usuario;
        }

        public string validarCampoObrigatorio()
        {
            string validar;
            if (textBoxNomeLivro.Text == "") { MessageBox.Show("Preenchimento obrigatório do campo Nome do Livro!"); textBoxNomeLivro.Focus(); validar = "Faltam Dados"; }
            else if (textBoxAutor.Text == "") { MessageBox.Show("Preenchimento obrigatório do campo Autor!"); textBoxAutor.Focus(); validar = "Faltam Dados"; }
            else validar = "Ok";
            return validar;
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Realizar logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Visible = true;
                this.Dispose();
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(labelUsuario.Text);
            form3.Show();
            this.Dispose();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (validarCampoObrigatorio().Equals("Ok"))
            {
                MySqlConnection conexaoBD = new MySqlConnection("server=localhost;uid=root;pwd='';database=livratech;SslMode=none");
                string sql = $"insert into livro (id, nome, autor, editora, contribuidor) values (NULL, '{textBoxNomeLivro.Text}', '{textBoxAutor.Text}','{textBoxEditora.Text}', '{textBoxUsuario.Text}')";

                MySqlCommand comandoBD = new MySqlCommand(sql, conexaoBD);

                try
                {
                    conexaoBD.Open();
                    int linhasAfetadas = comandoBD.ExecuteNonQuery();

                    if (linhasAfetadas == 1) MessageBox.Show("O livro foi adicionado com sucesso!");
                    else MessageBox.Show("Não foi possível adicionar o livro!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu o seguinte erro: " + erro);
                }
                finally
                {
                    comandoBD.Dispose();
                    conexaoBD.Close();
                }
            }
        }


    }
}
