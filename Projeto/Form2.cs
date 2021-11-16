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
    public partial class Form2 : Form
    {
        private Form1 f1 = null;

        public void setF1(Form1 f1)
        {
            this.f1 = f1;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (f1 == null)
            { // Para não ficar criando o formulário toda hora
                f1 = new Form1();
            }
            f1.Show();
            f1.setF2(this);
            this.Hide();
        }
    }
}
