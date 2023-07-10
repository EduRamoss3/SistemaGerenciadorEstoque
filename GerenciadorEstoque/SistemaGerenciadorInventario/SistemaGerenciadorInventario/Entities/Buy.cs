using SistemaGerenciadorInventario.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciadorInventario.Entities
{
    internal class Buy
    {
        public int Id { get; set; }
        public Client _Cliente { get; set; }
        public Item _Item { get; set; }
        public SqlMoney Value { get; set; }
        public int Quantity { get; set; }
        public DateTime DataInit { get; set;  }
        public bool Payed { get; set; }
        public int PayedParcel { get; set; }
        public int QntParcel { get; set; }
        public Buy()
        {

        }
        public Buy( Client cliente, Item item, SqlMoney value, int quantity, DateTime dataInit, bool payed)
        {
            
            _Cliente = cliente;
            _Item = item;
            Value = value;
            Quantity = quantity;
            DataInit = dataInit;
            Payed = payed;
        }
        public Buy(Client cliente, Item item, SqlMoney value, int quantity, DateTime dataInit, int payedParcel, int qntParcel)
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
    }
}
