using Npgsql;
using PayAndPerformance.Database;
using PayAndPerformance.Models;

namespace PayAndPerformance.Services
{
    public abstract class BaseRepository
    {
        protected readonly PayAndPerformance.Database.DatabaseConnection _databaseConnection;

        protected BaseRepository(PayAndPerformance.Database.DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        protected NpgsqlConnection GetConnection()
        {
            return _databaseConnection.GetConnection();
        }
    }
}
