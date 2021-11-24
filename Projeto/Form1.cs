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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form_2 = new Form2();
            form_2.Show();
            this.Visible = false;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=livratech;SslMode=none");

            string sql = $"select * from usuario where login='{textBoxUsuario.Text}' and senha=SHA1('{textBoxSenha.Text}')";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            try 
            {
                conexao.Open();
                MySqlDataReader linhas = comando.ExecuteReader();

                if (linhas.Read()) // Essas linhas têm leitura?
                { // Se sim
                    Form3 form3 = new Form3(textBoxUsuario.Text);
                    form3.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
            } catch (Exception erro) {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro);
            } finally {
                comando.Dispose();
                conexao.Close();
            }
        }

        private void checkBoxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSenha.Checked) textBoxSenha.PasswordChar = '\0';
            else textBoxSenha.PasswordChar = '*';
        }
    }
}
