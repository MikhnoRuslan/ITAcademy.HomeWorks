using System;
using Microsoft.Data.SqlClient;
using Task3.Interfaces;
using Task3.Models;

namespace Task3.Repositories
{
    class MotorcycleRepositories : IMotorcycleRepositories<Motorcycle>
    {
        private const string _nameTable = Constants.NameTable;
        private const string _id = Constants.ColumnId;
        private const string _name = Constants.ColumnName;
        private const string _model = Constants.ColumnModel;
        private const string _years = Constants.ColumnYears;
        private const string _odometer = Constants.ColumnOdometer;

        private const string _dataSource = Constants.DataSource;
        private const string _catalog = Constants.InitialCatalog;
        private const string _integratedSecurity = Constants.IntegratedSecurity;

        public void Create(Motorcycle motorcycle)
        {
            var connection = new SqlConnection(GetConnectionString());

            OpenDb(connection);

            try
            {
                var cmd = new SqlCommand(GetInsertString(), connection);
                Logger.Log.Info($"Add data to the database");

                cmd.Parameters.AddWithValue($"@{_id}", motorcycle.Id);
                cmd.Parameters.AddWithValue($"@{_name}", motorcycle.Name);
                cmd.Parameters.AddWithValue($"@{_model}", motorcycle.Model);
                cmd.Parameters.AddWithValue($"@{_years}", motorcycle.Year);
                cmd.Parameters.AddWithValue($"@{_odometer}", motorcycle.Odometer);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                Console.WriteLine(e.StackTrace);
                Logger.Log.Error($"An error has occurred. Data not added.");
            }
            finally
            {
                CloseDb(connection);
                connection.Dispose();
                connection = null;
            }
        }

        public void GetMotorcycles()
        {
            var connection = new SqlConnection(GetConnectionString());
            var command = new SqlCommand(GetSelectString(), connection);

            OpenDb(connection);

            Logger.Log.Info($"Read data.");
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetString(0);
                var name = reader.GetString(1);
                var model = reader.GetString(2);
                var year = reader.GetInt32(3); 
                var odometer = reader.GetInt32(4);

                Console.WriteLine($"{id}\t{name}\t{model}\t{year}\t{odometer}");
            }

            CloseDb(connection);
        }

        public void GetMotorcycle(string idMotorcycle)
        {
            var connection = new SqlConnection(GetConnectionString());
            var command = new SqlCommand(GetMotorcycleSelectString(idMotorcycle), connection);

            OpenDb(connection);

            Logger.Log.Info($"Read data.");
            var reader = command.ExecuteReader();
            while (reader.Read())
            { 
                var id = reader.GetString(0);
                var name = reader.GetString(1);
                var model = reader.GetString(2);
                var year = reader.GetInt32(3);
                var odometer = reader.GetInt32(4);

                Console.WriteLine($"{id}\t{name}\t{model}\t{year}\t{odometer}");
            }
            
            CloseDb(connection);
        }

        public void Delete(string id)
        {
            var connection = new SqlConnection(GetConnectionString());

            OpenDb(connection);

            try
            {
                Logger.Log.Info($"Remove data.");
                var cmd = new SqlCommand(GetDeleteString(), connection);
                cmd.Parameters.AddWithValue($"@{_id}", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Logger.Log.Error($"An error has occurred. Data not deleted.");
                Console.WriteLine($"Error: {e}");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                CloseDb(connection);
                connection.Dispose();
                connection = null;
            }
        }

        private static string GetConnectionString()
        {
            return $@"Data Source={_dataSource};Initial Catalog={_catalog};Integrated Security={_integratedSecurity}";
        }

        private static string GetInsertString()
        {
            return
                $@"INSERT INTO {_nameTable} ({_id}, {_name}, {_model}, {_years}, {_odometer}) VALUES (@{_id}, @{_name}, @{_model}, @{_years}, @{_odometer})";
        }

        private static string GetSelectString()
        {
            return $@"SELECT {_id}, {_name}, {_model}, {_years}, {_odometer} FROM {_nameTable}";
        }

        private static string GetMotorcycleSelectString(string idMotorcycle)
        {
            return $@"SELECT * FROM {_nameTable} WHERE {_id} IN (SELECT {_id} FROM {_nameTable} WHERE {_id}={idMotorcycle})";
        }

        private static string GetDeleteString()
        {
            return $"DELETE {_nameTable} WHERE {_id}=@{_id}";
        }

        private void OpenDb(SqlConnection connection)
        {
            try
            {
                Logger.Log.Info($"Connecting to the database");
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Logger.Log.Error($"Failed to connect to database.");
                throw;
            }
        }

        private void CloseDb(SqlConnection connection)
        {
            Logger.Log.Info($"Close database.");
            connection.Close();
        }
    }
}
