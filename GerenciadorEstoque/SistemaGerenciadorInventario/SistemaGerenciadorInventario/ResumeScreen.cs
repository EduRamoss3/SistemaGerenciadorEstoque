using SistemaGerenciadorInventario.Data;
using System;
using System.Windows.Forms;

namespace SistemaGerenciadorInventario
{
    public partial class ResumeScreen : Form
    {
        BuyAcess buyAcess = new BuyAcess();
        private NewBuy newBuy;
        private BindingSource bindingSource;

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
            // Configurar o BindingSource
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridResume.DataSource;

            // Atribuir o BindingSource ao DataGridView
            dataGridResume.DataSource = bindingSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = textSearch.Text;
            int searchInt, searchQnt;

            if (int.TryParse(textSearch.Text, out searchInt))
            {
                // Aplicar o filtro para pesquisa por texto ou valor inteiro
                bindingSource.Filter = string.Format("Name LIKE '%{0}%' OR Id = {1}", searchText, searchInt);
            }
            if (int.TryParse(textSearch.Text, out searchQnt))
            {
                // Aplicar o filtro para pesquisa por texto ou valor inteiro
                bindingSource.Filter = string.Format("Name LIKE '%{0}%' OR Quantity = {1}", searchText, searchQnt);
            }
            else
            {
                // Aplicar o filtro apenas para pesquisa por texto
                bindingSource.Filter = string.Format("Name LIKE '%{0}%'", searchText);
            }
        }

        private void lblPayed_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridResume.SelectedRows[0].Cells[0].Value);
                PayingScreen payingScreen = new PayingScreen(id, this);
                payingScreen.Show();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecione um cliente válido.");
            }
            
            
        }
    }
}
