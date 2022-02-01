using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminsProeve
{
    public partial class Form1 : Form
    {
        int story = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bungus";
            label1.Location = new Point(-30, 50);
            label1.Font = new Font(label1.Font.FontFamily, 170);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (story == 0)
            {
                //Insert Option One Story here
                story += 1;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
            if (story == 1)
            {
                //Insert Option 1,1 story here
                story += 10;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
            if (story == 2)
            {
                //Insert Option 2,1 story here
                story += 10;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
            if (story == 3)
            {
                //Insert Option 3,1 story here
                story += 10;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (story == 0)
            {
                //Insert Option Two Story here
                story += 2;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
            if (story == 1)
            {
                //Insert Option 1,2 story here
                story += 20;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
            if (story == 2)
            {
                //Insert Option 2,2 story here
                story += 20;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
            if (story == 3)
            {
                //Insert Option 3,2 story here
                story += 20;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (story == 0)
            {
                //Insert Option Three Story here
                story += 3;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
            if (story == 1)
            {
                //Insert Option 1,3 story here
                story += 30;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
            if (story == 2)
            {
                //Insert Option 2,3 story here
                story += 30;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
            if (story == 3)
            {
                //Insert Option 3,3 story here
                story += 30;
                //button1.Text = "Insert Next option";
                //button2.Text = "Insert Next option";
                //button3.Text = "Insert Next option";
            }
        }
    }
}
