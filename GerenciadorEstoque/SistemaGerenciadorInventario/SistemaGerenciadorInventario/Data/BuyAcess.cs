using SistemaGerenciadorInventario.Entities;
using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.SqlTypes;
using System.Windows.Forms;

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
        public Buy GetInfoToPay(int id)
        {
            Buy buy = new Buy();
            string sql = "SELECT * FROM BuysTable WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            ceConnection.Open();
            SqlCeDataReader response = CMD.ExecuteReader();
            if (response.Read())
            {
                buy.Id = response.GetInt32(0);
                Client client = new Client();
                Item item = new Item();


                // Atribuir valores às propriedades do cliente
                if (!response.IsDBNull(1))
                {
                    client.CPF = response.GetString(1);
                    // atribuir outros valores ao cliente, como CPF
                }


                // Atribuir valores às propriedades do item
                if (!response.IsDBNull(5))
                {
                    item.Name = response.GetString(5);
                    // atribuir outros valores ao item
                }

                // Atribuir instâncias de cliente e item às propriedades correspondentes em Buy
                buy._Cliente = client;
                buy._Item = item;

                // Atribuir valores às outras propriedades em Buy
                buy.Value = response.GetSqlMoney(2);
                buy.Quantity = response.GetInt32(3);
                buy.DataInit = response.GetDateTime(4);

                if (!response.IsDBNull(6))
                {
                    buy.Payed = response.GetBoolean(6);
                }
                if (!response.IsDBNull(7))
                {
                    buy.PayedParcel = response.GetSqlMoney(7);
                }

                if (!response.IsDBNull(8))
                {
                    buy.QntParcel = response.GetInt32(8);
                }
                if (!response.IsDBNull(9))
                {
                    buy.QntPayed = response.GetInt32(9);
                }

                if (!response.IsDBNull(10))
                {
                    buy.RemainingPay = response.GetSqlMoney(10);
                }

                ceConnection.Close();
            }
            return buy;
        }

        public DataTable ViewTableFature()
        {
            string sql = "SELECT C.Name, C.CPF, B.* FROM Client AS C INNER JOIN BuysTable AS B ON C.CPF = B.CPF WHERE C.DownSale > 0";
            SqlCeDataAdapter CMD = new SqlCeDataAdapter(sql, ceConnection);
            DataSet ds = new DataSet();
            CMD.Fill(ds);

            return ds.Tables[0];
        }
        public SqlMoney TotalMoney()
        {
            SqlMoney result = 0;
            string sql = "SELECT DownSale FROM Client WHERE Id > 0";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            ceConnection.Open();
            SqlCeDataReader response = CMD.ExecuteReader();
            while (response.Read())
            {
                result += response.GetSqlMoney(0);
            }
            ceConnection.Close();
            return result;
        }
        public bool UpdateBuy(Buy buy)
        {
         
            string sql = "UPDATE BuysTable SET Value = @Value, Quantity = @Quantity, DateInit = @DateInit, Payed = @Payed ," +
                " PayedParcel = @PayedParcel, QntPayed = @QntPayed, RemainingPay = @RemainingPay WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", buy.Id);
            CMD.Parameters.AddWithValue("@Value", buy.Value.ToString());
            CMD.Parameters.AddWithValue("@Quantity", buy.Quantity);
            CMD.Parameters.AddWithValue("@DateInit", buy.DataInit.ToString("dd/MM/yyyy"));
            CMD.Parameters.AddWithValue("@Payed", buy.Payed);
            CMD.Parameters.AddWithValue("@PayedParcel", buy.PayedParcel);
            CMD.Parameters.AddWithValue("@QntPayed", buy.QntPayed);
            CMD.Parameters.AddWithValue("@RemainingPay", buy.RemainingPay);

            string sql2 = "UPDATE Client SET DownSale = DownSale - @RemainingPay WHERE Id = @ClientId";
            SqlCeCommand CM2 = new SqlCeCommand(sql2, ceConnection);
            CM2.Parameters.AddWithValue("@RemainingPay", buy.RemainingPay);
            CM2.Parameters.AddWithValue("@ClientId", buy._Cliente.Id);

            try
            {
                ceConnection.Open();

                // Executar a primeira atualização (na tabela BuysTable)
                int rowsAffected1 = CMD.ExecuteNonQuery();

                // Executar a segunda atualização (na tabela Client)
                int rowsAffected2 = CM2.ExecuteNonQuery();

                if (rowsAffected1 > 0 && rowsAffected2 > 0)
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
            catch (Exception ex)
            {
                // Lida com possíveis exceções ou registra em um log de erros, se necessário
                Console.WriteLine("Erro ao atualizar os dados: " + ex.Message);
                return false;
            }
            finally
            {
                ceConnection.Close();
            }
        }
        public bool NewSale(Buy buy, int quantity)
        {
            try
            {
                string sql = "INSERT INTO BuysTable (CPF, Value, Quantity, DateInit, Name, Payed) VALUES (@CPF, @Value, @Quantity, @DateInit, @Name, @Payed)";
                SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
                CMD.Parameters.AddWithValue("@CPF", buy._Cliente.CPF);
                SqlMoney total = buy._Item.Price * quantity;
                CMD.Parameters.AddWithValue("@Value", total);
                CMD.Parameters.AddWithValue("@Quantity", quantity);
                CMD.Parameters.AddWithValue("@DateInit", buy.DataInit.ToString("dd/MM/yyyy"));
                CMD.Parameters.AddWithValue("@Name", buy._Item.Name);
                CMD.Parameters.AddWithValue("@Payed", 1);
                int newQnt = buy._Item.Quantity - quantity;
                bool updateStock = UpdateStock(buy._Item.Id, newQnt); ;
                bool attQntBuy = InsertQntBuyItems(buy._Cliente, quantity);
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
        public bool NewSaleParceled(Buy buy, int quantity)
        {
            SqlMoney total = buy._Item.Price * quantity;
            SqlMoney parcel = total / buy.QntParcel;
            SqlMoney remainingPay = parcel * (buy.QntParcel - buy.QntPayed); ;
            string sql = "INSERT INTO BuysTable (CPF, Value, Quantity, DateInit, Name, QntParcel, QntPayed,PayedParcel,RemainingPay) " +
                "VALUES  (@CPF, @Value, @Quantity, @DateInit, @Name, @QntParcel, @QntPayed, @PayedParcel ,@RemainingPay)";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@CPF", buy._Cliente.CPF);
            CMD.Parameters.AddWithValue("@Value", total);
            CMD.Parameters.AddWithValue("@Quantity", quantity);
            CMD.Parameters.AddWithValue("@DateInit", buy.DataInit.ToString("dd/MM/yyyy"));
            CMD.Parameters.AddWithValue("@Name", buy._Item.Name);
            CMD.Parameters.AddWithValue("@QntParcel", buy.QntParcel);
            CMD.Parameters.AddWithValue("@QntPayed", buy.QntPayed);
            CMD.Parameters.AddWithValue("@PayedParcel", parcel);
            CMD.Parameters.AddWithValue("@RemainingPay", remainingPay);
            int valueItem = SelectQntItem(buy._Item.Id);
            int valueTotal = valueItem - quantity;
            int newQnt = buy._Item.Quantity - quantity;
            bool updateStock = UpdateStock(buy._Item.Id, newQnt);
            bool attQntBuy = InsertQntBuyItems(buy._Cliente, quantity);
            bool downSaleUpdate = DownSaleUp(buy._Cliente, remainingPay);
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
                if (response == null)
                {
                    value = 0;
                    ceConnection.Close();
                }
                else
                {
                    value = response.GetSqlMoney(0);
                }

                ceConnection.Close();
            }

            string sql = "UPDATE Client SET DownSale = @DownSale WHERE Id = @id";
            SqlCeCommand CMD1 = new SqlCeCommand(sql, ceConnection);
            if (value > 0)
            {
                CMD1.Parameters.AddWithValue("@DownSale", value += remainingPay);
            }
            else
            {
                CMD1.Parameters.AddWithValue("@DownSale", remainingPay);
            }

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
        public bool NewSaleParceledPay(Buy buy, int quantity)
        {
            SqlMoney total = buy._Item.Price * quantity;
            SqlMoney parcel = buy._Item.Price / buy.QntParcel;
            string sql = "INSERT INTO BuysTable (CPF, Value, Quantity, DateInit, Name, QntParcel, QntPayed, RemainingPay, PayedParcel, Payed) " +
                "VALUES  (@CPF, @Value, @Quantity, @DateInit, @Name, @QntParcel, @QntPayed, @RemainingPay,@PayedParcel, @Payed)";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@CPF", buy._Cliente.CPF);
            CMD.Parameters.AddWithValue("@Value", total);
            CMD.Parameters.AddWithValue("@Quantity", quantity);
            CMD.Parameters.AddWithValue("@DateInit", buy.DataInit.ToString("dd/MM/yyyy"));
            CMD.Parameters.AddWithValue("@Name", buy._Item.Name);
            CMD.Parameters.AddWithValue("@QntParcel", buy.QntParcel);
            CMD.Parameters.AddWithValue("@QntPayed", buy.QntPayed);
            CMD.Parameters.AddWithValue("@PayedParcel", parcel);
            CMD.Parameters.AddWithValue("@RemainingPay", 0);
            CMD.Parameters.AddWithValue("@Payed", buy.Payed);
            int valueItem = SelectQntItem(buy._Item.Id);
            int valueTotal = valueItem - quantity;
            int newQnt = buy._Item.Quantity - quantity;
            bool updateStock = UpdateStock(buy._Item.Id, newQnt);
            bool attQntBuy = InsertQntBuyItems(buy._Cliente, quantity);
            bool downSaleUpdate = DownSaleUp(buy._Cliente, 0);
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
