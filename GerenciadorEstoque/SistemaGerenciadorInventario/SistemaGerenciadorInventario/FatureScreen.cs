using SistemaGerenciadorInventario.Data;
using System;
using System.Windows.Forms;

namespace SistemaGerenciadorInventario
{
    public partial class FatureScreen : Form
    {
        BuyAcess buyAcess = new BuyAcess();
        public FatureScreen()
        {
            InitializeComponent();
            UpdateTable();
            dataGridFature.Columns["Id"].HeaderText = "Identificador (Id)";
            dataGridFature.Columns["Name"].HeaderText = "Cliente";
            dataGridFature.Columns["CPF"].HeaderText = "CPF do cliente";
            dataGridFature.Columns["CPF1"].HeaderText = "CPF da compra";
            dataGridFature.Columns["Value"].HeaderText = "Valor";
            dataGridFature.Columns["Payed"].HeaderText = "Pago";
            dataGridFature.Columns["Name1"].HeaderText = "Produto";
            dataGridFature.Columns["PayedParcel"].Visible = false;
            dataGridFature.Columns["QntPayed"].HeaderText = "Qnt. Parcelas pagas";
            dataGridFature.Columns["RemainingPay"].Visible = false;
            dataGridFature.Columns["DateInit"].HeaderText = "Data da compra";
            dataGridFature.Columns["Quantity"].HeaderText = "Qnt. Produtos";
            dataGridFature.Columns["QntParcel"].HeaderText = "Qnt. Parcelas";
        }
       
        public void UpdateTable()
        {
            dataGridFature.DataSource = buyAcess.ViewTableFature();

        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
