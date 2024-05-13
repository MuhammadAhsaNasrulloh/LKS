using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS
{
    public partial class Kasir_Form : Form
    {
        public Kasir_Form()
        {
            InitializeComponent();
        }
        Function func = new Function();
        string newIdTransaksi = "TRS001";
        string kode = "";
        string nama = "";
        string kodeTransaksi = "";

        void getBarang()
        {
            try
            {
                if (func.conn.State == ConnectionState.Closed) func.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT kode_barang, nama_barang FROM tbl_barang", func.conn);
                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    kode = read["kode_barang"].ToString();
                    nama = read["nama_barang"].ToString();
                    cbKode.Items.Add(kode + '-' + nama);
                }
                read.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                func.conn.Close();
            }
        }

        string getHarga()
        {
            try
            {
                if (func.conn.State == ConnectionState.Closed) func.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT harga_satuan FROM tbl_barang WHERE kode_barang like '" + cbKode.Text.Split('-')[0].Trim() + "'", func.conn);
                SqlDataReader read = cmd.ExecuteReader();
                string harga_satuan = "";

                if (read.Read())
                {
                    harga_satuan = read["harga_satuan"].ToString();
                }

                func.conn.Close();
                read.Close();

                return harga_satuan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            finally { func.conn.Close(); }
        }

        string GetLastId()
        {
            try
            {
                if (func.conn.State == ConnectionState.Closed) func.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 id_transaksi FROM tbl_transaksi ORDER BY tgl_transaksi DESC", func.conn);
                SqlDataReader read = cmd.ExecuteReader();
                string lastId = "";
                string newId = "";

                if (read.Read())
                {
                    lastId = read["id_transaksi"].ToString();
                    if(!string.IsNullOrEmpty(lastId) && lastId.Length > 3)
                    {
                        int urut = int.Parse(lastId.Substring(3)) + 1;
                        newId = "TRS" + urut.ToString("D3");    
                    }
                }
                read.Close();
                return newId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            finally
            {
                func.conn.Close();
            }
        }

        double totalPrice()
        {
            double total = 0;
            foreach(DataGridViewRow dr in dataGridView1.Rows)
            {
                total += Convert.ToDouble(dr.Cells[4].Value); 
            }
            return total;
        }

        private void Kasir_Form_Load(object sender, EventArgs e)
        {
            getBarang();
            kodeTransaksi = DateTime.Now.ToString("yyyyMMddHHmmss");
            newIdTransaksi = GetLastId();
        }

        private void cbKode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHarga.Text = getHarga();
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            double a;
            double b;

            Double.TryParse(txtHarga.Text, out a);
            Double.TryParse(txtJumlah.Text, out b);
            
            double total = a * b;
            txtTotal.Text = total.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            func.conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_log(waktu, aktivitas, id_user) VALUES (GETDATE(), 'Logout', @idUser)", func.conn);
            cmd.Parameters.AddWithValue("@idUser", Function.id_user);
            cmd.ExecuteNonQuery();

            new Login_Form().Show();
            this.Hide();

            func.conn.Close();
        }

        private void addDataGrid(string kode, string nama, double harga, int jumlah, double total )
        {
            dataGridView1.Rows.Add(kode, nama, harga, jumlah, total);
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            addDataGrid(cbKode.Text.Split('-')[0].Trim(), cbKode.Text.Split('-')[1].Trim(), Double.Parse(txtHarga.Text), int.Parse(txtJumlah.Text), Double.Parse(txtTotal.Text));
            lbTotal.Text = totalPrice().ToString();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtBayar.Text);
            int b = Convert.ToInt32(lbTotal.Text);

            if(a < b)
            {
                MessageBox.Show("Uang anda Kurang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int kembalian = a - b;
                lbChange.Text = kembalian.ToString();
            }
        }

        private void btnSve_Click(object sender, EventArgs e)
        {
            if (func.conn.State == ConnectionState.Closed) func.conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_transaksi(id_transaksi, no_transaksi, tgl_transaksi, id_kasir, total_bayar) VALUES ('" + newIdTransaksi + "', '" + kodeTransaksi + "', GETDATE(), @idKasir, '" + txtBayar.Text + "')", func.conn);
            cmd.Parameters.AddWithValue("@idKasir", Function.id_user);
            cmd.ExecuteNonQuery();

            Console.WriteLine(newIdTransaksi);

            func.conn.Close();
        }
    }
}
