using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : Form
    {
        private Form2 f2 = null;

        public void setF2(Form2 f2)
        {
            this.f2 = f2;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Cadastrar(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (f2 == null)
            { // Para não ficar criando o formulário toda hora
                f2 = new Form2();
            }
            f2.Show();
            f2.setF1(this);
            this.Hide();
        }
    }
}
