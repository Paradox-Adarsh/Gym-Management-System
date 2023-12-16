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
    public partial class DeleteEqupimentscs : Form
    {
        public DeleteEqupimentscs()
        {
            InitializeComponent();
        }

        private void DeleteEqupimentscs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet4.equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.gymDataSet4.equipment);
            using (SqlConnection newcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\adars\OneDrive\Desktop\GymManagementSystem in C#\GymManagementSystem\Gym.mdf;Integrated Security=True;User Instance=True"))
            {
                string str1 = "SELECT * from equipment";
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

            string str = "DELETE FROM equipment WHERE eqp_id = '" + textBox1.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Equipment Deleted Successfully");

            using (SqlConnection newcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\adars\OneDrive\Desktop\GymManagementSystem in C#\GymManagementSystem\Gym.mdf;Integrated Security=True;User Instance=True"))
            {
                string str1 = "SELECT * from equipment";
                SqlCommand cmd1 = new SqlCommand(str1, newcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Equipment obj1 = new Equipment();
            obj1.ShowDialog();
        }
    }
}
