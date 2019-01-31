using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoGame
{
    public partial class Form1 : Form
    {
        bool[] if_button_has_color = new bool[17];
        bool[] hidden = new bool[17];
        bool if_first_try = true;
        Color[] colors = new Color[17];
        int first_number = 0;
        int second_number = 0;

        public Form1()
        {
            InitializeComponent();

            draw_button(Color.Red);
            draw_button(Color.Red);
            draw_button(Color.Blue);
            draw_button(Color.Blue);
            draw_button(Color.Pink);
            draw_button(Color.Pink);
            draw_button(Color.Green);
            draw_button(Color.Green);
            draw_button(Color.LightCoral);
            draw_button(Color.LightCoral);
            draw_button(Color.Gold);
            draw_button(Color.Gold);
            draw_button(Color.Khaki);
            draw_button(Color.Khaki);
            draw_button(Color.White);
            draw_button(Color.White);

            for (int i = 0; i < hidden.Length; i++) { hidden[i] = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[1])
            {                
                button1.BackColor = colors[1];

                if (if_first_try == true)
                {
                    first_number = 1;
                    if_first_try = false;
                }
                else
                {
                    second_number = 1;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void draw_button(Color color)
        {
            Random gen = new Random();
            int number_of_field = gen.Next(1, 17);
            while (if_button_has_color[number_of_field] == true)
            {
                number_of_field = gen.Next(1, 17);
            }
            if_button_has_color[number_of_field] = true;
            colors[number_of_field] = color;
        }

        private void color_button()
        {
            if (hidden[1] == false) { button1.BackColor = colors[1]; } else { button1.BackColor = Color.Gray; }
            if (hidden[2] == false) { button1.BackColor = colors[2]; } else { button1.BackColor = Color.Gray; }
            if (hidden[3] == false) { button1.BackColor = colors[3]; } else { button1.BackColor = Color.Gray; }
            if (hidden[4] == false) { button1.BackColor = colors[4]; } else { button1.BackColor = Color.Gray; }
            if (hidden[5] == false) { button1.BackColor = colors[5]; } else { button1.BackColor = Color.Gray; }
            if (hidden[6] == false) { button1.BackColor = colors[6]; } else { button1.BackColor = Color.Gray; }
            if (hidden[7] == false) { button1.BackColor = colors[7]; } else { button1.BackColor = Color.Gray; }
            if (hidden[8] == false) { button1.BackColor = colors[8]; } else { button1.BackColor = Color.Gray; }
            if (hidden[9] == false) { button1.BackColor = colors[9]; } else { button1.BackColor = Color.Gray; }
            if (hidden[10] == false) { button1.BackColor = colors[10]; } else { button1.BackColor = Color.Gray; }
            if (hidden[11] == false) { button1.BackColor = colors[11]; } else { button1.BackColor = Color.Gray; }
            if (hidden[12] == false) { button1.BackColor = colors[12]; } else { button1.BackColor = Color.Gray; }
            if (hidden[13] == false) { button1.BackColor = colors[13]; } else { button1.BackColor = Color.Gray; }
            if (hidden[14] == false) { button1.BackColor = colors[14]; } else { button1.BackColor = Color.Gray; }
            if (hidden[15] == false) { button1.BackColor = colors[15]; } else { button1.BackColor = Color.Gray; }
            if (hidden[16] == false) { button1.BackColor = colors[16]; } else { button1.BackColor = Color.Gray; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[2])
            {
                button1.BackColor = colors[2];

                if (if_first_try == true)
                {
                    first_number = 2;
                    if_first_try = false;
                }
                else
                {
                    second_number = 2;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[3])
            {
                button1.BackColor = colors[3];

                if (if_first_try == true)
                {
                    first_number = 3;
                    if_first_try = false;
                }
                else
                {
                    second_number = 3;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[5])
            {
                button1.BackColor = colors[5];

                if (if_first_try == true)
                {
                    first_number = 5;
                    if_first_try = false;
                }
                else
                {
                    second_number = 5;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[4])
            {
                button1.BackColor = colors[4];

                if (if_first_try == true)
                {
                    first_number = 4;
                    if_first_try = false;
                }
                else
                {
                    second_number = 4;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[6])
            {
                button1.BackColor = colors[6];

                if (if_first_try == true)
                {
                    first_number = 6;
                    if_first_try = false;
                }
                else
                {
                    second_number = 6;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[7])
            {
                button1.BackColor = colors[7];

                if (if_first_try == true)
                {
                    first_number = 7;
                    if_first_try = false;
                }
                else
                {
                    second_number = 7;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[8])
            {
                button1.BackColor = colors[8];

                if (if_first_try == true)
                {
                    first_number = 8;
                    if_first_try = false;
                }
                else
                {
                    second_number = 8;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[9])
            {
                button1.BackColor = colors[9];

                if (if_first_try == true)
                {
                    first_number = 9;
                    if_first_try = false;
                }
                else
                {
                    second_number = 9;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[10])
            {
                button1.BackColor = colors[10];

                if (if_first_try == true)
                {
                    first_number = 10;
                    if_first_try = false;
                }
                else
                {
                    second_number = 10;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[12])
            {
                button1.BackColor = colors[12];

                if (if_first_try == true)
                {
                    first_number = 12;
                    if_first_try = false;
                }
                else
                {
                    second_number = 12;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[13])
            {
                button1.BackColor = colors[13];

                if (if_first_try == true)
                {
                    first_number = 13;
                    if_first_try = false;
                }
                else
                {
                    second_number = 13;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[11])
            {
                button1.BackColor = colors[11];

                if (if_first_try == true)
                {
                    first_number = 11;
                    if_first_try = false;
                }
                else
                {
                    second_number = 11;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[14])
            {
                button1.BackColor = colors[14];

                if (if_first_try == true)
                {
                    first_number = 14;
                    if_first_try = false;
                }
                else
                {
                    second_number = 14;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[15])
            {
                button1.BackColor = colors[15];

                if (if_first_try == true)
                {
                    first_number = 15;
                    if_first_try = false;
                }
                else
                {
                    second_number = 15;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[16])
            {
                button1.BackColor = colors[16];

                if (if_first_try == true)
                {
                    first_number = 16;
                    if_first_try = false;
                }
                else
                {
                    second_number = 16;
                    if_first_try = true;
                    check();
                    color_button();
                }
            }
        }
    }
}
