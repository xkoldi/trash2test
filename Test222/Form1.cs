using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test222
{
    public partial class Form1 : Form
    {

        int blood;
        int alcdrg;
        int nagot;
        int nasil;
        int leks;
        int scream;
        int trig;
        int trig6;
        int trig12;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                button1.Visible = false;
                panel2.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                alcdrg = 16;
                panel2.Visible = false;
                panel3.Visible = true;
            }

            if (radioButton2.Checked)
            {
                alcdrg = 0;
                panel2.Visible = false;
                panel3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (radioButton3.Checked)
            {
                blood = 0;
                panel3.Visible = false;
                panel4.Visible = true;
            }

            if (radioButton4.Checked)
            {
                blood = 12;
                panel3.Visible = false;
                panel4.Visible = true;
            }

            if (radioButton5.Checked)
            {
                blood = 16;
                panel3.Visible = false;
                panel4.Visible = true;
            }

            if (radioButton6.Checked)
            {
                blood = 18;
                panel3.Visible = false;
                panel4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (radioButton7.Checked)
            {
                nagot = 0;
                panel4.Visible = false;
                panel5.Visible = true;
            }

            if (radioButton8.Checked)
            {
                nagot = 12;
                panel4.Visible = false;
                panel5.Visible = true;
            }

            if (radioButton9.Checked)
            {
                nagot = 16;
                panel4.Visible = false;
                panel5.Visible = true;
            }

            if (radioButton10.Checked)
            {
                nagot = 18;
                panel4.Visible = false;
                panel5.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

         

            if (radioButton11.Checked)
            {
                nasil = 0;
                panel5.Visible = false;
                panel6.Visible = true;
            }

            if (radioButton12.Checked)
            {
                nasil = 6;
                panel5.Visible = false;
                panel6.Visible = true;
            }

            if (radioButton13.Checked)
            {
                nasil = 12;
                panel5.Visible = false;
                panel6.Visible = true;
            }

            if (radioButton14.Checked)
            {
                nasil = 16;
                panel5.Visible = false;
                panel6.Visible = true;
            }

            if (radioButton15.Checked)
            {
                nasil = 18;
                panel5.Visible = false;
                panel6.Visible = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (radioButton16.Checked)
            {
                leks = 0;
                panel6.Visible = false;
                panel1.Visible = true;
            }

            if (radioButton17.Checked)
            {
                leks = 12;
                panel6.Visible = false;
                panel1.Visible = true;
            }

            if (radioButton18.Checked)
            {
                leks = 16;
                panel6.Visible = false;
                panel1.Visible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            



        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                scream = 16;
                panel1.Visible = false;
                panel7.Visible = true;
            }

            if (radioButton20.Checked)
            {
                scream = 0;
                panel1.Visible = false;
                panel7.Visible = true;
            }

            if (radioButton21.Checked)
            {
                scream = 6;
                panel1.Visible = false;
                panel7.Visible = true;
            }
            
            if(alcdrg==0 && blood==0 && nagot==0 && nasil == 0 && leks == 0 && scream == 0)
            {
                label7.Text = "возрастной рейтинг игры 0+";
                trig = 1;
            }

            if (alcdrg <= 6 && blood <= 6 && nagot <= 6 && nasil <= 6 && leks <= 6 && scream <= 6 && trig != 1)
            {
                label7.Text = "возрастной рейтинг игры 6+";
                trig6 = 1;
            }

            if (alcdrg <= 12 && blood <= 12 && nagot <= 12 && nasil <= 12 && leks <= 12 && scream <= 12 && trig != 1 && trig6 != 1)
            {
                label7.Text = "возрастной рейтинг игры 12+";
                trig12 = 1;
            }

            if (alcdrg <= 16 && blood <= 16 && nagot <= 16 && nasil <= 16 && leks <= 16 && scream <= 16 && trig != 1 && trig6 != 1 && trig12 != 1)
            {
                label7.Text = "возрастной рейтинг игры 16+";
            }

            if (alcdrg == 18 || blood == 18 || nagot == 18 || nasil == 18 || leks == 18 || scream == 18)
            {
                label7.Text = "возрастной рейтинг игры 18+";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel2.Visible = true;
        }
    }
}
