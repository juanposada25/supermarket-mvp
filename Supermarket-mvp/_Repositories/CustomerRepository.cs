using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customer VALUES (@first_Name, @last_Name, @document, @address, @birthday, @phone, @email)";
                command.Parameters.Add("@first_Name", SqlDbType.NVarChar).Value = customerModel.First_Name;
                command.Parameters.Add("@last_Name", SqlDbType.NVarChar).Value = customerModel.Last_Name;
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customerModel.Document;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.Date).Value = customerModel.Birthday;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = customerModel.Phone;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Customer WHERE Customer_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customer SET Customer_First_Name = @first_Name,
                                        Customer_Last_Name = @last_Name,
                                        Customer_Document = @document,
                                        Customer_Address = @address,
                                        Customer_Birthday = @birthday,
                                        Customer_Phone = @phone,
                                        Customer_Email = @email
                                        WHERE Customer_Id = @Id";
                command.Parameters.Add("@first_Name", SqlDbType.NVarChar).Value = customerModel.First_Name;
                command.Parameters.Add("@last_Name", SqlDbType.NVarChar).Value = customerModel.Last_Name;
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customerModel.Document;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@birthday", SqlDbType.Date).Value = customerModel.Birthday;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = customerModel.Phone;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            var customerList = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customer ORDER BY Customer_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Id = (int)reader["Customer_Id"];
                        customerModel.First_Name = reader["Customer_First_Name"].ToString();
                        customerModel.Last_Name = reader["Customer_Last_Name"].ToString();
                        customerModel.Document = reader["Customer_Document"].ToString();
                        customerModel.Address = reader["Customer_Address"].ToString();
                        customerModel.Birthday = (DateTime)reader["Customer_Birthday"];
                        customerModel.Phone = reader["Customer_Phone"].ToString();
                        customerModel.Email = reader["Customer_Email"].ToString();
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }

        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            var customerList = new List<CustomerModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customerFirst_Name = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customer WHERE Customer_Id=@id or Customer_First_Name LIKE @name+ '%'
                                      ORDER by Customer_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@first_Name", SqlDbType.NVarChar).Value = customerFirst_Name;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Id = (int)reader["Customer_Id"];
                        customerModel.First_Name = reader["Customer_First_Name"].ToString();
                        customerModel.Last_Name = reader["Customer_Last_Name"].ToString();
                        customerModel.Document = reader["Customer_Document"].ToString();
                        customerModel.Address = reader["Customer_Address"].ToString();
                        customerModel.Birthday = (DateTime)reader["Customer_Birthday"];
                        customerModel.Phone = reader["Customer_Phone"].ToString();
                        customerModel.Email = reader["Customer_Email"].ToString();
                        customerList.Add(customerModel);
                    }
                }
            }

            return customerList;
        }
    }
}
