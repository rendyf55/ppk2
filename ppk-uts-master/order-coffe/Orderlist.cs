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
    public partial class Orderlist : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=seteguk;";
        private MySqlConnection databaseConn = new MySqlConnection(connectionString);

        public Orderlist()
        {
            InitializeComponent();
        }

        public void getPemesanan()
        {
            string query = "SELECT * FROM stgk_pemesanan INNER JOIN stgk_menu ON stgk_pemesanan.id_menu = stgk_menu.id_menu";
            try
            {
                //koneksi dibuka
                databaseConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConn);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listpemesanan = new ListViewItem(reader["id_pemesanan"].ToString());
                        listpemesanan.SubItems.Add(reader["nama_pembeli"].ToString());
                        listpemesanan.SubItems.Add(reader["status"].ToString());
                        listView_order.Items.Add(listpemesanan);
                    }
                }
                else
                {
                    MessageBox.Show("Tidak Ada data");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //tutup koneksi
                databaseConn.Close();
            }
        }

        private void Orderlist_Load(object sender, EventArgs e)
        {
            getPemesanan();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            listView_order.Items.Clear();
            string query = "UPDATE stgk_pemesanan SET status = 'selesai' where id_pemesanan = @id";
            try
            {
                //Open koneksi database
                databaseConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pemesanan telah selesai");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //tutup databasenya
                databaseConn.Close();
                getPemesanan();
            }
        }

        ListViewItem order;
        private void ListView_order_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "SELECT * FROM `stgk_sementara` INNER JOIN stgk_pemesanan ON stgk_sementara.id_pembeli = stgk_pemesanan.id_pemesanan INNER JOIN stgk_menu ON stgk_menu.id_menu = stgk_sementara.id_menu WHERE id_pembeli = @id_pemesanan";

            if (listView_order.SelectedItems.Count > 0)
            {
                order = listView_order.SelectedItems[0];
                text_id.Text = order.SubItems[0].Text;

                //koneksi dibuka
                databaseConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id_pemesanan", text_id.Text);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem orderlist = new ListViewItem(reader["nama_menu"].ToString());
                        orderlist.SubItems.Add(reader["jumlah"].ToString());
                        orderdetail.Items.Add(orderlist);
                        text_nama.Text = reader["nama_pembeli"].ToString();
                        text_total.Text = reader["total_harga"].ToString();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Tidak Order Detail");
                }
            }
            else
            {
                orderdetail.Items.Clear();
                text_id.Text = "";
                text_nama.Text = "";
                text_total.Text = "";
            }
            databaseConn.Close();
        }
    }
}
