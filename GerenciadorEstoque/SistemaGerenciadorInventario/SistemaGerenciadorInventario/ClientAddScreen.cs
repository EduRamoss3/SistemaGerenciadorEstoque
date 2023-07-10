using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGerenciadorInventario.Data;
using SistemaGerenciadorInventario.Entities;

namespace SistemaGerenciadorInventario
{
    public partial class ClientAddScreen : Form
    {
        ClientAcess acess = new ClientAcess();
        private OnlyClient onlyclient;
        public ClientAddScreen()
        {
            InitializeComponent();
        }
        public ClientAddScreen(OnlyClient onlyClient)
        {
            InitializeComponent();
            this.onlyclient = onlyClient;
        }
        private void register_Click(object sender, EventArgs e)
        {
            //Registrando cliente
            try
            {
                string resultSex = "";
                if (radioMasc.Checked == true)
                {
                    resultSex = "M";
                }
                else if (radioFemini.Checked == true)
                {
                    resultSex = "F";
                }
                Client client = new Client(
                    boxName.Text,
                    dateTimePicker1.Value,
                    DateTime.Now,
                    boxCPF.Text,
                    boxEmail.Text,
                    resultSex, boxTel.Text,
                    boxCity.Text,
                    boxStreet.Text,
                    int.Parse(boxNumero.Text),
                    boxState.Text);
                ValidationContext context = new ValidationContext(client);
                List<ValidationResult> validationResults = new List<ValidationResult>();
                bool validate = Validator.TryValidateObject(client, context, validationResults);
                bool validations = false;
                //validações de campos
                if (boxEmail.Text.Contains("@") && boxEmail.Text.Contains(".com"))
                {
                    validations = true;
                }
                else
                {
                    MessageBox.Show("O email deve ser escrito no formato 'exemplo@gmail.com' ");
                    validations = false;
                }
                string cpf = boxCPF.Text;
                Regex regex = new Regex(@"^[0-9]+$"); // Expressão regular para verificar se contém apenas números
                if (regex.IsMatch(cpf))
                {
                    validations = true;
                }
                else
                {
                    MessageBox.Show("O CPF Deve conter somente números.");
                    validations = false;
                }
                if (validate && validations)
                {
                    bool resultClient = acess.InsertClient(client);
                    if (resultClient)
                    {
                        MainScreen mainScreen = new MainScreen();
                        mainScreen.UpdateTable();
                        onlyclient.UpdateTable();
                        this.Close();
                    }
                    else
                    {
                        lblErrors.Text = "Erro na inserção de dados!";
                    }
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    //Validação de erros
                    foreach (ValidationResult validationResult in validationResults)
                    {
                        sb.AppendLine(validationResult.ErrorMessage);
                    }
                    lblErrors.Text = sb.ToString();
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
    }
}


