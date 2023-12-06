using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project_Vispro
{
    public partial class Form4 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        MySqlCommand command;
        DataTable table;
        MySqlDataReader mdr;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form4()
        {
            alamat = "server=localhost; database=db_infokost; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO db_infokost.tbl_data(Id,Nama,Alamat,Harga,JenisKost) VALUES('" + textBoxID.Text + "', '" + textBoxNamaKost.Text + "', '" + textBoxAlamat.Text + "', '" + textBoxHarga.Text + "', '" + textBoxJenisKost.Text + "')";
            koneksi.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, koneksi);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            koneksi.Close();
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE db_infokost.tbl_data SET Nama = '"+textBoxNamaKost.Text+"', Alamat = '"+textBoxAlamat.Text+"', JenisKost = '"+textBoxJenisKost.Text+"', Harga = "+int.Parse(textBoxHarga.Text)+" WHERE id="+int.Parse(textBoxID.Text);

            koneksi.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(updateQuery, koneksi);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Data Not Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            koneksi.Close();
        }

        private void BTN_DELETED_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM db_infokost.tbl_data WHERE Id =" + textBoxID.Text;
                koneksi.Open();
                MySqlCommand command = new MySqlCommand(deleteQuery, koneksi);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Admin Deleted");
                }
                else
                {
                    MessageBox.Show("Admin Not Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            koneksi.Close();
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

        private void BTN_BACK_Click(object sender, EventArgs e)
        {
            Form1 form4 = new Form1();
            form4.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
