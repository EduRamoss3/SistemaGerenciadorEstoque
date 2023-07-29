using SistemaGerenciadorInventario.Data;
using SistemaGerenciadorInventario.Entities;
using System;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SistemaGerenciadorInventario
{
    public partial class PayingScreen : Form
    {
        BuyAcess buyAcess = new BuyAcess();
        private ResumeScreen resume;
        MainScreen mainScreen = new MainScreen();
        public int receiveId;

        public PayingScreen(int id)
        {
            InitializeComponent();
            BuyToScreen(id);
        }
        public PayingScreen(int id, ResumeScreen resume)
        {
            InitializeComponent();
            this.resume = resume;
            BuyToScreen(id);


        }
        public void BuyToScreen(int id)
        {
            receiveId = id;
            Buy buy = buyAcess.GetInfoToPay(id);
            lblId.Text = buy.Id.ToString();
            lblClientCPF.Text = buy._Cliente.CPF;
            lblBuyDate.Text = buy.DataInit.ToString("dd/MM/yyyy");
            lblBuyValue.Text = buy.Value.ToString();
            lblBuyProduct.Text = buy._Item.Name;
            lblBuyQnt.Text = buy.Quantity.ToString();
            if (buy.Payed)
            {
                lblBuyCheckPay.Checked = true;
            }
            else
            {
                lblBuyCheckPay.Checked = false;
                lblBuyCheckNo.Checked = true;
            }
            lblBuyQntParcel.Text = buy.QntParcel.ToString();
            numericUpDown1.Value = Convert.ToDecimal(buy.QntPayed);
            lblBuyQntPayed.Text = buy.QntPayed.ToString();
            txtRemaining.Text = buy.RemainingPay.ToString();
            if (buy.RemainingPay.ToString() == "Null" || buy.RemainingPay == 0)
            {
                btnOk.Visible = false;
                txtRemaining.Text = "0";
            }
            lblValueParcel.Text = buy.PayedParcel.ToString();
            numericUpDown1.Maximum = int.Parse(lblBuyQntParcel.Text);


        }
        public void btnCheckChange(object sender, EventArgs e)
        {
            if (lblBuyCheckPay.Checked)
            {
                lblBuyCheckNo.Checked = false;
                if (lblBuyQntParcel.Text != ".")
                {

                    numericUpDown1.Value = int.Parse(lblBuyQntParcel.Text);

                }
            }

        }
        public void ChangeSignature(object sender, EventArgs e)
        {
            if(txtRemaining.Text != "")
            {
                SqlMoney value = SqlMoney.Parse(txtRemaining.Text);

                int numeric = (int)numericUpDown1.Value;
                SqlMoney newValue = value - (numeric * SqlMoney.Parse(lblValueParcel.Text));

            }


        }
        public void btnCheckChangeFalse(object sender, EventArgs e)
        {
            if (lblBuyCheckNo.Checked)
            {
                lblBuyCheckPay.Checked = false;
                numericUpDown1.Value = 0;
                numericUpDown1.Enabled = true;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            Client client = new Client();
            Item item = new Item();
            buy.Id = int.Parse(lblId.Text);
            client.CPF = lblClientCPF.Text;
            client.Id = int.Parse(lblId.Text);  
            buy._Cliente = client;
            buy.DataInit = DateTime.Parse(lblBuyDate.Text);
            buy.Value = SqlMoney.Parse(lblBuyValue.Text);
            item.Name = lblBuyValue.Text;
            buy._Item = item;
            buy.Quantity = int.Parse(lblBuyQnt.Text);
            buy.QntParcel = int.Parse(lblBuyQntParcel.Text);
            buy.QntPayed = Convert.ToInt32(numericUpDown1.Value);
            if (buy.QntPayed == buy.QntParcel)
            {
                lblBuyCheckPay.Checked = true;
                buy.Payed = true;
            }
            else
            {
                buy.Payed = false;
            }
            bool payment = buyAcess.UpdateBuy(buy);
            if (payment)
            {
                resume.UpdateTable();
                mainScreen.UpdateTable();
                MessageBox.Show("Pagamento realizado com sucesso");
                this.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
