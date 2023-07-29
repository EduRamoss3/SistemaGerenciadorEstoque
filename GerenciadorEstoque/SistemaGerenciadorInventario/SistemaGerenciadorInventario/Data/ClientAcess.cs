using System;
using System.Data;
using System.Data.SqlServerCe;

namespace SistemaGerenciadorInventario.Data
{
    internal class ClientAcess
    {
        public readonly static SqlCeConnection ceConnection = new SqlCeConnection(@"Data Source = C:\Users\Eduardo\source\repos\MeusProgramasDesktop\GerenciadorEstoque\SistemaGerenciadorInventario\SistemaGerenciadorInventario\Data\SystemData.sdf; Max Database Size=4091");
        public Client AllOfClient(int id)
        {
            string sql = "SELECT * FROM Client WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            ceConnection.Open();
            SqlCeDataReader response = CMD.ExecuteReader();
            Client client = new Client();
            if (response.Read())
            {
                client.Id = response.GetInt32(0);
                client.Name = response.GetString(1);
                client.BirthDay = response.GetDateTime(2);
                client.DateTimeEnter = response.GetDateTime(3);
                client.CPF = response.GetString(4);
                if (!response.IsDBNull(5))
                    client.QntBuyItems = response.GetInt32(5);

                if (!response.IsDBNull(6))
                    client.DownSale = response.GetSqlMoney(6);
                client.Email = response.GetString(7);
                client.Sex = response.GetString(8);
                client.Phone = response.GetString(9);
                client.City = response.GetString(10);
                client.Rua = response.GetString(11);
                client.Num = response.GetInt32(12);
                client.State = response.GetString(13);


            }
            ceConnection.Close();
            return client;
        }
        public bool UpdateClient(Client client)
        {
            string sql = "UPDATE Client SET Name = @Name, Birthday = @BirthDay ,CPF = @CPF,QntBuyItems = @QntBuyItems,DownSale = @DownSale," +
                " Email = @Email,Sex = @Sex,Phone = @Phone,City = @City,Rua = @Rua,Num = @Num,State = @State WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@Id", client.Id);
            CMD.Parameters.AddWithValue("@Name", client.Name);
            CMD.Parameters.AddWithValue("@BirthDay", client.BirthDay.ToString("dd/MM/yyyy HH:mm:ss"));
            CMD.Parameters.AddWithValue("@CPF", client.CPF);
            CMD.Parameters.AddWithValue("@QntBuyItems", client.QntBuyItems.ToString());
            CMD.Parameters.AddWithValue("@DownSale", client.DownSale.ToSqlString());
            CMD.Parameters.AddWithValue("@Email", client.Email);
            CMD.Parameters.AddWithValue("@Sex", client.Sex);
            CMD.Parameters.AddWithValue("@Phone", client.Phone.ToString());
            CMD.Parameters.AddWithValue("@City", client.City);
            CMD.Parameters.AddWithValue("@Rua", client.Rua);
            CMD.Parameters.AddWithValue("@Num", client.Num.ToString());
            CMD.Parameters.AddWithValue("@State", client.State);
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


        public Client InfoCliente(int id)
        {
            string sql = "SELECT Name FROM Client WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            ceConnection.Open();
            SqlCeDataReader response = CMD.ExecuteReader();
            Client client = new Client();
            if (response.Read())
            {
                client.Name = response.GetString(0);

            }
            ceConnection.Close();
            return client;
        }
        public void RemoveClient(int id)
        {
            string sql = "DELETE FROM Client WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            ceConnection.Open();
            CMD.ExecuteNonQuery();
            ceConnection.Close();
        }
        public DataTable DataGet()
        {
            string sql = "SELECT * FROM Client";
            SqlCeDataAdapter sqlCeData = new SqlCeDataAdapter(sql, ceConnection);
            DataSet dataSet = new DataSet();
            sqlCeData.Fill(dataSet);
            return dataSet.Tables[0];
        }
        public bool InsertClient(Client client)
        {
            string sql = "INSERT INTO Client (Name, BirthDay, DataEnter, CPF, Email, Sex, Phone, City, Rua, Num, State) VALUES (@Name, @BirthDay, @DataEnter, @CPF, @Email, @Sex, @Phone, @City, @Rua, @Num, @State)";

            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@Name", client.Name);
            CMD.Parameters.AddWithValue("@BirthDay", client.BirthDay.ToString("dd/MM/yyyy"));
            CMD.Parameters.AddWithValue("@DataEnter", client.DateTimeEnter.ToString("dd/MM/yyyy HH:mm:ss"));
            CMD.Parameters.AddWithValue("@CPF", client.CPF);
            CMD.Parameters.AddWithValue("@Email", client.Email);
            CMD.Parameters.AddWithValue("@Sex", client.Sex);
            CMD.Parameters.AddWithValue("@Phone", client.Phone);
            CMD.Parameters.AddWithValue("@City", client.City);
            CMD.Parameters.AddWithValue("@Rua", client.Rua);
            CMD.Parameters.AddWithValue("@Num", client.Num.ToString());
            CMD.Parameters.AddWithValue("@State", client.State);
            
            ceConnection.Open();
            if (CMD.ExecuteNonQuery() >= 0)
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
