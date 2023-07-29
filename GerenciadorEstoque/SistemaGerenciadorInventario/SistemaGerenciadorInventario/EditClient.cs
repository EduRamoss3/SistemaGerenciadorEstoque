using SistemaGerenciadorInventario.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            if(client.DownSale.ToString() == "Null")
            {
                boxSaldo.Text = "0";
            }
            else
            {
                boxSaldo.Text = client.DownSale.ToString();
            }
            lblDateEnter.Text = client.DateTimeEnter.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string resultSexo = "";
            if (radioMasc.Checked == true)
            {
                resultSexo = "M";
            }
            else
            {
                resultSexo = "F";
            }
            Client cliente = new Client(int.Parse(lblId.Text), boxName.Text, dateTimeNascimento.Value, boxCpf.Text, Convert.ToInt32(numericQnt.Value), boxEmail.Text,
                                       resultSexo, boxPhone.Text, boxCity.Text, boxRua.Text, int.Parse(boxNum.Text), boxEstado.Text);

            // Verificação de validação para o objeto Cliente
            List<ValidationResult> resultadosValidacao = new List<ValidationResult>();
            ValidationContext contexto = new ValidationContext(cliente);
            bool eValidoCliente = Validator.TryValidateObject(cliente, contexto, resultadosValidacao);

            // Expressão regular para verificar números
            Regex regex = new Regex(@"^[0-9]+$");

            // Verificação de validação para o email
            bool eValidoEmail = boxEmail.Text.Contains("@") && boxEmail.Text.Contains(".com");
            if (!eValidoEmail)
            {
                MessageBox.Show("O campo email deve conter pelo menos um '@' e '.com', como no exemplo.");
            }

            // Verificação de validação para o CPF
            bool eValidoCpf = regex.IsMatch(boxCpf.Text);
            if (!eValidoCpf)
            {
                MessageBox.Show("O campo CPF deve conter somente números de 0 a 9.");
            }

            // Verificação de validação para o número de telefone
            bool eValidoTelefone = regex.IsMatch(boxPhone.Text);
            if (!eValidoTelefone)
            {
                MessageBox.Show("O campo Telefone deve conter somente números.");
            }

            // Resultado geral da validação
            bool dadosSaoValidos = eValidoCliente && eValidoEmail && eValidoCpf && eValidoTelefone;

            if (dadosSaoValidos)
            {
                // Supondo que o nome correto da variável seja clientAcess
                bool resultado = clienteAcess.UpdateClient(cliente);
                if (resultado)
                {
                    MessageBox.Show("Edições concluídas!");
                    this.Close();
                    mainScreen.UpdateTable();
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (ValidationResult resultadoValidacao in resultadosValidacao)
                {
                    sb.Append(resultadoValidacao).AppendLine();
                }
                lblErrors.Visible = true;
                lblErrors.Text = sb.ToString();
            }
        }
    }
}
