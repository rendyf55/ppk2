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
    public partial class Form1 : Form
    {
        private static string connectionString = "server=localhost;port=3307;username=root;password='';database=seteguk;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ListViewItem lv1;
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM stgk_menu"; 

            if (listView1.SelectedItems.Count > 0)
            {
                lv1 = listView1.SelectedItems[0];
                
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id_menu", listView2.SelectedItems);
                cmd.ExecuteNonQuery();
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        ListViewItem listViewItem2 = new ListViewItem(r["id_menu"].ToString());
                        listViewItem2.SubItems.Add(r["nama_menu"].ToString());
                        listViewItem2.SubItems.Add(r["harga"].ToString());
                        listView2.Items.Add(listViewItem2);


                    }
                    r.Close();
                }
                else
                {
                    MessageBox.Show("Tidak ada yang dipilih");
                }
            
         
                databaseConnection.Close();
            }
        }
    

                private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO STGK_MENU (id_menu, nama_menu, harga) VALUES (@id_menu, @nama_menu, @harga)";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id_menu", text_id.Text);
                cmd.Parameters.AddWithValue("@nama_menu", text_menu.Text);
                cmd.Parameters.AddWithValue("@harga", text_harga.Text);              
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
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

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            string query = "SELECT * FROM stgk_menu";

            try
            {                 // Open the database
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
                        ListViewItem listViewItem = new ListViewItem(reader["id_menu"].ToString());
                        listViewItem.SubItems.Add(reader["nama_menu"].ToString());
                        listViewItem.SubItems.Add(reader["harga"].ToString());

                        listView1.Items.Add(listViewItem);

                    }

                    reader.Close();
                }
                else { MessageBox.Show("No rows found."); }

            }

            catch (Exception ex)
            {                 // Show any error message.          
                MessageBox.Show(ex.Message);
            } 


            finally { databaseConnection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM stgk_menu WHERE id_menu = @id_menu";

            try
            {

                // Open the database   
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id_menu", text_id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            } 

            catch (Exception ex)
            {                     // Show any error message.     
                MessageBox.Show(ex.Message);                 } 


                finally { databaseConnection.Close(); }

        }
    }
}
