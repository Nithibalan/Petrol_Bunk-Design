using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBunk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wheels = 0;
            int price = 0;
            int total = 0;

            listBox1.Items.Clear();
            listBox1.Items.Add("Petrol_Bunk");
            listBox1.Items.Add("Registration Form:" + textBox1.Text);
            if (radioButton1.Checked)
            {
                wheels = 2;
                listBox1.Items.Add("Your vechile type is:" + radioButton1.Text);
            }
            if (radioButton2.Checked)
            {
                wheels = 4;
                listBox1.Items.Add("Your vechile type is:" + radioButton2.Text);

            }
            if (comboBox1.SelectedItem == "PETROL")
            {
                price = 100;
                listBox1.Items.Add("vechile fuel is:" + comboBox1.Text);
            }
            if (comboBox1.SelectedItem == "DISEL")
            {
                price = 80;
                listBox1.Items.Add("vechile fuel is:" + comboBox1.Text);
            }

        

            if (checkBox1.Checked)
            {
                int Air;
                int temp = 5 * wheels;
                total += temp;
                listBox1.Items.Add("Cost of air:" + temp);
            }
            if (checkBox2.Checked)
            {
                int litres = (int)numericUpDown1.Value;
                int temp = litres * price;
                total += temp;
                listBox1.Items.Add("Cost of fuel:" + temp);
            }
            if (checkBox3.Checked)
            {
                int ml = (int)numericUpDown2.Value;
                int temp = 10 * ml;
                total += temp;
                listBox1.Items.Add("Cost of oil:" + temp);
            }

            listBox1.Items.Add("Total is:" + total);




            












        }


        }
    }

