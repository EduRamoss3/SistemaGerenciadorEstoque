using SistemaGerenciadorInventario.Data;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace SistemaGerenciadorInventario
{

    public partial class MainScreen : Form
    {
        private BindingSource bindingSource;
        ClientAcess clientAcess = new ClientAcess();
        BuyAcess buyAcess = new BuyAcess();
        public MainScreen()
        {

            InitializeComponent();
            UpdateTable();
            lblTotal.Visible = false;
            lblValue.Visible = false;
            dataGridClientes.Columns["QntBuyItems"].Visible = true;
            dataGridClientes.Columns["DownSale"].Visible = false;
            dataGridClientes.Columns["Id"].HeaderText = "ID (Identificador)";
            dataGridClientes.Columns["Name"].HeaderText = "Nome";
            dataGridClientes.Columns["BirthDay"].HeaderText = "Data de nascimento";
            dataGridClientes.Columns["Sex"].HeaderText = "Sexo";
            dataGridClientes.Columns["Phone"].HeaderText = "Telefone";
            dataGridClientes.Columns["City"].HeaderText = "Cidade";
            dataGridClientes.Columns["State"].HeaderText = "Estado";
            dataGridClientes.Columns["DataEnter"].HeaderText = "Data de cadastro";
            dataGridClientes.Columns["Num"].HeaderText = "Número do local";
            dataGridClientes.Columns["QntBuyItems"].HeaderText = "Qnt. Items comprados";


        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            ItemScreen itemScreen = new ItemScreen();
            itemScreen.Show();
        }
        public void UpdateTable()
        {
            dataGridClientes.DataSource = clientAcess.DataGet();
            // Configurar o BindingSource
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridClientes.DataSource;

            // Atribuir o BindingSource ao DataGridView
            dataGridClientes.DataSource = bindingSource;
        }

        private void btnAdcClient_Click(object sender, EventArgs e)
        {

            ClientAddScreen screen = new ClientAddScreen(this);
            screen.Show();


        }

        private void btnExcludeClient_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridClientes.SelectedRows[0].Cells[0].Value);
                if (id == 0)
                {
                    MessageBox.Show("Nenhum cliente foi selecionado.");
                }
                else
                {
                    Client client = clientAcess.InfoCliente(id);
                    MessageBoxButtons button = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show("Tem certeza que deseja remover o cliente " + client.Name + ", Id: " + id.ToString() + " ?", "Confirmação de exclusão", button);
                    if (result == DialogResult.OK)
                    {
                        clientAcess.RemoveClient(id);
                        UpdateTable();
                        MessageBox.Show("Cliente removido com sucesso");
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecione um cliente válido");
            }

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

        private void btnEditClient_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridClientes.SelectedRows[0].Cells[0].Value);
            EditClient editClient = new EditClient(this, id);
            editClient.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            NewBuy buyScreen = new NewBuy();
            buyScreen.Show();

        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            ResumeScreen resumeScreen = new ResumeScreen();
            resumeScreen.Show();
        }

        private void btnTotalReceiv_Click(object sender, EventArgs e)
        {
            lblTotal.Visible = true;
            lblValue.Visible = true;
            SqlMoney totalMoney = buyAcess.TotalMoney();
            if(totalMoney != 0 || totalMoney.ToString() != "Null")
            {
                lblValue.Text = totalMoney.ToString();
            }
            else
            {
                lblValue.Text = 0.ToString();
            }
            

        }

        private void btnFatur_Click(object sender, EventArgs e)
        {
            FatureScreen fature = new FatureScreen();
            fature.Show();
        }
    }


}
