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
    public partial class CheckOut : Form
    {
        // Prepare the connection
        private static string connectionString = "server=localhost;port=3306;username=root;password='';database=seteguk;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public CheckOut()
        {
            InitializeComponent();
        }


        private void CheckOut_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM `stgk_sementara` INNER JOIN stgk_pemesanan ON stgk_sementara.id_pembeli = stgk_pemesanan.id_pemesanan INNER JOIN stgk_menu ON stgk_menu.id_menu = stgk_sementara.id_menu WHERE id_pembeli = 4;";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["nama_menu"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listViewItem.SubItems.Add(reader["total_pesan"].ToString());
                        listView1.Items.Add(listViewItem);
                        text_pembeli.Text = reader["nama_pembeli"].ToString();
                        text_no.Text = reader["id_pemesanan"].ToString();
                        count();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                // Show any error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public void count()
        {
            decimal total = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                total += decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(total);
        }

        private void Button_update_Click(object sender, EventArgs e)
        {

            string query = "UPDATE stgk_sementara SET jumlah = @jumlah, total_pesan = @total_pesan WHERE id_pembeli = @id_pembeli && id = @id";
            Double h, j, total;
            h = Convert.ToDouble(text_harga.Text);
            j = Convert.ToDouble(text_jumlah.Text);
            total = h * j;
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id_pembeli", text_no.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.Parameters.AddWithValue("@id", id_menu.Text);
                cmd.Parameters.AddWithValue("@total_pesan", total.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void Button_refresh_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            string query = "SELECT * FROM `stgk_sementara` INNER JOIN stgk_pemesanan ON stgk_sementara.id_pembeli = stgk_pemesanan.id_pemesanan INNER JOIN stgk_menu ON stgk_menu.id_menu = stgk_sementara.id_menu WHERE id_pembeli = 4;";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                // IMPORTANT :
                // If your query returns result, use the following processor :
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["nama_menu"].ToString());
                        listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listViewItem.SubItems.Add(reader["total_pesan"].ToString());
                        listView1.Items.Add(listViewItem);
                        text_no.Text = reader["id_pemesanan"].ToString();
                        text_pembeli.Text = reader["nama_pembeli"].ToString();
                        text_harga.Text = reader["total_harga"].ToString();
                        count();
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No rows found.");
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM stgk_sementara WHERE id = @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", id_menu.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                // Show any error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        ListViewItem lv1;
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "SELECT * FROM `stgk_sementara` INNER JOIN stgk_pemesanan ON stgk_sementara.id_pembeli = stgk_pemesanan.id_pemesanan INNER JOIN stgk_menu ON stgk_menu.id_menu = stgk_sementara.id_menu WHERE nama_menu = @menu";

            if (listView1.SelectedItems.Count > 0)
            {
                lv1 = listView1.SelectedItems[0];
                text_menu.Text = lv1.SubItems[0].Text;

                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@menu", text_menu.Text);
                cmd.ExecuteNonQuery();
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        text_menu.Text = r["nama_menu"].ToString();
                        text_jumlah.Text = r["jumlah"].ToString();
                        text_harga.Text = r["harga"].ToString();
                        id_menu.Text = r["id"].ToString();
                    }
                    r.Close();
                }
                else
                {
                    MessageBox.Show("Tidak ada yang dipilih");
                }
            }
            else
            {
                text_menu.Text = "";
                text_jumlah.Text = "";
                text_harga.Text = "";
            }
            databaseConnection.Close();
        }
    }
}
