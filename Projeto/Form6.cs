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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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
    }
}
