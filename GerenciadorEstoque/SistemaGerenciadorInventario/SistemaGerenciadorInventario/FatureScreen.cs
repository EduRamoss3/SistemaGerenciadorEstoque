using SistemaGerenciadorInventario.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dataGridFature.Columns["PayedParcel"].HeaderText = "Parcelas Pagas";
            dataGridFature.Columns["QntPayed"].HeaderText = "Qnt. Parcelas pagas";
            dataGridFature.Columns["RemainingPay"].HeaderText = "Restante a ser pago";
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
