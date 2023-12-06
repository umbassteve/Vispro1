using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project_Vispro
{
    public partial class Form5 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        MySqlCommand command;
        DataTable table;
        MySqlDataReader mdr;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form5()
        {
            alamat = "server=localhost; database=db_infokost; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }
        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM tbl_data WHERE CONCAT(`Id`, `Nama`, `Alamat`, `Harga`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, koneksi);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text.ToString();
            searchData(valueToSearch);
        }

        private void BTN_BACK_Click(object sender, EventArgs e)
        {
            Form1 form5 = new Form1();
            form5.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BTN_DISPLAYS_Click(object sender, EventArgs e)
        {
            koneksi.Open();

            string selectQuery = "SELECT * FROM db_infokost.tbl_data WHERE Id=" + int.Parse(textBoxID.Text);
            command = new MySqlCommand(selectQuery, koneksi);

            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                textBoxNamaKost.Text = mdr.GetString("Nama");
                textBoxAlamat.Text = mdr.GetString("Alamat");
                textBoxHarga.Text = mdr.GetInt32("Harga").ToString();
                textBoxJenisKost.Text = mdr.GetString("JenisKost");
            }
            else
            {
                MessageBox.Show("No Data For This Id");
            }
            koneksi.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from tbl_data");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Nama";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Alamat";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Harga";

                searchData("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
