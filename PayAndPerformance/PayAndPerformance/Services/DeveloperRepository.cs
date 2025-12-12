using Npgsql;
using PayAndPerformance.Database;
using PayAndPerformance.Models;

namespace PayAndPerformance.Services
{
    public class DeveloperRepository : BaseRepository
    {
        public DeveloperRepository(PayAndPerformance.Database.DatabaseConnection databaseConnection) : base(databaseConnection)
        {
        }

        public List<Developer> GetAllDevelopers()
        {
            var developers = new List<Developer>();

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT d.id_dev, d.nama_dev, d.status_kontrak, d.fitur_selesai, d.jumlah_bug, d.id_proyek, p.nama_proyek FROM developer d LEFT JOIN proyek p ON d.id_proyek = p.id_proyek ORDER BY d.id_dev";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var developer = new Developer
                                {
                                    Id = reader.GetInt32(0),
                                    Nama = reader.GetString(1),
                                    StatusKontrak = reader.GetString(2),
                                    FiturSelesai = reader.GetInt32(3),
                                    JumlahBug = reader.GetInt32(4),
                                    IdProyek = reader.GetInt32(5),
                                    NamaProyek = reader.IsDBNull(6) ? string.Empty : reader.GetString(6)
                                };
                                developers.Add(developer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return developers;
        }

        public void InsertDeveloper(Developer developer)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO developer (nama_dev, status_kontrak, fitur_selesai, jumlah_bug, id_proyek) VALUES (@nama, @status, @fitur, @bug, @idProyek) RETURNING id_dev";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", developer.Nama);
                        cmd.Parameters.AddWithValue("@status", developer.StatusKontrak);
                        cmd.Parameters.AddWithValue("@fitur", developer.FiturSelesai);
                        cmd.Parameters.AddWithValue("@bug", developer.JumlahBug);
                        cmd.Parameters.AddWithValue("@idProyek", developer.IdProyek);

                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            developer.Id = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDeveloper(Developer developer)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE developer SET nama_dev = @nama, status_kontrak = @status, fitur_selesai = @fitur, jumlah_bug = @bug, id_proyek = @idProyek WHERE id_dev = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", developer.Id);
                        cmd.Parameters.AddWithValue("@nama", developer.Nama);
                        cmd.Parameters.AddWithValue("@status", developer.StatusKontrak);
                        cmd.Parameters.AddWithValue("@fitur", developer.FiturSelesai);
                        cmd.Parameters.AddWithValue("@bug", developer.JumlahBug);
                        cmd.Parameters.AddWithValue("@idProyek", developer.IdProyek);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteDeveloper(int developerId)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM developer WHERE id_dev = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", developerId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Developer? GetDeveloperById(int developerId)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_dev, nama_dev, status_kontrak, fitur_selesai, jumlah_bug, id_proyek FROM developer WHERE id_dev = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", developerId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Developer
                                {
                                    Id = reader.GetInt32(0),
                                    Nama = reader.GetString(1),
                                    StatusKontrak = reader.GetString(2),
                                    FiturSelesai = reader.GetInt32(3),
                                    JumlahBug = reader.GetInt32(4),
                                    IdProyek = reader.GetInt32(5)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
