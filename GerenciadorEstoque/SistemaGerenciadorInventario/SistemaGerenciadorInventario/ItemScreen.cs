using SistemaGerenciadorInventario.Data;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace SistemaGerenciadorInventario
{
    public partial class ItemScreen : Form
    {
        InventoryAcess inventoryAcess = new InventoryAcess();
        private BindingSource bindingSource;
        private NewBuy newBuy;
        public ItemScreen()
        {

            InitializeComponent();
            UpdateTable();
            UpdateTotal();
            lblTotal.Text = inventoryAcess.Total().ToString();
            tableViewer.Columns["Name"].HeaderText = "Nome";
            tableViewer.Columns["Id"].HeaderText = "ID (Identificador)";
            tableViewer.Columns["Price"].HeaderText = "Preço por unidade";
            tableViewer.Columns["Quantity"].HeaderText = "Quantidade";
            tableViewer.Columns["Type"].HeaderText = "Tipo";
            tableViewer.Columns["DataEnter"].HeaderText = "Data de registro";
        }
        public ItemScreen(NewBuy newBuy)
        {
            this.newBuy = newBuy;
            InitializeComponent();
            UpdateTable();
            UpdateTotal();
            lblTotal.Text = inventoryAcess.Total().ToString();
            tableViewer.Columns["Name"].HeaderText = "Nome";
            tableViewer.Columns["Id"].HeaderText = "ID (Identificador)";
            tableViewer.Columns["Price"].HeaderText = "Preço por unidade";
            tableViewer.Columns["Quantity"].HeaderText = "Quantidade";
            tableViewer.Columns["Type"].HeaderText = "Tipo";
            tableViewer.Columns["DataEnter"].HeaderText = "Data de registro";
        }
        public void UpdateTotal()
        {
            lblTotal.Text = inventoryAcess.Total().ToString();
        }
        private void btnAdc_Click(object sender, EventArgs e)
        {
            NewItem newitem = new NewItem(this);
            newitem.Show();
            UpdateTable();
            UpdateTotal();
        }
        public void UpdateTable()
        {

            tableViewer.DataSource = inventoryAcess.ViewTable();
            // Configurar o BindingSource
            bindingSource = new BindingSource();
            bindingSource.DataSource = tableViewer.DataSource;

            // Atribuir o BindingSource ao DataGridView
            tableViewer.DataSource = bindingSource;
            lblTotal.Update();
            UpdateTotal();
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(tableViewer.SelectedRows[0].Cells[0].Value);

            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o ID " + id.ToString() + "?", "Confirmação de exclusão", button);
            if (result == DialogResult.Yes)
            {
                inventoryAcess.DeleteItem(id);
                UpdateTable();
                UpdateTotal();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(tableViewer.SelectedRows[0].Cells[0].Value);
            Edit_Screen edit_Screen = new Edit_Screen(this, id);
            edit_Screen.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Adicionando +1 produto
            int id = Convert.ToInt32(tableViewer.SelectedRows[0].Cells[0].Value);
            bool result = inventoryAcess.OneMoreProduct(id);
            UpdateTable();
            if (result)
            {
                UpdateTable();
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Erro ao adicionar produto");
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            int searchInt, searchQnt;

            if (int.TryParse(searchBox.Text, out searchInt))
            {
                // Aplicar o filtro para pesquisa por texto ou valor inteiro
                bindingSource.Filter = string.Format("Name LIKE '%{0}%' OR Id = {1}", searchText, searchInt);
            }
            if (int.TryParse(searchBox.Text, out searchQnt))
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Removendo 1 produto
            int id = Convert.ToInt32(tableViewer.SelectedRows[0].Cells[0].Value);
            bool result = inventoryAcess.RemoveOneProduct(id);
            if (result)
            {
                UpdateTable();
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Erro ao remover produto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botão valor total 1 Produto especifico
            int id = Convert.ToInt32(tableViewer.SelectedRows[0].Cells[0].Value);
            SqlMoney Result = inventoryAcess.SelectOneItem(id);
            if (Result > 0)
            {
                UpdateTable();
                lblTotal.Text = " R$" + Result.ToString();
                label1.Text = "Valor total do item ID " + id;
            }
            else
            {
                MessageBox.Show("Erro ao Atualizar 1 produto"); ;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Valor total em estoque: R$";
            UpdateTotal();
        }

    }

}
