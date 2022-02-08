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
        string[] textArray;
        int story = 0;
        public Form1()
        {
            InitializeComponent();
            // Fetches story from Text file and spilts it up in the diffrent parts of story in an array 
            string path = @"StoryFile.txt";
            string text = File.ReadAllText(path);
            textArray = text.Split('|');
            textBox1.Text = textArray[0];
        }
        // When Label is clicked
        private void label1_Click(object sender, EventArgs e)
        {
            // Changes its text to bungus
            label1.Text = "Bungus";
            // Sets the location to a new point at the left of the screen
            label1.Location = new Point(-30, 40);
            // Sets the font to be size 170
            label1.Font = new Font(label1.Font.FontFamily, 170);
            // Hides buttons and textbox
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Visible = false;
        }
        // checks if Button one which is the button to the left is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            // if statements check where in the story it is 

            //This is the first part right after you press start
            if (story == 0)
            {
                // Sets the textbox content to be the story if you choose option 1
                textBox1.Text = textArray[1];
                // story progresion to keep track of which part of the story we are in
                story += 1;
                //Sets the text of the buttons to the next option
                button1.Text = "Heaven";
                button2.Text = "Home";
                button3.Text = "Hell";
            }
            else if (story == 1)
            {
                // Sets the textbox content to be the story if you choose option 1
                textBox1.Text = textArray[2];
                // Hides the buttons
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                // Moves and resizes the quit button to the middle button
                button5.Location = button2.Location;
                button5.Size = button2.Size;
                button5.Font = button2.Font;
            }
            else if (story == 2)
            {
                textBox1.Text = textArray[6];
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Location = button2.Location;
                button5.Size = button2.Size;
                button5.Font = button2.Font;
            }
            else if (story == 3)
            {
                textBox1.Text = textArray[10];
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Location = button2.Location;
                button5.Size = button2.Size;
                button5.Font = button2.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (story == 0)
            {
                textBox1.Text = textArray[5];
                story += 2;
                button1.Text = "Don't give water";
                button2.Text = "Sparkeling water";
                button3.Text = "Normal water";
            }
            else if (story == 1)
            {
                textBox1.Text = textArray[3];
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Location = button2.Location;
                button5.Size = button2.Size;
                button5.Font = button2.Font;
            }
            else if (story == 2)
            {
                textBox1.Text = textArray[7];
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Location = button2.Location;
                button5.Size = button2.Size;
                button5.Font = button2.Font;
            }
            else if (story == 3)
            {
                textBox1.Text = textArray[11];
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Location = button2.Location;
                button5.Size = button2.Size;
                button5.Font = button2.Font;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (story == 0)
            {
                textBox1.Text = textArray[9];
                story += 3;
                button1.Text = "Climb the mountain";
                button2.Text = "Jump over it";
                button3.Text = "Go around it";
            }
            else if (story == 1)
            {
                textBox1.Text = textArray[4];
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Location = button2.Location;
                button5.Size = button2.Size;
                button5.Font = button2.Font;
            }
            else if (story == 2)
            {
                textBox1.Text = textArray[8];
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Location = button2.Location;
                button5.Size = button2.Size;
                button5.Font = button2.Font;
            }
            else if (story == 3)
            {
                textBox1.Text = textArray[12];
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button5.Location = button2.Location;
                button5.Size = button2.Size;
                button5.Font = button2.Font;
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
