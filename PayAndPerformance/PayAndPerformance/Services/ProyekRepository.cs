using Npgsql;
using PayAndPerformance.Database;
using PayAndPerformance.Models;

namespace PayAndPerformance.Services
{
    public class ProyekRepository : BaseRepository
    {
        public ProyekRepository(PayAndPerformance.Database.DatabaseConnection databaseConnection) : base(databaseConnection)
        {
        }

        public List<Proyek> GetAllProyek()
        {
            var proyek = new List<Proyek>();

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_proyek, nama_proyek, client, budget FROM proyek ORDER BY id_proyek";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var prj = new Proyek
                                {
                                    Id = reader.GetInt32(0),
                                    Nama = reader.GetString(1),
                                    Client = reader.GetString(2),
                                    Budget = reader.GetDecimal(3)
                                };
                                proyek.Add(prj);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return proyek;
        }
    }
}
