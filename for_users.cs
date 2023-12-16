using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class for_users : Form
    {
        public for_users()
        {
            InitializeComponent();
        }

        private void for_users_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            workout obj1 = new workout();
            obj1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            exercise obj1 = new exercise();
            obj1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            bmi_cal obj1 = new bmi_cal();
            obj1.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            userlogcs obj = new userlogcs();
            obj.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserEquipment obj = new UserEquipment();
            obj.ShowDialog();
        }
    }
}
