using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace order_coffe
{
    public partial class Customer : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=seteguk;";
        private MySqlConnection databaseConn = new MySqlConnection(connectionString);
        public string id;

        public Customer()
        {
            InitializeComponent();
        }

        private void Button_pesan_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM stgk_pemesanan";

            databaseConn.Open();
            MySqlCommand cmd = new MySqlCommand(query, databaseConn);
            cmd.CommandTimeout = 60;
            MySqlDataReader r = cmd.ExecuteReader();

            if (r.HasRows)
            {
                while (r.Read())
                {
                    ListViewItem listcust = new ListViewItem(r["id_pemesanan"].ToString());
                    listcust.SubItems.Add(r["nama_pembeli"].ToString());
                    listcust.SubItems.Add(r["total_harga"].ToString());
                    listcust.SubItems.Add(r["status"].ToString());
                    listView1.Items.Add(listcust);
                }
                r.Close();
            }
            else
            {
                MessageBox.Show("Tidak ada data customer");
            }
            databaseConn.Close();
        }

        ListViewItem cust;
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM stgk_pemesanan WHERE id_pemesanan = @id";

            if (listView1.SelectedItems.Count > 0)
            {
                cust = listView1.SelectedItems[0];
                string id = cust.SubItems[0].Text;

                databaseConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MySqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        id = r["id_pemesanan"].ToString();
                        textBox1.Text = r["nama_pembeli"].ToString();
                        textBox2.Text = r["jumlah_orang"].ToString();
                    }
                    r.Close();
                }
                else
                {
                    MessageBox.Show("Tidak ada data pelanggan yang bisa dipilih");
                }
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            databaseConn.Close();
        }
    }
}
