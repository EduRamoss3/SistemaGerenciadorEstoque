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
using SistemaGerenciadorInventario.Data;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SistemaGerenciadorInventario
{
    public partial class EditClient : Form
    {
        ClientAcess clienteAcess = new ClientAcess();
        private MainScreen mainScreen;
        public EditClient()
        {
            InitializeComponent();
            
        }
        public EditClient(MainScreen mainScreen, int id)
        {
           
            InitializeComponent();
            this.mainScreen = mainScreen;
            lblErrors.Visible = false;
            Client client = clienteAcess.AllOfClient(id);
            lblId.Text = client.Id.ToString();
            boxName.Text = client.Name;
            boxCpf.Text = client.CPF;
            boxEmail.Text = client.Email;
            dateTimeNascimento.Value = client.BirthDay;
            boxCity.Text = client.City;
            boxEstado.Text = client.State;
            boxNum.Text = client.Num.ToString();
            boxPhone.Text = client.Phone.ToString();
            if (client.Sex == "M")
            {
                radioMasc.Checked = true;
            }
            else
            {
                radioFemini.Checked = true;
            }
            boxRua.Text = client.Rua;
            numericQnt.Value = client.QntBuyItems;
            boxSaldo.Text = client.DownSale.ToString();
            lblDateEnter.Text = client.DateTimeEnter.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string resultSex = "";
            if (radioMasc.Checked == true)
            {
                resultSex = "M";
            }
            else
            {
                resultSex = "F";
            }
            Client client = new Client(int.Parse(lblId.Text), boxName.Text, dateTimeNascimento.Value, boxCpf.Text, Convert.ToInt32(numericQnt.Value), boxEmail.Text,
                                       resultSex, boxPhone.Text, boxCity.Text, boxRua.Text, int.Parse(boxNum.Text), boxEstado.Text);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(client);
            bool validate = Validator.TryValidateObject(client,context,validationResults);
            Regex regex = new Regex(@"^[0-9]+$");    // Expressão regular para verificar se os campos contém somente números
            bool validateTwo = false;
            if(boxEmail.Text.Contains("@") && boxEmail.Text.Contains(".com")) // Validando o campo Email, se ele contém 1 '@' e 1 '.com'
            {
                validateTwo = true;
            }
            else
            {
                validateTwo = false;
                MessageBox.Show("O campo email deve contér pelo menos um '@' e '.com', como o exemplo.");
            }
            if (regex.IsMatch(boxCpf.Text)) // Validando o campo CPF, se ele contém somente números ele valida e segue com o código
            {
                validateTwo = true;
            }
            else
            {
                validateTwo = false;
                MessageBox.Show("O Campo CPF deve contém somente números de 0 a 9");
            }
            if (regex.IsMatch(boxPhone.Text))   //Validando o campo telefone, se ele contém somente números ele valida a segunda validação e segue
            {
                validateTwo = true;
            }
            else
            {
                validateTwo = false;
                MessageBox.Show("O campo Telefone deve contér somente números.");
            }
            if (validate && validateTwo)
            {
                bool result = clienteAcess.UpdateClient(client);
                if (result)
                {
                    MessageBox.Show("Edições concluídas!");
                    this.Close();
                    mainScreen.UpdateTable();
                    
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach(ValidationResult validationResult in validationResults)
                {
                    sb.Append(validationResult).ToString();
                }
                lblErrors.Visible = true;
                lblErrors.Text = sb.ToString();
            }
            
        }
    }
}
