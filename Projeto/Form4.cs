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
    public partial class Form4 : Form
    {
        public Form4(string usuario)
        {
            InitializeComponent();
            labelUsuario.Text = usuario;
        }

        private void buttonVerTodos_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxAutor.Text = "";
            textBoxContribuidor.Text = "";
            textBoxEditora.Text = "";
            textBoxId.Text = "";

            MySqlConnection conexaoBD = new MySqlConnection("server=localhost;uid=root;pwd='';database=livratech;SslMode=none");

            string sql = "select * from livro";

            MySqlCommand comandoBD = new MySqlCommand(sql, conexaoBD);

            try
            {
                conexaoBD.Open();
                MySqlDataReader livros = comandoBD.ExecuteReader();

                DataTable tabelaLivros = new DataTable();

                tabelaLivros.Columns.Add("ID").ReadOnly = true;
                tabelaLivros.Columns.Add("Nome");
                tabelaLivros.Columns.Add("Autor");
                tabelaLivros.Columns.Add("Editora");
                tabelaLivros.Columns.Add("Contribuidor").ReadOnly = true;

                

                while (livros.Read())
                {
                    DataRow linha = tabelaLivros.NewRow();
                    linha[0] = livros["id"];
                    linha[1] = livros["nome"];
                    linha[2] = livros["autor"];
                    linha[3] = livros["editora"];
                    linha[4] = livros["contribuidor"];
                    tabelaLivros.Rows.Add(linha);
                }

                dataGridViewLivros.DataSource = tabelaLivros;
                dataGridViewLivros.AutoResizeColumns();

            }
            catch(Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro);
            }
            finally
            {
                conexaoBD.Close();
                conexaoBD.Dispose();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoBD = new MySqlConnection("server=localhost;uid=root;pwd='';database=livratech;SslMode=none");
            string sql = $"select id, nome, autor, editora, contribuidor from livro where id={textBoxId.Text}";
            MySqlCommand comandoBD = new MySqlCommand(sql, conexaoBD);

            try
            {
                conexaoBD.Open();
                MySqlDataReader livro = comandoBD.ExecuteReader();

                DataTable tabelaLivros = new DataTable();
                tabelaLivros.Columns.Add("ID").ReadOnly = true;
                tabelaLivros.Columns.Add("Nome");
                tabelaLivros.Columns.Add("Autor");
                tabelaLivros.Columns.Add("Editora");
                tabelaLivros.Columns.Add("Contribuidor").ReadOnly = true;

                if (livro.Read())
                {
                    DataRow linha = tabelaLivros.NewRow();
                    linha[0] = livro["id"];
                    linha[1] = livro["nome"];
                    linha[2] = livro["autor"];
                    linha[3] = livro["editora"];
                    linha[4] = livro["contribuidor"];
                    tabelaLivros.Rows.Add(linha);

                    dataGridViewLivros.DataSource = tabelaLivros;

                    textBoxNome.Text = livro[1].ToString();
                    textBoxAutor.Text = linha[2].ToString();
                    textBoxEditora.Text = livro[3].ToString();
                    textBoxContribuidor.Text = livro[4].ToString();
                }
                else
                {
                    MessageBox.Show("ID não encontrado!");
                }

            }
            catch(Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro);
            }
            finally
            {
                conexaoBD.Close();
                conexaoBD.Dispose();
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(labelUsuario.Text);
            form3.Show();
            this.Dispose();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja sair?", "Realizar Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Visible = true;
                this.Dispose();
            }

        }

        private void Modificar(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=livratech;SslMode=none");
            string sql = $"update livro set nome='{textBoxNome.Text}', autor='{textBoxAutor.Text}' where id={textBoxId.Text}";
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas == 1) MessageBox.Show("Dados alterados com sucesso!");
                else MessageBox.Show("Não foi possível alterar.");
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

        
        private void SelecionarCelula(object sender, EventArgs e)
        {
            textBoxId.Text = dataGridViewLivros.CurrentRow.Cells[0].Value.ToString();
            textBoxNome.Text = dataGridViewLivros.CurrentRow.Cells[1].Value.ToString();
            textBoxAutor.Text = dataGridViewLivros.CurrentRow.Cells[2].Value.ToString();
            textBoxEditora.Text = dataGridViewLivros.CurrentRow.Cells[3].Value.ToString();
            textBoxContribuidor.Text = dataGridViewLivros.CurrentRow.Cells[4].Value.ToString();
        }

        private void SalvarCelula(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarCelula(null, null);
            Modificar(null, null);
        }

    }
}
