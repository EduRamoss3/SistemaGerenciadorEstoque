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
       

        public Buy(Client client, Item item, int quantity, DateTime now, SqlMoney price)
        {
            _Cliente = client;
            _Item = item;
            Quantity = quantity;
            DataInit = now;
            Value = price;
        }

        public Buy(Client client, Item item, int quantity, DateTime dataInit, int qntPayed, int qntParcel, bool payed, SqlMoney remainingPay, SqlMoney payedParcel) // ParceledPay
        {
            _Cliente = client;
            _Item = item;
            Quantity = quantity;
            DataInit = dataInit;
            QntPayed = qntPayed;
            QntParcel = qntParcel;
            Payed = payed;
            RemainingPay = remainingPay;
            PayedParcel = payedParcel;
        }
    }
}
