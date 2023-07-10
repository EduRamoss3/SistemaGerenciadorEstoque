using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using SistemaGerenciadorInventario.Data;
using SistemaGerenciadorInventario.Entities;

namespace SistemaGerenciadorInventario.Data
{
    internal class BuyAcess
    {
        public readonly static SqlCeConnection ceConnection = new SqlCeConnection(@"Data Source = C:\Users\Eduardo\source\repos\MeusProgramasDesktop\GerenciadorEstoque\SistemaGerenciadorInventario\SistemaGerenciadorInventario\Data\SystemData.sdf; Max Database Size=4091");
        public bool TryNewSale(Item item, int quantity)
        {
            int selectQnt = SelectQntItem(item.Id);
            if (selectQnt - quantity < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool NewSale(Client client, Item item, int quantity, DateTime dateInit, SqlMoney value)
        {
            try
            {
                string sql = "INSERT INTO BuysTable (CPF, Value, Quantity, DateInit, Name, Payed) VALUES (@CPF, @Value, @Quantity, @DateInit, @Name, @Payed)";
                SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
                CMD.Parameters.AddWithValue("@CPF", client.CPF);
                SqlMoney total = item.Price * quantity;
                CMD.Parameters.AddWithValue("@Value", total);
                CMD.Parameters.AddWithValue("@Quantity", quantity);
                CMD.Parameters.AddWithValue("@DateInit", dateInit);
                CMD.Parameters.AddWithValue("@Name", item.Name);
                CMD.Parameters.AddWithValue("@Payed", 1);
                int newQnt = item.Quantity - quantity;
                bool updateStock = UpdateStock(item.Id, newQnt);
                bool attQntBuy = InsertQntBuyItems(client, quantity);
                ceConnection.Open();
                if (CMD.ExecuteNonQuery() > 0 && updateStock && attQntBuy)
                {
                    ceConnection.Close();
                    return true;
                }
                else
                {
                    ceConnection.Close();
                    return false;
                }
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Selecione um cliente");
                return false;
            }
        }
        public bool InsertQntBuyItems(Client client, int quantity)
        {
            string sql = "UPDATE Client SET QntBuyItems = @QntBuyItems WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            int qntNow = client.QntBuyItems + quantity;
            CMD.Parameters.AddWithValue("@QntBuyItems", qntNow);
            CMD.Parameters.AddWithValue("@id", client.Id);
            ceConnection.Open();
            if (CMD.ExecuteNonQuery() > 0)
            {
                ceConnection.Close();
                return true;
            }
            else
            {
                ceConnection.Close();
                return false;
            }
        }
        private static bool UpdateStock(int itemId, int newQuantity)
        {
            string updateSql = "UPDATE ItemTable SET Quantity = @NewQuantity WHERE Id = @ItemId";
            SqlCeCommand updateCmd = new SqlCeCommand(updateSql, ceConnection);
            updateCmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
            updateCmd.Parameters.AddWithValue("@ItemId", itemId);
            ceConnection.Open();
            if (updateCmd.ExecuteNonQuery() > 0)
            {
                ceConnection.Close();
                return true;

            }
            else
            {
                ceConnection.Close();
                return false;
            }


        }
        public bool NewSaleParceled(Client client, Item item, int quantity, DateTime dateInit, int qntPayed, int qntParcel)
        {
            SqlMoney total = item.Price * quantity;
            SqlMoney parcel = item.Price / qntParcel;
            SqlMoney remainingPay = parcel * (qntPayed - qntParcel);
            string sql = "INSERT INTO BuysTable (CPF, Value, Quantity, DateInit, Name, QntParcel, QntPayed,PayedParcel,RemainingPay) " +
                "VALUES  (@CPF, @Value, @Quantity, @DateInit, @Name, @QntParcel, @QntPayed, @PayedParcel ,@RemainingPay)";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@CPF", client.CPF);
            CMD.Parameters.AddWithValue("@Value", total);
            CMD.Parameters.AddWithValue("@Quantity", quantity);
            CMD.Parameters.AddWithValue("@DateInit", dateInit.ToString("dd/MM/yyyy"));
            CMD.Parameters.AddWithValue("@Name", item.Name);
            CMD.Parameters.AddWithValue("@QntParcel", qntParcel);
            CMD.Parameters.AddWithValue("@QntPayed", qntPayed);
            CMD.Parameters.AddWithValue("@PayedParcel", parcel);
            CMD.Parameters.AddWithValue("@RemainingPay", remainingPay);
            int valueItem = SelectQntItem(item.Id);
            int valueTotal = valueItem - quantity;
            int newQnt = item.Quantity - quantity;
            bool updateStock = UpdateStock(item.Id, newQnt);
            bool attQntBuy = InsertQntBuyItems(client, quantity);
            bool downSaleUpdate = DownSaleUp(client, remainingPay);
            ceConnection.Open();
            if (CMD.ExecuteNonQuery() > 0 && valueTotal >= 0 && downSaleUpdate && updateStock && attQntBuy)
            {
                ceConnection.Close();
                return true;
            }
            else
            {
                ceConnection.Close();
                return false;
            }
        }
        public bool DownSaleUp(Client client, SqlMoney remainingPay)
        {
            string sqlUp = "SELECT DownSale FROM Client WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sqlUp, ceConnection);
            CMD.Parameters.AddWithValue("@id", client.Id);
            ceConnection.Open();
            SqlCeDataReader response = CMD.ExecuteReader();
            SqlMoney value = 0;
            if (response.Read())
            {
                value = response.GetSqlMoney(0);
                ceConnection.Close();
            }

            string sql = "UPDATE Client SET DownSale = @DownSale WHERE Id = @id";
            SqlCeCommand CMD1 = new SqlCeCommand(sql, ceConnection);
            CMD1.Parameters.AddWithValue("@DownSale", value += remainingPay);
            CMD1.Parameters.AddWithValue("@id", client.Id);
            ceConnection.Open();
            if (CMD1.ExecuteNonQuery() > 0)
            {
                ceConnection.Close();
                return true;
            }
            else
            {
                ceConnection.Close();
                return false;
            }
        }
        public int SelectQntItem(int id)
        {
            ceConnection.Close();
            Item item = new Item();
            string sql = "SELECT * FROM ItemTable WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            ceConnection.Open();
            SqlCeDataReader response = CMD.ExecuteReader();

            if (response.Read())
            {

                item.Quantity = response.GetInt32(3);
                ceConnection.Close();
            }
            return item.Quantity;

        }
        public bool UpdateItem(Item item, int quantity)
        {
            string sqlup = "UPDATE ItemTable SET Quantity = @Quantity WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sqlup, ceConnection);
            CMD.Parameters.AddWithValue("@Quantity", item.Quantity - quantity);
            CMD.Parameters.AddWithValue("@Id", item.Id);
            ceConnection.Open();
            if (CMD.ExecuteNonQuery() > 0)
            {
                ceConnection.Close();
                return true;
            }
            else
            {
                ceConnection.Close();
                return false;
            }
        }
        public DataTable ViewTable()
        {
            string sql = "SELECT * FROM BuysTable";
            SqlCeDataAdapter CMD = new SqlCeDataAdapter(sql, ceConnection);
            DataSet ds = new DataSet();
            CMD.Fill(ds);
            return ds.Tables[0];
        }
        public bool NewSaleParceledPay(Client client, Item item, int quantity, DateTime dateInit, int qntPayed, int qntParcel, bool payed)
        {
            SqlMoney total = item.Price * quantity;
            SqlMoney parcel = item.Price / qntParcel;
            string sql = "INSERT INTO BuysTable (CPF, Value, Quantity, DateInit, Name, QntParcel, QntPayed, RemainingPay, PayedParcel, Payed) " +
                "VALUES  (@CPF, @Value, @Quantity, @DateInit, @Name, @QntParcel, @QntPayed, @RemainingPay,@PayedParcel, @Payed)";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@CPF", client.CPF);
            CMD.Parameters.AddWithValue("@Value", total);
            CMD.Parameters.AddWithValue("@Quantity", quantity);
            CMD.Parameters.AddWithValue("@DateInit", dateInit.ToString("dd/MM/yyyy"));
            CMD.Parameters.AddWithValue("@Name", item.Name);
            CMD.Parameters.AddWithValue("@QntParcel", qntParcel);
            CMD.Parameters.AddWithValue("@QntPayed", qntPayed);
            CMD.Parameters.AddWithValue("@PayedParcel", parcel);
            CMD.Parameters.AddWithValue("@RemainingPay", 0);
            CMD.Parameters.AddWithValue("@Payed", payed);
            int valueItem = SelectQntItem(item.Id);
            int valueTotal = valueItem - quantity;
            int newQnt = item.Quantity - quantity;
            bool updateStock = UpdateStock(item.Id, newQnt);
            bool attQntBuy = InsertQntBuyItems(client, quantity);
            bool downSaleUpdate = DownSaleUp(client, 0);
            ceConnection.Open();
            if (CMD.ExecuteNonQuery() > 0 && valueTotal >= 0 && downSaleUpdate && updateStock && attQntBuy)
            {
                ceConnection.Close();
                return true;
            }
            else
            {
                ceConnection.Close();
                return false;
            }
        }
    }
}
