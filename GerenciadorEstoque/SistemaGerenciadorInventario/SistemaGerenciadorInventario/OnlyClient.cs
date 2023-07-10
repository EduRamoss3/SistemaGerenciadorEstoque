using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGerenciadorInventario.Data;

namespace SistemaGerenciadorInventario
{
    public partial class OnlyClient : Form
    {
        ClientAcess acess = new ClientAcess();
        public NewBuy newbuy;
        public OnlyClient()
        {
            InitializeComponent();
            UpdateTable();
        }
        public OnlyClient(NewBuy newBuy)
        {
            this.newbuy = newBuy;
            InitializeComponent();
            UpdateTable();
            dataGridClient.Columns["QntBuyItems"].Visible = true;
            dataGridClient.Columns["DownSale"].Visible = true;
            dataGridClient.Columns["DownSale"].HeaderText = "Saldo devedor";
            dataGridClient.Columns["Id"].HeaderText = "ID (Identificador)";
            dataGridClient.Columns["Name"].HeaderText = "Nome";
            dataGridClient.Columns["BirthDay"].HeaderText = "Data de nascimento";
            dataGridClient.Columns["Sex"].HeaderText = "Sexo";
            dataGridClient.Columns["Phone"].HeaderText = "Telefone";
            dataGridClient.Columns["City"].HeaderText = "Cidade";
            dataGridClient.Columns["State"].HeaderText = "Estado";
            dataGridClient.Columns["DataEnter"].HeaderText = "Data de cadastro";
            dataGridClient.Columns["Num"].HeaderText = "Número do local";
            dataGridClient.Columns["QntBuyItems"].HeaderText = "Qnt. Items comprados";

        }
        public void UpdateTable()
        {
            dataGridClient.DataSource = acess.DataGet();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClientAddScreen clientAddScreen = new ClientAddScreen(this);
            clientAddScreen.Show(); 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridClient.SelectedRows[0].Cells[0].Value);
            newbuy.receiveIdClient = id;    
            newbuy.ClientToScreen();
            this.Close();
        }
    }
}
