using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SistemaGerenciadorInventario.Entities;
using SistemaGerenciadorInventario.Entities.Enum;
using Type = SistemaGerenciadorInventario.Entities.Enum.Type;

namespace SistemaGerenciadorInventario.Data
{
    internal class InventoryAcess
    {
        public readonly static SqlCeConnection ceConnection = new SqlCeConnection(@"Data Source = C:\Users\Eduardo\source\repos\MeusProgramasDesktop\GerenciadorEstoque\SistemaGerenciadorInventario\SistemaGerenciadorInventario\Data\SystemData.sdf; Max Database Size=4091");
        public Item GetAllOfItem(int id)
        {
            string sql = "SELECT * FROM ItemTable WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            ceConnection.Open();  
            SqlCeDataReader response = CMD.ExecuteReader();
            Item item = new Item();
            if (response.Read())
            {
                string Typer;
                item.Id = response.GetInt32(0);
                item.Name = response.GetString(1);
                item.Price = response.GetSqlMoney(2);
                Typer = response.GetString(4);
                Type os;
                Enum.TryParse(Typer, out os);
                item.type = os;
                item.Quantity = response.GetInt32(3);
            }
            ceConnection.Close();
            return item;
        }
     
        public SqlMoney SelectOneItem(int id)
        {
            SqlMoney total = 0;
            string sql = "SELECT * FROM ItemTable WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            ceConnection.Open();
            SqlCeDataReader response = CMD.ExecuteReader();
            
            while (response.Read())
            {
                Item item = new Item();
                item.Price = response.GetSqlMoney(2);
                item.Quantity = response.GetInt32(3);
                item.Total = item.Price * item.Quantity;
                total += item.Total;
            }

            ceConnection.Close();
            return total;
        }
        public SqlMoney Total()
        {
            SqlMoney total = 0;

            string sql = "SELECT * FROM ItemTable WHERE Id > 0";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            ceConnection.Open();
            SqlCeDataReader response = CMD.ExecuteReader();

            while (response.Read())
            {
                Item item = new Item();
                item.Price = response.GetSqlMoney(2);
                item.Quantity = response.GetInt32(3);
                item.Total = item.Price * item.Quantity;
                total += item.Total;
            }

            ceConnection.Close();
            return total;
        }
        public bool RemoveOneProduct(int id)
        {
            ceConnection.Close();
            //Agora, removendo 1 com base na quantidade atual
            int quantity = TakeQnt(id);
            string sql = "UPDATE ItemTable SET Quantity = @Quantity WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            CMD.Parameters.AddWithValue("@Quantity", quantity - 1);
            ceConnection.Open();
            CMD.ExecuteNonQuery();
            if (quantity >= 1)
            {
                ceConnection.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Impossivel remover de 0");
                ceConnection.Close();
                return false;
            }
        }
        public int TakeQnt(int id)
        {
            Item item = new Item();
            string sql = "SELECT * FROM ItemTable WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            ceConnection.Open();
            SqlCeDataReader response = CMD.ExecuteReader();
            if (response.Read())
            {
                item.Id = response.GetInt32(0);
                item.Quantity = response.GetInt32(3);
            
            }
            ceConnection.Close();
            return item.Quantity;
        }
        public bool OneMoreProduct(int id)
        {
            ceConnection.Close();
            //Agora, adicionando +1 com base na quantidade atual
            int quantity = TakeQnt(id);
            string sql = "UPDATE ItemTable SET Quantity = @Quantity WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            CMD.Parameters.AddWithValue("@Quantity", quantity+1);
            ceConnection.Open();
            CMD.ExecuteNonQuery();
            if(CMD.ExecuteNonQuery() > 0)
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

            string sql = "SELECT * FROM ItemTable";
            SqlCeDataAdapter DataAdapter = new SqlCeDataAdapter(sql, ceConnection);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet);
            return DataSet.Tables[0];
        }
        public Item ViewItem(int id)
        {
            Item item = new Item();
            string sql = "SELECT * FROM ItemTable WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql,ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            ceConnection.Open();
            SqlCeDataReader response = CMD.ExecuteReader();
            if (response.Read())
            {
                item.Id = response.GetInt32(0);
                item.Name = response.GetString(1);
                item.Price = response.GetSqlMoney(2);
                item.Quantity = response.GetInt32(3);
                try {

                    string Typez = response.GetString(4);
                    Type o;
                    Enum.TryParse(Typez, out o);
                    item.type = o;
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    MessageBox.Show("Valor nulo");
                }          
                item.DataEnter = response.GetDateTime(5);   
            }
            ceConnection.Close();
            return item;
        }
        public bool InsertItem(Item item)
        {
            ceConnection.Close();
            string sql = "INSERT INTO ItemTable (Name,Price,Quantity,Type,DataEnter) VALUES (@Name, @Price, @Quantity,@Type, @DataEnter)";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@Name", item.Name);
            CMD.Parameters.AddWithValue("@Price", item.Price);
            CMD.Parameters.AddWithValue("@Quantity", item.Quantity);
            CMD.Parameters.AddWithValue("@Type", item.type);
            CMD.Parameters.AddWithValue("DataEnter", item.DataEnter.ToString("dd/MM/yyyy HH:mm:ss"));

            ceConnection.Open();
            CMD.ExecuteNonQuery();
            ceConnection.Close();
            return true;

        }
        public bool DeleteItem(int id)
        {
            ceConnection.Close();
            string sql = "DELETE FROM ItemTable WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            ceConnection.Open();
            CMD.ExecuteNonQuery();
            if(CMD.ExecuteNonQuery() == 0 && CMD.ExecuteNonQuery() > 0)
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
        public bool UpdateItem(Item item , int id)
        {
            ceConnection.Close();
            string sql = "UPDATE ItemTable SET Name = @Name, Price = @Price, Quantity = @Quantity, Type = @Type WHERE Id = @id";
            SqlCeCommand CMD = new SqlCeCommand(sql, ceConnection);
            CMD.Parameters.AddWithValue("@id", id);
            CMD.Parameters.AddWithValue("@Name", item.Name);
            CMD.Parameters.AddWithValue("@Price", item.Price);
            CMD.Parameters.AddWithValue("Quantity", item.Quantity);
            CMD.Parameters.AddWithValue("@Type", item.type);
            ceConnection.Open();
            CMD.ExecuteNonQuery();
            if(CMD.ExecuteNonQuery() >= 0)
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
