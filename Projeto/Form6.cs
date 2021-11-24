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
    public partial class Form6 : Form
    {
        public Form6(string usuario)
        {
            InitializeComponent();
            labelUsuario.Text = usuario;
        }

        private void Outro(object sender, EventArgs e)
        {
            if (comboBoxExclusao.Text.ToString() == "Outro")
            {
                labelOutro.Visible = true;
                textBoxOutro.Visible = true;
                buttonExcluir.Location = new Point(397, 356);
                buttonVoltar.Location = new Point(190, 356);
            }
            else
            {
                labelOutro.Visible = false;
                textBoxOutro.Visible = false;
                buttonExcluir.Location = new Point(397, 313);
                buttonVoltar.Location = new Point(190, 313);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            buttonExcluir.Location = new Point(397, 313);
            buttonVoltar.Location = new Point(190, 313);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Realizar Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Visible = true;
                this.Dispose();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=livratech;SslMode=none");
            string sql = $"select * from livro where id={textBoxID.Text}";

            MySqlCommand comando = new MySqlCommand(sql,conexao);

            try
            {
                conexao.Open();
                MySqlDataReader livro = comando.ExecuteReader();

                if (livro.Read())
                {
                    textBoxNomeLivro.Text = livro["nome"].ToString();
                    textBoxContribuidor.Text = livro["contribuidor"].ToString();
                    textBoxAutor.Text = livro["autor"].ToString();
                }
                else
                {
                    MessageBox.Show("ID não encontrado!");
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro);
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=livratech;SslMode=none");
            string sql = $"delete from livro where id={textBoxID.Text}";


            MySqlCommand comando = new MySqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas == 1) MessageBox.Show("Livro excluído com sucesso!");
                else MessageBox.Show("Não foi possível excluir!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro);
            }
            finally
            {
                comando.Dispose();
                conexao.Close();
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(labelUsuario.Text);
            form3.Show();
            this.Dispose();
        }
    }
}
