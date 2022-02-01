using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TerminsProeve
{
    public partial class Form1 : Form
    {
        int story = 0;
        public Form1()
        {
            InitializeComponent();
            string path = @"C:\Users\blaab\Documents\GitHub\TerminsProeve\TerminsProeve\TerminsProeve\Properties\StoryFile.txt";
            string text = File.ReadAllText(path);
            string[]textArray = text.Split('|');
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bungus";
            label1.Location = new Point(-30, 50);
            label1.Font = new Font(label1.Font.FontFamily, 170);
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Visible = false;
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
                //Insert Ending 1,1 here
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Location = button2.Location;
                button4.Size = button2.Size;
                button4.Font = button2.Font;
            }
            if (story == 2)
            {
                //Insert Ending 2,1 here
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Location = button2.Location;
                button4.Size = button2.Size;
                button4.Font = button2.Font;
            }
            if (story == 3)
            {
                //Insert Ending 3,1  here
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Location = button2.Location;
                button4.Size = button2.Size;
                button4.Font = button2.Font;
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
                //Insert Ending 1,2 here
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Location = button2.Location;
                button4.Size = button2.Size;
                button4.Font = button2.Font;
            }
            if (story == 2)
            {
                //Insert Ending 2,2 here
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Location = button2.Location;
                button4.Size = button2.Size;
                button4.Font = button2.Font;
            }
            if (story == 3)
            {
                //Insert Ending 3,2  here
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Location = button2.Location;
                button4.Size = button2.Size;
                button4.Font = button2.Font;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (story == 0)
            {
                //Insert Option Three Story here
                story += 3;
                button1.Text = "Climb the mountain";
                button2.Text = "Jump over it";
                button3.Text = "Go around it";
            }
            if (story == 1)
            {
                //Insert Ending 1,3 here
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Location = button2.Location;
                button4.Size = button2.Size;
                button4.Font = button2.Font;
            }
            if (story == 2)
            {
                //Insert Ending 2,3 here
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Location = button2.Location;
                button4.Size = button2.Size;
                button4.Font = button2.Font;
            }
            if (story == 3)
            {
                //Insert Ending 3,3  here
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Location = button2.Location;
                button4.Size = button2.Size;
                button4.Font = button2.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            label2.Visible = false;
            textBox1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            //Muligvis pop up om spiller er sikker
        }
    }
}
