using System;

using System.Data;

using System.Linq;

using System.Windows.Forms;
using System.Data.SqlClient;

using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Runtime.Caching;


namespace Tampilan
{
    public partial class FormOrganisasi : Form
    {
        private string connectionString = "Data Source=DESKTOP-K2MUUDE\\ZAKYMALIKA; Initial Catalog=OrganisasiMahasiswa;Integrated Security =True";

        private int selectedIdOrganisasi = -1;
        public FormOrganisasi()
        {
            InitializeComponent();
        }

 
        private void LoadJoinedData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT
            Organisasi.ID_Organisasi,
            Organisasi.NamaOrganisasi,
            Organisasi.Deskripsi,
            Organisasi.TahunBerdiri,
            Keuangan.Jumlah,
            Keuangan.Tanggal,
            Keuangan.Keterangan
        FROM
            Organisasi
        INNER JOIN
            Keuangan ON Organisasi.ID_Organisasi = Keuangan.ID_Organisasi";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                try
                {
                    dataAdapter.Fill(dataTable);
                    dgvOrganisasi.DataSource = dataTable;

                    dgvOrganisasi.Columns["ID_Organisasi"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
        private void dgvOrganisasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrganisasi.Rows.Count > 0)
            {
                try
                {
                    var idOrganisasiCellValue = dgvOrganisasi.Rows[e.RowIndex].Cells["ID_Organisasi"].Value;
                    if (idOrganisasiCellValue != null && idOrganisasiCellValue != DBNull.Value)
                    {
                        selectedIdOrganisasi = Convert.ToInt32(idOrganisasiCellValue);

                        txtNamaOrganisasi.Text = dgvOrganisasi.Rows[e.RowIndex].Cells["NamaOrganisasi"].Value?.ToString() ?? "";
                        txtDeskripsi.Text = dgvOrganisasi.Rows[e.RowIndex].Cells["Deskripsi"].Value?.ToString() ?? "";
                        txtTahunBerdiri.Text = dgvOrganisasi.Rows[e.RowIndex].Cells["TahunBerdiri"].Value?.ToString() ?? "";

                        var jumlahValue = dgvOrganisasi.Rows[e.RowIndex].Cells["Jumlah"].Value;

                        if (jumlahValue != null && jumlahValue != DBNull.Value)
                        {
                            txtJumlahDana.Text = jumlahValue.ToString();
                        }
                        else
                        {
                            txtJumlahDana.Text = "";
                        }

                        txtKeterangan.Text = dgvOrganisasi.Rows[e.RowIndex].Cells["Keterangan"].Value?.ToString() ?? "";
                    }
                    else
                    {
                        lblMessage.Text = "ID organisasi tidak valid.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat mengambil data: " + ex.Message);
                }
            }
        }

  

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string namaOrganisasi = txtNamaOrganisasi.Text;
            string deskripsi = txtDeskripsi.Text;
            int tahunBerdiri;
            decimal jumlah;
            string keterangan = txtKeterangan.Text;

            if (string.IsNullOrEmpty(namaOrganisasi) || string.IsNullOrEmpty(deskripsi) ||
                !int.TryParse(txtTahunBerdiri.Text, out tahunBerdiri) ||
                !decimal.TryParse(txtJumlahDana.Text, out jumlah) || string.IsNullOrEmpty(keterangan))
            {
                lblMessage.Text = "Isi kolom dengan data yang sesuai";
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;

                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = conn,
                        Transaction = transaction
                    };

                    cmd.CommandText = "INSERT INTO Organisasi (NamaOrganisasi, Deskripsi, TahunBerdiri) OUTPUT INSERTED.ID_Organisasi VALUES (@NamaOrganisasi, @Deskripsi, @TahunBerdiri)";
                    cmd.Parameters.AddWithValue("@NamaOrganisasi", namaOrganisasi);
                    cmd.Parameters.AddWithValue("@Deskripsi", deskripsi);
                    cmd.Parameters.AddWithValue("@TahunBerdiri", tahunBerdiri);

                    object result = cmd.ExecuteScalar();
                    if (result == DBNull.Value)
                    {
                        //hvycv
                        lblMessage.Text = "Gagal mengambil Id Organisasi";
                        return;
                    }

                    int idOrganisasi = Convert.ToInt32(result);

                    cmd.CommandText = "INSERT INTO Keuangan (ID_Organisasi, Jenis, Jumlah, Tanggal, Keterangan) VALUES (@ID_Organisasi, 'masuk', @Jumlah, GETDATE(), @Keterangan)";
                    cmd.Parameters.AddWithValue("ID_Organisasi", idOrganisasi);
                    cmd.Parameters.AddWithValue("@Jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@Keterangan", keterangan);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    lblMessage.Text = "Data berhasil disimpan";
                    LoadJoinedData();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    lblMessage.Text = "Error: " + ex.Message;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIdOrganisasi == -1)
            {
                lblMessage.Text = "Pilih nama organisasi yang ingin diubah";
                return;
            }

            string namaOrganisasi = txtNamaOrganisasi.Text;
            string deskripsi = txtDeskripsi.Text;
            int tahunBerdiri;
            decimal jumlah;
            string keterangan = txtKeterangan.Text;

            if (string.IsNullOrEmpty(namaOrganisasi) || string.IsNullOrEmpty(deskripsi) || !int.TryParse(txtTahunBerdiri.Text, out tahunBerdiri) || !decimal.TryParse(txtJumlahDana.Text, out jumlah) || string.IsNullOrEmpty(keterangan))
            {
                lblMessage.Text = "Isi kolom dengan data yang sesuai";
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;

                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = conn,
                        Transaction = transaction
                    };

                    cmd.CommandText = "UPDATE Organisasi SET NamaOrganisasi = @NamaOrganisasi, Deskripsi = @Deskripsi, TahunBerdiri = @TahunBerdiri WHERE ID_Organisasi = @ID_Organisasi";
                    cmd.Parameters.AddWithValue("@NamaOrganisasi", namaOrganisasi);
                    cmd.Parameters.AddWithValue("@Deskripsi", deskripsi);
                    cmd.Parameters.AddWithValue("@TahunBerdiri", tahunBerdiri);
                    cmd.Parameters.AddWithValue("@ID_Organisasi", selectedIdOrganisasi);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE Keuangan SET Jumlah = @Jumlah, Keterangan = @Keterangan WHERE ID_Organisasi = @ID_Organisasi";
                    cmd.Parameters.AddWithValue("@Jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@Keterangan", keterangan);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    lblMessage.Text = "Data berhasil diubah.";
                    LoadJoinedData();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    lblMessage.Text = "Error: " + ex.Message;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIdOrganisasi == -1)
            {
                lblMessage.Text = "Pilih nama organisasi yang ingin dihapus";
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;

                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = conn,
                        Transaction = transaction
                    };

                    cmd.CommandText = "DELETE FROM Keuangan WHERE ID_Organisasi = @ID_Organisasi";
                    cmd.Parameters.AddWithValue("@ID_Organisasi", selectedIdOrganisasi);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM Organisasi WHERE ID_Organisasi = @ID_Organisasi";
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    lblMessage.Text = "Data berhasil dihapus.";
                    LoadJoinedData();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    lblMessage.Text = "Error: " + ex.Message;
                }
            }
        }
        private void FormOrganisasi_Load(object sender, EventArgs e)
        {
            LoadJoinedData();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
