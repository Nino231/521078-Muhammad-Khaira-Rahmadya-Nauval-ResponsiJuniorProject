using Npgsql;
using PayAndPerformance.Database;
using PayAndPerformance.Models;

namespace PayAndPerformance.Services
{
    public class StatusKontrakRepository : BaseRepository
    {
        public StatusKontrakRepository(PayAndPerformance.Database.DatabaseConnection databaseConnection) : base(databaseConnection)
        {
        }

        public List<StatusKontrak> GetAllStatusKontrak()
        {
            var statusList = new List<StatusKontrak>();

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id, nama FROM status_kontrak ORDER BY id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var status = new StatusKontrak
                                {
                                    Id = reader.GetInt32(0),
                                    Nama = reader.GetString(1)
                                };
                                statusList.Add(status);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return statusList;
        }
    }
}
