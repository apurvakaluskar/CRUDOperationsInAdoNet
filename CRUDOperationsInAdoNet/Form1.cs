using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDOperationsInMoviesDatabase
{
    public partial class Form1 : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["moviesDB"].ConnectionString);
        public int recordId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtName.Text = "";
            txtReleaseYear.Text = "";
            txtGenre.Text = "";
            txtRating.Text = "";
            btnSave.Text = "Save";
        }

        private void PopulateMoviesTable()
        {
            string command = "SELECT * FROM Movie";
            SqlCommand cmd = new SqlCommand(command, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvMovies.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int releaseYear = Convert.ToInt32(txtReleaseYear.Text);
            string genre = txtGenre.Text;
            decimal rating = Convert.ToDecimal(txtRating.Text);

            string command = string.Format("INSERT INTO Movie VALUES ('{0}', {1}, '{2}', {3})", name, releaseYear, genre, rating);
            SqlCommand cmd = new SqlCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            PopulateMoviesTable();
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateMoviesTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int releaseYear = Convert.ToInt32(txtReleaseYear.Text);
            string genre = txtGenre.Text;
            decimal rating = Convert.ToDecimal(txtRating.Text);

            string command = string.Format("UPDATE Movie SET Name = '{0}', ReleaseYear = {1}, Genre = '{2}', Rating = {3} WHERE Id = {4}", name, releaseYear, genre, rating, recordId);
            SqlCommand cmd = new SqlCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            PopulateMoviesTable();
            Clear();
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMovies_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow.Index != -1)
            {
                recordId = Convert.ToInt32(dgvMovies.CurrentRow.Cells["Id"].Value);
                string command = string.Format("SELECT * FROM Movie WHERE Id = {0}", recordId);
                SqlCommand cmd = new SqlCommand(command, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtName.Text = dt.Rows[0].ItemArray[1].ToString();
                txtReleaseYear.Text = dt.Rows[0].ItemArray[2].ToString();
                txtGenre.Text = dt.Rows[0].ItemArray[3].ToString();
                txtRating.Text = dt.Rows[0].ItemArray[4].ToString();
            }
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            string command = string.Format("DELETE FROM Movie WHERE Id = {0}", recordId);
            SqlCommand cmd = new SqlCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            PopulateMoviesTable();
            Clear();
        }
    }
}
