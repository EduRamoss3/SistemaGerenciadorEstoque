using SistemaGerenciadorInventario.Data;
using SistemaGerenciadorInventario.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Text;
using System.Windows.Forms;
using Type = SistemaGerenciadorInventario.Entities.Enum.Type;

namespace SistemaGerenciadorInventario
{

    public partial class NewItem : Form
    {
        InventoryAcess inventoryAcess = new InventoryAcess();
        private ItemScreen itemScreen;
        private OnlyProduct onlyProduct;

        public NewItem(OnlyProduct onlyProduct, ItemScreen itemScreen)
        {
            InitializeComponent();
            this.onlyProduct = onlyProduct;
            this.itemScreen = itemScreen;
            comboBox1.Items.Add("Acessorio");
            comboBox1.Items.Add("Eletronico");
            comboBox1.Items.Add("Mecânico");
            comboBox1.Items.Add("Comida");
            comboBox1.Items.Add("Bebida");
            comboBox1.Items.Add("Leitura");
            comboBox1.Items.Add("Ferramenta");
            comboBox1.Items.Add("Virtual");
            dateTimePicker1.Value = DateTime.Now;
            lblErrors.Visible = true;
        }
        public NewItem(ItemScreen itemScreen)
        {
            InitializeComponent();
            comboBox1.Items.Add("Acessorio");
            comboBox1.Items.Add("Eletronico");
            comboBox1.Items.Add("Mecânico");
            comboBox1.Items.Add("Comida");
            comboBox1.Items.Add("Bebida");
            comboBox1.Items.Add("Leitura");
            comboBox1.Items.Add("Ferramenta");
            comboBox1.Items.Add("Virtual");
            dateTimePicker1.Value = DateTime.Now;
            lblErrors.Visible = true;
            this.itemScreen = itemScreen;
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            try
            {
                //Passando os dados da tela 'New Item'  para a classe item
                Item item = new Item();
                item.Name = boxName.Text;
                if (item.Name.Length < 5)
                {
                    MessageBox.Show("Nome precisa ter mais do que 5 caracteres");
                }
                item.Price = SqlMoney.Parse(boxPrice.Text);
                item.Quantity = Decimal.ToInt32(numericUpDown1.Value);
                item.DataEnter = dateTimePicker1.Value;
                Type o;   //Instanciando um Enum para conversão de string
                Enum.TryParse(comboBox1.Text, out o);  //Convertendo a string do combobox
                item.type = o;   //Se for verdadeira, registra o dado 

                List<ValidationResult> validations = new List<ValidationResult>();
                ValidationContext context = new ValidationContext(item);
                bool validate = Validator.TryValidateObject(item, context, validations, true);


                if (validate)
                {
                    bool result = inventoryAcess.InsertItem(item);
                    if (result)
                    {
                        itemScreen.UpdateTable();
                        if(onlyProduct != null)
                        {
                            onlyProduct.UpdateTable();
                        }
                        
                        NewBuy newBuy = new NewBuy();

                        this.Close();

                    }
                    else
                    {
                        lblErrorss.Text = "Erro na inserção de dados!";
                    }

                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    //Validação de erros
                    foreach (ValidationResult validationResult in validations)
                    {
                        sb.AppendLine(validationResult.ErrorMessage);
                    }
                    lblErrorss.Text = sb.ToString();
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

        }
    }
}
