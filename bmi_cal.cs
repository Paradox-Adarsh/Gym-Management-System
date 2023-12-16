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
    public partial class bmi_cal : Form
    {
        public bmi_cal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight;
            int height;
            int bmi;
            weight = int.Parse(textBox1.Text);
            height = int.Parse(textBox2.Text);
            bmi = (weight * 703) / (height * height);
                if(bmi<18.5)
                {
                    MessageBox.Show("You are under-weight");
                    label4.Text = "Breakfast – Unsweetened milk/ tea/ coffee or aloe vera juice + toast or eggs/porridge/ oatmeal.";
                    label5.Text = "Lunch – salad + whole wheat roti + vegetables + brown rice + dal.";
                    label6.Text = "Dinner – whole wheat roti / soup + salad / rice + dal.";

                }
              
                if (bmi > 18.5 && bmi < 24.9)
                {
                    MessageBox.Show("You are normal");
                    label4.Text = "Breakfast - Atta or moong dal chilla / scrambled eggs + toast";
                    label5.Text = "Lunch - Brown rice + gravy sabzi or dal.";
                    label6.Text = "Dinner – Brown rice + paneer or steamed fish";

                }
                if (bmi > 25 && bmi < 29)
                {
                    MessageBox.Show("You are over-weight");
                    label4.Text = "Breakfast - Whole grain roti + sabzi / soup + salad";
                    label5.Text = "Lunch - Yogurt with fruits";
                    label6.Text = "Dinner – Whole grain roti + sabzi / soup + salad";

                }
                if (bmi > 30)
                {
                    MessageBox.Show("You are very overweight you need to see a dietician or have to take some consultation");
                    

                }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            for_users obj = new for_users();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int weight;
            int height;
            int bmi;
            weight = int.Parse(textBox1.Text);
            height = int.Parse(textBox2.Text);
            bmi = weight / (height * height);
            if (bmi < 18.5)
            {
                MessageBox.Show("You are too under weight exercise will disbalace ur health");
                label7.Text = "Yoga/nMeditation.";
                

            }

            if (bmi > 18.5 && bmi < 24.9)
            {
                MessageBox.Show("You are normal");
                label7.Text = "PushUps";
                label8.Text = "PullUps.";
                label9.Text = "Lunges/nSquats";

            }
            if (bmi > 25 && bmi < 29)
            {
                MessageBox.Show("You are over-weight");
                label7.Text = "Cycling";
                label8.Text = "Running";
                label9.Text = "Crunches and Yoga";

            }
            if (bmi > 30)
            {
                MessageBox.Show("You are very overweight you need to see a dietician or have to take some consultation");
                label7.Text = "Cycling";
                label8.Text = "Running";
                label9.Text = "Crunches and Yoga";

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
