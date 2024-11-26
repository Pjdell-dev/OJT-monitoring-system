using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT_MT
{
    public class DatabaseHelper : IDisposable
    {
        private string _connectionString;
        private MySqlConnection? _connection;
        public DatabaseHelper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; //nasa app.config yung database connection string para madali magpalit
        }

        internal async Task<MySqlConnection> GetConnectionAsync()
        {
            if (_connection == null)
                _connection = new MySqlConnection(_connectionString);

            if (_connection.State != ConnectionState.Open)
                await _connection.OpenAsync();

            return _connection;
        }


        public async Task<MySqlDataReader> ExecuteReaderAsync(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using var cmd = new MySqlCommand(query, await GetConnectionAsync());
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing reader query", ex);
            }
        }


        //For insert/update/delete
        public async Task<int> ExecuteNonQueryAsync(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using var cmd = new MySqlCommand(query, await GetConnectionAsync());
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return await cmd.ExecuteNonQueryAsync();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing non-query", ex);
            }
        }

        //For getting a scalar value
        public async Task<object> ExecuteScalarAsync(string query, params MySqlParameter[] parameters)
        {
            try
            {
                using var cmd = new MySqlCommand(query, await GetConnectionAsync());
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                    
                return await cmd.ExecuteScalarAsync();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing scalar query", ex);
            }
        }

        public async Task<bool> IsPasswordCorrectAsync(string userID, string password)
        {

            string query = "SELECT user_password FROM users WHERE user_id = @userID"; // Replace 'user_password' with your actual column name
            var result = await ExecuteScalarAsync(query, new MySqlParameter("@userID", userID));

            //Check if the result is null (user not found) or compare passwords
            return result != null && Convert.ToString(result) == password;
        }


        public async Task InsertDataAsync(string[] queries, params MySqlParameter[][] parameters)
        {
            if (queries.Length != parameters.Length)
            {
                throw new ArgumentException("The number of queries must match the number of parameter arrays");
            }

            await using var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();

            await using var transaction = await connection.BeginTransactionAsync();
            for (int i = 0; i < queries.Length; i++)
            {
                using var command = CreateCommand(queries[i], parameters[i], connection, transaction);
                await command.ExecuteNonQueryAsync();
            }

            await transaction.CommitAsync();
            try
            {
                
            }
            catch (MySqlException ex)
            {
                await transaction.RollbackAsync();
                throw new Exception("Error inserting data", ex);
            }
        }

        private MySqlCommand CreateCommand(string query, MySqlParameter[] parameters, MySqlConnection connection, MySqlTransaction transaction)
        {
            var command = new MySqlCommand(query, connection, transaction);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            return command;
        }







        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }
    }
}
