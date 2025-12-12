using PayAndPerformance.Database;
using PayAndPerformance.Models;
using PayAndPerformance.Services;

namespace PayAndPerformance
{
    public partial class Form1 : Form
    {
        private DatabaseConnection? _databaseConnection;
        private DataService? _dataService;
        private int? _selectedDeveloperId;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitializeDatabase();
            LoadDropdowns();
            LoadDeveloperGrid();
            WireUpEventHandlers();
        }

        private void InitializeDatabase()
        {
            _databaseConnection = new DatabaseConnection(
                host: "localhost",
                database: "PayAndPerformance",
                username: "postgres",
                password: "informatika",
                port: 5432
            );

            if (_databaseConnection.TestConnection())
            {
                _dataService = new DataService(_databaseConnection);
            }
            else
            {
                MessageBox.Show("Gagal terhubung ke database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDropdowns()
        {
            if (_dataService == null) return;

            _dataService.LoadDropdownProyek(ddProyek);
            
            var statusList = new List<string> { "Kontrak", "Full Time", "Part Time", "Freelance" };
            ddStatusKontrak.DataSource = statusList;
        }

        private void LoadDeveloperGrid()
        {
            if (_dataService == null) return;

            _dataService.LoadDeveloperGrid(gridPerformaTim);
        }

        private void WireUpEventHandlers()
        {
            btnInsert.Click += BtnInsert_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            gridPerformaTim.CellClick += GridPerformaTim_CellClick;
        }

        private void BtnInsert_Click(object? sender, EventArgs e)
        {
            if (_dataService == null) return;

            if (!ValidateInput())
            {
                MessageBox.Show("Mohon isi semua field!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var developer = new Developer
            {
                Nama = txtNamaDeveloper.Text,
                IdProyek = (int)ddProyek.SelectedValue,
                StatusKontrak = ddStatusKontrak.SelectedValue?.ToString() ?? "",
                FiturSelesai = int.Parse(txtFiturSelesai.Text),
                JumlahBug = int.Parse(txtJumlahBug.Text)
            };

            _dataService.InsertDeveloper(developer);

            ClearInputs();
            LoadDeveloperGrid();
            MessageBox.Show("Data berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (_dataService == null) return;

            if (_selectedDeveloperId == null)
            {
                MessageBox.Show("Pilih developer yang akan diupdate!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
            {
                MessageBox.Show("Mohon isi semua field!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var developer = new Developer
            {
                Id = _selectedDeveloperId.Value,
                Nama = txtNamaDeveloper.Text,
                IdProyek = (int)ddProyek.SelectedValue,
                StatusKontrak = ddStatusKontrak.SelectedValue?.ToString() ?? "",
                FiturSelesai = int.Parse(txtFiturSelesai.Text),
                JumlahBug = int.Parse(txtJumlahBug.Text)
            };

            _dataService.UpdateDeveloper(developer);

            ClearInputs();
            LoadDeveloperGrid();
            MessageBox.Show("Data berhasil diupdate!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (_dataService == null) return;

            if (_selectedDeveloperId == null)
            {
                MessageBox.Show("Pilih developer yang akan dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _dataService.DeleteDeveloper(_selectedDeveloperId.Value);

                ClearInputs();
                LoadDeveloperGrid();
                MessageBox.Show("Data berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GridPerformaTim_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (_dataService == null) return;

            var row = gridPerformaTim.Rows[e.RowIndex];

            _selectedDeveloperId = (int?)row.Cells["Id"].Value;

            if (_selectedDeveloperId != null)
            {
                var developer = _dataService.GetDeveloperById(_selectedDeveloperId.Value);
                if (developer != null)
                {
                    txtNamaDeveloper.Text = developer.Nama;
                    ddProyek.SelectedValue = developer.IdProyek;
                    ddStatusKontrak.SelectedItem = developer.StatusKontrak;
                    txtFiturSelesai.Text = developer.FiturSelesai.ToString();
                    txtJumlahBug.Text = developer.JumlahBug.ToString();
                }
            }
        }

        private void ClearInputs()
        {
            txtNamaDeveloper.Clear();
            txtFiturSelesai.Clear();
            txtJumlahBug.Clear();
            ddProyek.SelectedIndex = 0;
            ddStatusKontrak.SelectedIndex = 0;
            _selectedDeveloperId = null;
        }

        private bool ValidateInput()
        {
            return !string.IsNullOrWhiteSpace(txtNamaDeveloper.Text) &&
                   ddProyek.SelectedValue != null &&
                   ddStatusKontrak.SelectedValue != null &&
                   !string.IsNullOrWhiteSpace(txtFiturSelesai.Text) &&
                   !string.IsNullOrWhiteSpace(txtJumlahBug.Text) &&
                   int.TryParse(txtFiturSelesai.Text, out _) &&
                   int.TryParse(txtJumlahBug.Text, out _);
        }

        private void txtNamaDeveloper_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
