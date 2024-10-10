﻿using System;
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
    internal class CategorieRepository : BaseRepository, ICategorieRepository
    {
        public CategorieRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CategorieModel categorieModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categorie VALUES (@name, @description)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = categorieModel.Description;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        command.Connection = connection;
                        command.Transaction = transaction;
                        command.CommandText = "DELETE FROM Product WHERE  Product_Categorie_Id = @id";
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        command.ExecuteNonQuery();

                        command.CommandText = "DELETE FROM Categorie WHERE Categorie_Id = @id";
                        command.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Edit(CategorieModel categorieModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categorie SET Categorie_Name = @name,
                                        Categorie_Description = @description
                                        WHERE Categorie_Id = @Id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieModel.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = categorieModel.Description;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieModel.Id;
                command.ExecuteNonQuery();

            }
        }

        public IEnumerable<CategorieModel> GetAll()
        {
            var categoriesList = new List<CategorieModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categorie ORDER BY Categorie_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategorieModel();
                        categorieModel.Id = (int)reader["Categorie_Id"];
                        categorieModel.Name = reader["Categorie_Name"].ToString();
                        categorieModel.Description = reader["Categorie_Description"].ToString();
                        categoriesList.Add(categorieModel);
                    }
                }
            }
            return categoriesList;
        }

        public IEnumerable<CategorieModel> GetByValue(string value)
        {
            var categoriesList = new List<CategorieModel>();
            int categorieId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categorieName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categorie WHERE Categorie_Id=@id or Categorie_Name LIKE @name+ '%'
                                      ORDER by Categorie_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategorieModel();
                        categorieModel.Id = (int)reader["Categorie_Id"];
                        categorieModel.Name = reader["Categorie_Name"].ToString();
                        categorieModel.Description = reader["Categorie_Description"].ToString();
                        categoriesList.Add(categorieModel);
                    }
                }
            }

            return categoriesList;
        }
    }
}
