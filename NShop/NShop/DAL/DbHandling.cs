using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using NShop.DTO;

namespace NShop.DAL
{
    internal class DbHandling
    {
        string connectionString = @"server=.;Database = GameShopDB;Integrated Security = True;TrustServerCertificate = True";


        public List<ProductDTO> LoadProducts()
        {
            var list = new List<ProductDTO>();
            using var connection = new SqlConnection(connectionString);
            const string sql = @"
                SELECT p.ProductID, p.ProductName, p.Price, 
                       p.ShortDesc, p.Category, s.Quantity 
                FROM Products p
                INNER JOIN Stock s ON p.ProductID = s.ProductID";

            using var command = new SqlCommand(sql, connection);
            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new ProductDTO
                {
                    ProductID = Convert.ToInt32(reader["ProductID"]),
                    ProductName = reader["ProductName"].ToString() ?? "",
                    Price = Convert.ToDecimal(reader["Price"]),
                    ShortDesc = reader["ShortDesc"].ToString() ?? "",
                    Category = reader["Category"].ToString() ?? "",
                    Quantity = Convert.ToInt32(reader["Quantity"])
                });
            }
            return list;
        }

        public bool SearchByCategory(string category, ref List<ProductDTO> list)
        {
            list.Clear();
            using var connection = new SqlConnection(connectionString);
            const string sql = "SELECT p.ProductID, p.ProductName, p.Price, p.ShortDesc, p.Category, s.Quantity " +
                               "FROM Products p INNER JOIN Stock s ON p.ProductID = s.ProductID " +
                               "WHERE p.Category LIKE @cat";

            using var command = new SqlCommand(sql, connection);
            command.Parameters.Add("@cat", SqlDbType.NVarChar, 50).Value = category + "%";
            connection.Open();

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ProductDTO
                {
                    ProductID = Convert.ToInt32(reader["ProductID"]),
                    ProductName = reader["ProductName"].ToString() ?? "",
                    Price = Convert.ToDecimal(reader["Price"]),
                    ShortDesc = reader["ShortDesc"].ToString() ?? "",
                    Category = reader["Category"].ToString() ?? "",
                    Quantity = Convert.ToInt32(reader["Quantity"])
                });
            }
            return list.Count > 0;
        }

        public int Insert(ProductDTO p)
        {
            using var connection = new SqlConnection(connectionString);
            // Insert into Products, then into Stock
            const string sql = @"
                INSERT INTO Products (ProductID, ProductName, Price, ShortDesc, Category) 
                VALUES (@id, @name, @price, @desc, @cat);
                INSERT INTO Stock (ProductID, Quantity) 
                VALUES (@id, @qty)";

            using var command = new SqlCommand(sql, connection);
            AddParameters(command, p);
            connection.Open();
            return command.ExecuteNonQuery();
        }

        public int Update(ProductDTO p)
        {
            using var connection = new SqlConnection(connectionString);
            const string sql = "UPDATE Products SET ProductName=@name, Price=@price, " +
                               "ShortDesc=@desc, Category=@cat WHERE ProductID = @id";

            using var command = new SqlCommand(sql, connection);
            AddParameters(command, p);
            connection.Open();
            return command.ExecuteNonQuery();
        }

        public int Delete(int id)
        {
            using var connection = new SqlConnection(connectionString);
            // Delete Stock first because of Foreign Key constraint
            const string deleteStock = "DELETE FROM Stock WHERE ProductID = @id";
            const string deleteProduct = "DELETE FROM Products WHERE ProductID = @id";

            using (var cmd1 = new SqlCommand(deleteStock, connection))
            {
                cmd1.Parameters.Add("@id", SqlDbType.Int).Value = id;
                connection.Open();
                cmd1.ExecuteNonQuery();
            }

            using (var cmd2 = new SqlCommand(deleteProduct, connection))
            {
                cmd2.Parameters.Add("@id", SqlDbType.Int).Value = id;
                return cmd2.ExecuteNonQuery();
            }
        }

        private static void AddParameters(SqlCommand command, ProductDTO p)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = p.ProductID;
            command.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = p.ProductName;
            command.Parameters.Add("@price", SqlDbType.Decimal).Value = p.Price;
            command.Parameters.Add("@desc", SqlDbType.NVarChar, 255).Value = p.ShortDesc ?? "";
            command.Parameters.Add("@cat", SqlDbType.NVarChar, 50).Value = p.Category;
            command.Parameters.Add("@qty", SqlDbType.Int).Value = p.Quantity;
        }



        public DataTable GetSalesHistory()
        {
            using var connection = new SqlConnection(connectionString);
            const string sql = @"
                SELECT b.BillID, b.SaleDate, b.TotalAmount, b.CustomerName
                FROM Billings b
                ORDER BY b.SaleDate DESC";

            using var command = new SqlCommand(sql, connection);
            using var da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int ProcessBilling(int billID, List<BillingDetailDTO> details)
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            // Start Transaction
            using var transaction = connection.BeginTransaction();

            try
            {
                // Insert Bill Header
                const string insertBill = "INSERT INTO Billings (BillID, TotalAmount) VALUES (@billID, @total)";
                using (var cmdBill = new SqlCommand(insertBill, connection, transaction))
                {
                    cmdBill.Parameters.Add("@billID", SqlDbType.Int).Value = billID;
                    cmdBill.Parameters.Add("@total", SqlDbType.Decimal).Value = details.Sum(d => d.Total);
                    cmdBill.ExecuteNonQuery();
                }

                // Insert Details and Update Stock
                const string insertDetail = @"
                    INSERT INTO BillingDetails (BillID, ProductID, QuantitySold, UnitPrice) 
                    VALUES (@billID, @prodID, @qty, @price);
                    UPDATE Stock SET Quantity = Quantity - @qty 
                    WHERE ProductID = @prodID";

                using (var cmdDetail = new SqlCommand(insertDetail, connection, transaction))
                {
                    foreach (var d in details)
                    {
                        cmdDetail.Parameters.Add("@billID", SqlDbType.Int).Value = billID;
                        cmdDetail.Parameters.Add("@prodID", SqlDbType.Int).Value = d.ProductID;
                        cmdDetail.Parameters.Add("@qty", SqlDbType.Int).Value = d.Quantity;
                        cmdDetail.Parameters.Add("@price", SqlDbType.Decimal).Value = d.UnitPrice;
                        cmdDetail.ExecuteNonQuery();
                        cmdDetail.Parameters.Clear();
                    }
                }

                transaction.Commit();
                return 1;
            }
            catch
            {
                transaction.Rollback();
                return 0;
            }
        }


    }
}

