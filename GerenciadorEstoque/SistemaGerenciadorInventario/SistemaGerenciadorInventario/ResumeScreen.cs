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
    public partial class ResumeScreen : Form
    {
        BuyAcess buyAcess = new BuyAcess();
        private NewBuy newBuy;
        public ResumeScreen(NewBuy newBuy)
        {
            InitializeComponent();
            UpdateTable();
            this.newBuy = newBuy;
            dataGridResume.Columns["Id"].HeaderText = "Identificador(ID)";
            dataGridResume.Columns["Value"].HeaderText = "Valor da compra";
            dataGridResume.Columns["Quantity"].HeaderText = "Qnt. Produtos";
            dataGridResume.Columns["DateInit"].HeaderText = "Data da entrada";
            dataGridResume.Columns["Name"].HeaderText = "Produto";
            dataGridResume.Columns["Payed"].HeaderText = "Já pago";
            dataGridResume.Columns["PayedParcel"].HeaderText = "Valor da parcela";
            dataGridResume.Columns["QntParcel"].HeaderText = "Qnt. Parcelas";
            dataGridResume.Columns["QntPayed"].HeaderText = "Qnt. Parcelas pagas";
            dataGridResume.Columns["RemainingPay"].HeaderText = "Falta pagar";
        }
        public ResumeScreen()
        {
            InitializeComponent();
            UpdateTable();
            dataGridResume.Columns["Id"].HeaderText = "Identificador(ID)";
            dataGridResume.Columns["Value"].HeaderText = "Valor da compra";
            dataGridResume.Columns["Quantity"].HeaderText = "Qnt. Produtos";
            dataGridResume.Columns["DateInit"].HeaderText = "Data da entrada";
            dataGridResume.Columns["Name"].HeaderText = "Produto";
            dataGridResume.Columns["Payed"].HeaderText = "Já pago";
            dataGridResume.Columns["PayedParcel"].HeaderText = "Valor da parcela";
            dataGridResume.Columns["QntParcel"].HeaderText = "Qnt. Parcelas";
            dataGridResume.Columns["QntPayed"].HeaderText = "Qnt. Parcelas pagas";
            dataGridResume.Columns["RemainingPay"].HeaderText = "Falta pagar";

        }
        public void UpdateTable()
        {
            dataGridResume.DataSource = buyAcess.ViewTable();
        }
    }
}
