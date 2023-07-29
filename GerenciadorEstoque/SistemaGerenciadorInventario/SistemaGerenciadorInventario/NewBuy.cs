using SistemaGerenciadorInventario.Data;
using SistemaGerenciadorInventario.Entities;
using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGerenciadorInventario
{
    public partial class NewBuy : Form
    {
        public int receiveIdProduct { get; set; }
        public int receiveIdClient { get; set; }
        ClientAcess acess = new ClientAcess();
        InventoryAcess inventoryAcess = new InventoryAcess();
        BuyAcess buyAcess = new BuyAcess();
        Client client = new Client();

        Item item = new Item();


        public NewBuy()
        {
            InitializeComponent();
            numericQnt.Visible = false;
            lblQnt.Visible = false;
            comboValues.Visible = false;
            lblDate.Visible = false;
            dateTimePicker1.Visible = false;
            lblRemaing.Visible = false;
            lblTxtRmn.Visible = false;
            lblSaldo.ForeColor = Color.Green;
            if (lblSaldo.Text.Contains("-"))
            {
                lblSaldo.ForeColor = Color.Red;
            }
            lblEnter.Visible = false;
            numericUpPayed.Visible = false;

        }
        public SqlMoney[] cmbValues()                                                                           
        {
            SqlMoney[] vect = new SqlMoney[6];
            SqlMoney total = item.Price * numericQnt.Value;
            vect[0] = total / 2;
            vect[1] = total / 3;
            vect[2] = total / 4;
            vect[3] = total / 5;
            vect[4] = total / 6;
            vect[5] = total / 7;
            return vect;
        }

        private void radioAvist_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAvist.Checked)
            {
                UpdateTotal();
                lblDate.Visible = false;
                dateTimePicker1.Visible = false;
            }
        }
        private void radioParcel_CheckedChanged(object sender, EventArgs e)
        {
            if (lblProductName.Text != "." || lblProductName.Text != "Null" || lblProductName.Text != "")
            {
                if (radioParcel.Checked)
                {
                    comboValues.Visible = true;
                    lblEnter.Visible = true;
                    numericUpPayed.Visible = true;
                    lblRemaing.Visible = true; ;
                    lblTxtRmn.Visible = true;
                    lblEnter.Visible = true;
                    numericUpPayed.Visible = true;

                }
                else
                {
                    comboValues.Visible = false;
                    lblEnter.Visible = false;
                    numericUpPayed.Visible = false;
                    lblRemaing.Visible = false; ;
                    lblTxtRmn.Visible = false;
                    lblEnter.Visible = false;
                    numericUpPayed.Visible = false;
                }
                lblDate.Visible = true;
                dateTimePicker1.Visible = true;
                UpdateTotal();
            }
        }
        public void ClientToScreen()
        {
            client = acess.AllOfClient(receiveIdClient);
            lblIdn.Text = client.Id.ToString();
            lblName.Text = client.Name;
            lblCpf.Text = client.CPF;
            lblPhone.Text = client.Phone;
            if (client.DownSale.ToString() == "Null")
            {
                lblSaldo.Text = "0";
            }
            else
            {
                lblSaldo.Text = client.DownSale.ToString();
            }
            comboValues.Text = "Selecione um produto!";
            UpdateTotal();


        }
        public void UpdateTotal()
        {
            SqlMoney total = numericQnt.Value * item.Price;
            lblValueTotal.Text = "R$" + total.ToString();
            if (total.ToString() == "Null")
            {
                lblValueTotal.Text = "0";
            }
        }
        public void ProductToScreen()
        {
            item = inventoryAcess.GetAllOfItem(receiveIdProduct);
            lblProductID.Text = item.Id.ToString();
            lblProductName.Text = item.Name;
            lblProductPrice.Text = item.Price.ToString();
            lblProductQnt.Text = item.Quantity.ToString();
            lblProductType.Text = item.type.ToString();
            numericQnt.Visible = true;
            lblQnt.Visible = true;
            comboValues.Text = "Selecione a quantidade";
            UpdateTotal();


        }

        public void ChangeNumeric(object sender, EventArgs e)
        {
            comboValues.Items.Clear();
            UpdateTotal();
            SqlMoney[] vect = cmbValues();
            for (int i = 1; i < 7; i++)
            {
                comboValues.Items.Add(i + 1 + "x de R$" + vect[i - 1] + " sem juros!");

            }
            comboValues.Text = "2x de " + vect[0].ToString() + " sem juros!";

        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            OnlyClient clientScreen = new OnlyClient(this);
            clientScreen.Show();
        }

        private void btnSelecProd_Click(object sender, EventArgs e)
        {
            OnlyProduct productScreen = new OnlyProduct(this);
            productScreen.Show();
            numericUpPayed.Value = 0;
        }
        private void ChangeNumericNmb_Click(object sender, EventArgs e)
        {
            try
            {
                if (item != null)
                {
                    numericUpPayed.Visible = true;
                    string comboSelect = comboValues.Text;
                    int positionSelected = 0;

                    for (int i = 1; i < 7; i++)
                    {
                        if (comboSelect.Contains(i + 1 + "x"))
                        {

                            positionSelected = i + 1;
                        }
                    }
                    lblRemaing.Visible = true;
                    lblTxtRmn.Visible = true;


                    if (Convert.ToInt32(numericUpPayed.Value) > positionSelected - 1)
                    {
                        MessageBox.Show("Máximo de entrada já selecionado");
                        numericUpPayed.Value = positionSelected - 1;
                        if (numericUpPayed.Value < 0)
                        {
                            numericUpPayed.Value = 0;
                        }
                    }
                    else
                    {
                        SqlMoney total = item.Price * Convert.ToInt32(numericQnt.Value);
                        int numericUpPayedValue = Convert.ToInt32(numericUpPayed.Value);
                        SqlMoney remaining = (total / positionSelected) * (positionSelected - numericUpPayedValue);
                        lblRemaing.Text = remaining.ToString();

                    }
                }
                else
                {
                    numericUpPayed.Visible = false;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Primeiro, selecione a quantidade e a parcela.");
                lblRemaing.Visible = false;
                lblTxtRmn.Visible = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ResumeScreen resumeScreen = new ResumeScreen(this);
            OnlyProduct onlyProduct = new OnlyProduct(this);
            ItemScreen itemScreen = new ItemScreen(this);

            if (client != null && item != null)
            {
                progressBar1.Value = 20;
                Buy buy = new Buy(client, item, Convert.ToInt32(numericQnt.Value), DateTime.Now, item.Price);
                if (radioAvist.Checked)
                {
                    progressBar1.Value = 45;
                    bool trySale = buyAcess.TryNewSale(item, Convert.ToInt32(numericQnt.Value)); // Verificando se tem o item no estoque
                    if (trySale && numericQnt.Value > 0)
                    {
                        //se tem o item no estoque, irá realizar a compra
                        bool result = buyAcess.NewSale(buy, Convert.ToInt32(numericQnt.Value));
                        if (result)
                        {
                            //Realizando a compra, irá atualizar os dados e cadastrar na tabela de compras
                            progressBar1.Value = 100;
                            onlyProduct.UpdateTable();
                            itemScreen.UpdateTable();
                            itemScreen.UpdateTotal();
                            resumeScreen.UpdateTable();
                            MessageBox.Show("Compra realizada com sucesso!");
                            lblProductQnt.Text = (Convert.ToInt32(numericQnt.Value) - item.Quantity).ToString();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inadequada.");
                    }
                }
                if (radioParcel.Checked)
                {


                    string comboSelect = comboValues.Text;
                    int positionSelected = 0;
                    for (int i = 1; i < 7; i++)
                    {
                        if (comboSelect.Contains(i + 1 + "x"))
                        {

                            positionSelected = i + 1;
                        }
                    }
                    bool tryParcel = buyAcess.TryNewSale(item, Convert.ToInt32(numericQnt.Value)); // Verificando se tem o item no estoque
                    if (tryParcel)
                    {
                        if (positionSelected == Convert.ToInt32(numericUpPayed.Value))
                        {
                            Buy buyParceledPay = new Buy(client, item, Convert.ToInt32(numericQnt.Value), dateTimePicker1.Value, Convert.ToInt32(numericUpPayed.Value), positionSelected, true);
                            bool resultParcelPay = buyAcess.NewSaleParceledPay(buyParceledPay, Convert.ToInt32(numericQnt.Value));
                            if (resultParcelPay)
                            {
                                progressBar1.Value = 100;
                                onlyProduct.UpdateTable();
                                itemScreen.UpdateTable();
                                itemScreen.UpdateTotal();
                                resumeScreen.UpdateTable();
                                MessageBox.Show("Compra parcelada realizada com sucesso!");
                                lblProductQnt.Text = (Convert.ToInt32(numericQnt.Value) - item.Quantity).ToString();
                                this.Close();
                            }

                        }
                        Buy buyParcel = new Buy(client, item, Convert.ToInt32(numericQnt.Value), dateTimePicker1.Value, Convert.ToInt32(numericUpPayed.Value), positionSelected, false);
                        bool resultParcel = buyAcess.NewSaleParceled(buyParcel, Convert.ToInt32(numericQnt.Value));
                        if (resultParcel)
                        {
                            progressBar1.Value = 100;
                            onlyProduct.UpdateTable();
                            itemScreen.UpdateTable();
                            itemScreen.UpdateTotal();
                            resumeScreen.UpdateTable();
                            MessageBox.Show("Compra parcelada realizada com sucesso!");
                            lblProductQnt.Text = (Convert.ToInt32(numericQnt.Value) - item.Quantity).ToString();
                            this.Close();
                        }
                    }
                    else
                    {
                        lblEnter.Visible = false;
                        numericUpPayed.Visible = false;
                        lblRemaing.Visible = false;
                        lblTxtRmn.Visible = false;
                        lblEnter.Visible = false;
                        numericUpPayed.Visible = false;
                        MessageBox.Show("Estoque insuficiente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique se foi selecionado um PRODUTO e um CLIENTE");
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            progressBar1.Value = 0;
        }
    }
}



