using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace SistemaGerenciadorInventario.Data
{
    internal class Client
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        public DateTime DateTimeEnter { get; set; }
        [StringLength(11)]
        [Required]
        public string CPF { get; set; }
        public int QntBuyItems { get; set; }
        public SqlMoney DownSale { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string City { get; set; }
        [Required]
        public string Rua { get; set; }
        [Required]
        [Range(1, 9999, ErrorMessage = "O numero máximo é de 9999")]
        public int Num { get; set; }
        [Required]
        [StringLength(10)]
        public string State { get; set; }

        public Client()
        {

        }
        public Client(int id, string name, DateTime birthDay, string cpf, int qntBuyItems, string email, string sex, string phone, string city, string rua, int num, string state)
        {
            Id = id;
            Name = name;
            BirthDay = birthDay;
            CPF = cpf;
            QntBuyItems = qntBuyItems;
            Email = email;
            Sex = sex;
            Phone = phone;
            City = city;
            Rua = rua;
            Num = num;
            State = state;

        }
        public Client(string name, DateTime birthDay, DateTime dataEnter, string cpf, string email, string sex, string phone, string city, string rua, int num, string state)
        {

            Name = name;
            BirthDay = birthDay;
            DateTimeEnter = dataEnter;
            CPF = cpf;
            Email = email;
            Sex = sex;
            Phone = phone;
            City = city;
            Rua = rua;
            Num = num;
            State = state;
        }
        public Client(int id, string name, DateTime birthDay, DateTime dateTimeEnter, string cPF, int qntBuyItems, SqlMoney downSale, string email, string sex, string phone, string city, string rua, int num, string state) : this(id, name, birthDay, dateTimeEnter, cPF, qntBuyItems, downSale)
        {
            Email = email;
            Sex = sex;
            Phone = phone;
            City = city;
            Rua = rua;
            Num = num;
            State = state;
        }

        public Client(int id, string name, DateTime birthDay, DateTime dateTimeEnter, string cPF, int qntBuyItems, SqlMoney saldoDevedor)
        {
            Id = id;
            Name = name;
            BirthDay = birthDay;
            this.DateTimeEnter = dateTimeEnter;
            CPF = cPF;
            QntBuyItems = qntBuyItems;
            DownSale = saldoDevedor;
        }
    }
}
