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
        Color[] colors = new Color[17];

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
            button1.BackColor = colors[1];
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
    }
}
