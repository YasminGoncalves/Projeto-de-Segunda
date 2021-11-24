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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, EventArgs e)
        {
            Form1 form_1 = new Form1();
            form_1.Visible = true;
            this.Dispose();
        }

        public string validarCampoObrigatorio()
        {
            string validar;
            if (textBoxNome.Text == "") { MessageBox.Show("Preenchimento obrigatório do campo Nome!"); textBoxNome.Focus(); validar = "Faltam Dados"; }
            else if (textBoxCidade.Text == "") { MessageBox.Show("Preenchimento obrigatório do campo Cidade!"); textBoxCidade.Focus(); validar = "Faltam Dados"; }
            else if (textBoxLogin.Text == "") { MessageBox.Show("Preenchimento obrigatório do campo Usuario!"); textBoxLogin.Focus(); validar = "Faltam Dados"; }
            else if (textBoxSenha.Text == "") { MessageBox.Show("Preenchimento obrigatório do campo Senha!"); textBoxSenha.Focus(); validar = "Faltam Dados"; }
            else if (textBoxEmail.Text == "") { MessageBox.Show("Preenchimento obrigatório do campo Email!"); textBoxEmail.Focus(); validar = "Faltam Dados"; }
            else validar = "Ok";
            return validar;
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (validarCampoObrigatorio().Equals("Ok"))
            {
                if (checkBoxConfirmar.Checked)
                {
                    string genero = "NULL";

                    if (radioButtonFeminino.Checked) genero = "'F'";
                    if (radioButtonMasculino.Checked) genero = "'M'";


                    MySqlConnection conexaoBD = new MySqlConnection("server=localhost;uid=root;pwd='';database=livratech;SslMode=none");

                    string sql = $"insert into usuario (idUsuario, nome, cidade, estado, telefone, genero, email, login, senha) values (NULL, '{textBoxNome.Text}', '{textBoxCidade.Text}', '{listBoxEstado.Text}', '{maskedTextBoxTelefone.Text}', {genero},'{textBoxEmail.Text}', '{textBoxLogin.Text}', SHA1('{textBoxSenha.Text}'))";

                    MySqlCommand comandoBD = new MySqlCommand(sql, conexaoBD);

                    try
                    {

                        conexaoBD.Open();
                        int linhasAfetadas = comandoBD.ExecuteNonQuery();

                        if (linhasAfetadas == 1) MessageBox.Show("O cadastro foi realizado com sucesso!");
                        else MessageBox.Show("Ocorreu um erro ao realizar o cadastro, tente novamente!");

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
                else
                {
                    MessageBox.Show("Confirme se as informações estão corretas.");
                }
            }
        }
    }
}
