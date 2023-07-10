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
using SistemaGerenciadorInventario.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaGerenciadorInventario.Entities.Enum;
using Type = SistemaGerenciadorInventario.Entities.Enum.Type;
using static System.Windows.Forms.LinkLabel;
using System.Globalization;
using System.Data.SqlTypes;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace SistemaGerenciadorInventario
{

    public partial class Edit_Screen : Form
    {
        InventoryAcess inventoryAcess = new InventoryAcess();
        private ItemScreen itemScreen;
        public Edit_Screen(ItemScreen itemScreen, int id)
        {
            InitializeComponent();
            this.itemScreen = itemScreen;
            UpdateTable();
            ItemToScreen(id);
            typeBox.Items.Add("Acessorio");
            typeBox.Items.Add("Eletronico");
            typeBox.Items.Add("Mecânico");
            typeBox.Items.Add("Comida");
            typeBox.Items.Add("Bebida");
            typeBox.Items.Add("Leitura");
            typeBox.Items.Add("Ferramenta");
            typeBox.Items.Add("Virtual");

        }
        public void UpdateTable()
        {
            tableEdit.DataSource = inventoryAcess.ViewTable();
        }
        public void ItemToScreen(int id)
        {

            Item item = inventoryAcess.ViewItem(id);
            labeld.Text = item.Id.ToString();
            boxName.Text = item.Name;
            boxPrice.Text = item.Price.ToString();
            numericUpDown1.Value = item.Quantity;
            typeBox.Text = item.type.ToString();
            lblDate.Text = item.DataEnter.ToString("dd/MM/yyyy hh:mm:ss");

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();
                item.Id = int.Parse(labeld.Text);
                item.Name = boxName.Text;
                item.Price = SqlMoney.Parse(boxPrice.Text);
                item.Quantity = Decimal.ToInt32(numericUpDown1.Value);
                Type o;
                Enum.TryParse(typeBox.Text, out o);
                item.type = o;

                MessageBoxButtons button = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show("Tem certeza que deseja fazer as alterações?", "Confirmação de edição", button);
                if (result == DialogResult.OK)
                {
                    List<ValidationResult> validationResults = new List<ValidationResult>();
                    ValidationContext context = new ValidationContext(item);
                    bool resultValidation = Validator.TryValidateObject(item, context, validationResults);
                    if (resultValidation)
                    {
                        bool receiveValidation = inventoryAcess.UpdateItem(item, item.Id);
                        if (receiveValidation)
                        {
                            itemScreen.UpdateTable();
                            this.Close();   
                        }
                        else
                        {
                            StringBuilder sb = new StringBuilder();
                            foreach (ValidationResult validationResult in validationResults)
                            {

                                sb.Append(validationResult.ErrorMessage);

                            }
                            lblErrors.Text = sb.ToString();

                        }

                    }
                    else
                    {
                        lblErrors.Text = "Erro na inserção de dados!";
                    }

                }
                if (result == DialogResult.Cancel)
                {
                    ItemScreen itemScreen = new ItemScreen();
                    itemScreen.Show();

                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Verifique se os dados dos campos estão no formato correto!");
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Verifique se os dados não estão vazios");
            }
          



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            ItemScreen itemScreen = new ItemScreen();
            itemScreen.Show();
        }


    }
}
