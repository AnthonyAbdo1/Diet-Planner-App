using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workout_Application
{
    public partial class dietPlanner : Form
    {
        public dietPlanner()
        {
            InitializeComponent();
        }
        //Main Form// 
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Gender Selection//
        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Height Selection//
        private void shorter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void average_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tall_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Activity Selection//
        private void lowActivity_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void moderateActivity_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Calorie Need Calculator Button//
        public void caloricNeed_Click(object sender, EventArgs e)
        {
            int maleCalories = 0;
            int femaleCalories = 0;


            //Male Section//
            //Low Activity for all heights//
            if (male.Checked == true && lowActivity.Checked == true && shorter.Checked == true)
            {
                maleCalories = 1600;
            }

            else if (male.Checked == true && lowActivity.Checked == true && average.Checked == true)
            {
                maleCalories = 1700;
            }

            else if (male.Checked == true && lowActivity.Checked == true && tall.Checked == true)
            {
                maleCalories = 1900;
            }

            //Moderate Activity for all heights// 
            else if (male.Checked == true && moderateActivity.Checked == true && shorter.Checked == true)
            {
                maleCalories = 1700;
            }

            else if (male.Checked == true && moderateActivity.Checked == true && average.Checked == true)
            {
                maleCalories = 1800;
            }

            else if (male.Checked == true && moderateActivity.Checked == true && tall.Checked == true)
            {
                maleCalories = 2000;
            }


            //High Activity for all heights//
            else if (male.Checked == true && checkBox3.Checked == true && shorter.Checked == true)
            {
                maleCalories = 2000;
            }

            else if (male.Checked == true && checkBox3.Checked == true && average.Checked == true)
            {
                maleCalories = 2200;
            }

            else if (male.Checked == true && checkBox3.Checked == true && tall.Checked == true)
            {
                maleCalories = 2400;
            }

         
            //Female Section//
            //Low Activity for all heights//
            if (female.Checked == true && lowActivity.Checked == true && shorter.Checked == true)
            {
                femaleCalories = 1500;
            }

            else if (female.Checked == true && lowActivity.Checked == true && average.Checked == true)
            {
                femaleCalories = 1600;
            }

            else if (female.Checked == true && lowActivity.Checked == true && tall.Checked == true)
            {
                femaleCalories = 1800;
            }

            //Moderate Activity for all heights// 
            else if (female.Checked == true && moderateActivity.Checked == true && shorter.Checked == true)
            {
                femaleCalories = 1600;
            }

            else if (female.Checked == true && moderateActivity.Checked == true && average.Checked == true)
            {
                femaleCalories = 1700;
            }

            else if (female.Checked == true && moderateActivity.Checked == true && tall.Checked == true)
            {
                femaleCalories = 2000;
            }

           
            //High Activity for all heights//
            else if (female.Checked == true && checkBox3.Checked == true && shorter.Checked == true)
            {
                femaleCalories = 2000;
            }

            else if (female.Checked == true && checkBox3.Checked == true && average.Checked == true)
            {
                femaleCalories = 2100;
            }

            else if (female.Checked == true && checkBox3.Checked == true && tall.Checked == true)
            {
                femaleCalories = 2200;
            }

            if (male.Checked == true)
            {
                caloricNeeds.Text = Convert.ToString(maleCalories);
            }

            else if (female.Checked == true)
            {
                caloricNeeds.Text = Convert.ToString(femaleCalories);
            }


        }

        //Calorie Need Output Box//
        private void caloricNeeds_TextChanged(object sender, EventArgs e)
        {

        }


        //Diet plan section//
        private void easyMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void regularMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Target calorie loss button//
        private void weightLossCalc_Click(object sender, EventArgs e)
        {

            if (easyMode.Checked == true)
            {
                var userCalories = Convert.ToInt32(caloricNeeds.Text);
                calorieDeficit.Text = Convert.ToString(userCalories - 200);
            }

            else if (regularMode.Checked == true)
            {
                var userCalories = Convert.ToInt32(caloricNeeds.Text);
                calorieDeficit.Text = Convert.ToString(userCalories - 400);
            }

            else if (checkBox4.Checked == true)
            {
                var userCalories = Convert.ToInt32(caloricNeeds.Text);
                calorieDeficit.Text = Convert.ToString(userCalories - 600);
            }

        }

        private void calorieDeficit_TextChanged(object sender, EventArgs e)
        {

        }

        //Daily Diet Suggestions//
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
