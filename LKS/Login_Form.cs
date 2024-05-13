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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        Function func = new Function();
        void login()
        {
            try
            {
                if (func.conn.State == ConnectionState.Closed) func.conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id_user, tipe_user, nama FROM tbl_user WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPw.Text + "'", func.conn);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        Function.id_user = dr["id_user"].ToString();
                        Function.tipe_user = dr["tipe_user"].ToString();
                        Function.nama = dr["nama"].ToString();

                        SqlCommand cmd = new SqlCommand("INSERT INTO tbl_log(waktu, aktivitas, id_user) VALUES (GETDATE(), 'Login', @idUser)", func.conn);
                        cmd.Parameters.AddWithValue("@idUser", Function.id_user);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Login Berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr["tipe_user"].ToString() == "Admin")
                        {

                        }else if (dr["tipe_user"].ToString() == "Gudang")
                        {
                           
                        }else if (dr["tipe_user"].ToString() == "Kasir")
                        {
                            new Kasir_Form().Show();
                            this.Hide();
                        }
                    }
                }
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
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPw.Text = string.Empty;
        }

        private void cbPw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPw.Checked)
            {
                txtPw.PasswordChar = '\0';
            }
            else
            {
                txtPw.PasswordChar = '*';
            }
        }
    }
}
