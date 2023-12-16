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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
      

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember obj1 = new NewMember();
            obj1.ShowDialog();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchstaff obj2 = new searchstaff();
            obj2.ShowDialog();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment obj3 = new Equipment();
            obj3.ShowDialog();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMembers obj4 = new SearchMembers();
            obj4.ShowDialog();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMembers obj5 = new DeleteMembers();
            obj5.ShowDialog();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.ShowDialog();
        }
    }
}
