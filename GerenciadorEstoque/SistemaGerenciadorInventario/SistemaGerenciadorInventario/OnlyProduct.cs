using SistemaGerenciadorInventario.Data;
using System;
using System.Windows.Forms;

namespace SistemaGerenciadorInventario
{
    public partial class OnlyProduct : Form
    {
        InventoryAcess inventoryAcess = new InventoryAcess();
        private NewBuy _newbuy;
        public OnlyProduct(NewBuy newbuy)
        {
            _newbuy = newbuy;
            InitializeComponent();
            UpdateTable();
        }
        public void UpdateTable()
        {
            dataGridProduct.DataSource = inventoryAcess.ViewTable();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridProduct.SelectedRows[0].Cells[0].Value);
            _newbuy.receiveIdProduct = id;
            _newbuy.ProductToScreen();
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ItemScreen itemScreen = new ItemScreen();
            NewItem newItem = new NewItem(this, itemScreen);
            newItem.Show();
            UpdateTable();
        }
    }
}
