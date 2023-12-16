using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GymManagementSystem
{
    public partial class deleteStaff : Form
    {
        public deleteStaff()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet3.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.gymDataSet3.staff);
            using (SqlConnection newcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\adars\OneDrive\Desktop\GymManagementSystem in C#\GymManagementSystem\Gym.mdf;Integrated Security=True;User Instance=True"))
            {
                string str1 = "SELECT * from staff";
                SqlCommand cmd1 = new SqlCommand(str1, newcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\adars\OneDrive\Desktop\GymManagementSystem in C#\GymManagementSystem\Gym.mdf;Integrated Security=True;User Instance=True");
            con.Open();

            string str = "DELETE FROM staff WHERE f_name = '" + textBox1.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Staff Record Deleted Successfully");

            using (SqlConnection newcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\adars\OneDrive\Desktop\GymManagementSystem in C#\GymManagementSystem\Gym.mdf;Integrated Security=True;User Instance=True"))
            {
                string str1 = "SELECT * from staff";
                SqlCommand cmd1 = new SqlCommand(str1, newcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchstaff obj1 = new searchstaff();
            obj1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchstaff obj1 = new searchstaff();
            obj1.ShowDialog();

        }
    }
}

