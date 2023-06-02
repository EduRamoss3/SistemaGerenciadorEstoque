using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void clickAction(object sender, EventArgs e)
        {
            string Frase = string.Format("Olá {0}!", txtName.Text);
            MessageBox.Show(Frase, "Bem vindo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

       
    }
}
