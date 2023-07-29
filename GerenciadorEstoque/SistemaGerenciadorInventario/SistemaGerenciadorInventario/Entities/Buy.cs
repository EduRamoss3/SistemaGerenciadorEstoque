using SistemaGerenciadorInventario.Data;
using System;
using System.Data.SqlTypes;

namespace SistemaGerenciadorInventario.Entities
{
    internal class Buy
    {
        public int Id { get; set; }
        public Client _Cliente { get; set; }
        public Item _Item { get; set; }
        public SqlMoney Value { get; set; }
        public int Quantity { get; set; }
        public DateTime DataInit { get; set; }
        public bool Payed { get; set; }
        public SqlMoney PayedParcel { get; set; }
        public int QntParcel { get; set; }
        public int QntPayed { get; set; }
        public SqlMoney RemainingPay { get; set; }


        public Buy()
        {

        }
        public Buy(Client cliente, Item item, SqlMoney value, int quantity, DateTime dataInit, bool payed)
        {

            _Cliente = cliente;
            _Item = item;
            Value = value;
            Quantity = quantity;
            DataInit = dataInit;
            Payed = payed;
        }
        public Buy(Client cliente, Item item, SqlMoney value, int quantity, DateTime dataInit, SqlMoney payedParcel, int qntParcel)
        {

            _Cliente = cliente;
            _Item = item;
            Value = value;
            Quantity = quantity;
            DataInit = dataInit;
            PayedParcel = payedParcel;
            QntParcel = qntParcel;

        }
        public Buy(Client cliente, Item item, SqlMoney value, int quantity, DateTime dataInit, int qntParcel)
        {

            _Cliente = cliente;
            _Item = item;
            Value = value;
            Quantity = quantity;
            DataInit = dataInit;
            QntParcel = qntParcel;

        }

        public Buy(Client client, Item item, int quantity, DateTime now, SqlMoney price)
        {
            _Cliente = client;
            _Item = item;
            Quantity = quantity;
            DataInit = now;
            Value = price;
        }
        public Buy(Client cliente, Item item, int quantity, DateTime dataInit, SqlMoney payedParcel, int qntParcel, int qntPayed, bool payed)
        {

            _Cliente = cliente;
            _Item = item;
            Quantity = quantity;
            DataInit = dataInit;
            PayedParcel = payedParcel;
            QntParcel = qntParcel;
            QntPayed = qntPayed;
            Payed = payed;

        }
        public Buy(Client client, Item item, int quantity, DateTime dataInit, int qntPayed, int qntParcel, bool payed) // ParceledPay
        {
            _Cliente = client;
            _Item = item;
            Quantity = quantity;
            DataInit = dataInit;
            QntPayed = qntPayed;
            QntParcel = qntParcel;
            Payed = payed;
        }
    }
}
