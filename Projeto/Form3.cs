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
    public partial class Form3 : Form
    {
        public Form3(string usuario)
        {
            InitializeComponent();
            labelUsuario.Text = usuario;
            buscarId();
        }

        private void buscarId()
        {
            MySqlConnection conexaoBD = new MySqlConnection("server=localhost;uid=root;pwd='';database=livratech;SslMode=none");
            string sql = $"select * from usuario where login='{labelUsuario.Text}'";
            MySqlCommand comandoBD = new MySqlCommand(sql, conexaoBD);

            try
            {
                conexaoBD.Open();
                MySqlDataReader usuario = comandoBD.ExecuteReader();

                if (usuario.Read()) labelId.Text = usuario["idUsuario"].ToString();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro);
            }
            finally
            {
                conexaoBD.Close();
                conexaoBD.Dispose();
            }
        }

        private void livrosDisponiveis(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(labelUsuario.Text);
            form4.Show();
            this.Dispose();
        }

        private void adicionarLivro(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(labelUsuario.Text);
            form5.Show();
            this.Dispose();
        }

        private void AbrirPerfil(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(labelId.Text);
            form7.Show();
            this.Dispose();
        }

        private void ExcluirLivro(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(labelUsuario.Text);
            form6.Show();
            this.Dispose();
        }

        private void buttonSair(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Realizar Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Visible = true;
                this.Dispose();
            }
        }
    }
}
