using System;
using System.Drawing;
using System.Windows.Forms;

namespace pk111Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int window;
        int score = 0;
        int newY1 = 12;
        int newY2 = 12;

        private void timer1_Tick(object sender, EventArgs e)
        {//для первой кнопки

            newY1 += 3;
            button1.Location = new Point(163, newY1);
            if (button1.Location.Y >= window - 50 - button1.Size.Height)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                button5.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//первая кнопка
            button1.Location = new Point(163, 12);
            newY1 = 12;
            if (timer1.Enabled == true)
            {
                score++;
            }
            label1.Text = "Score:" + score.ToString();
            timer1.Interval = rnd.Next(10,50);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {//для второй кнопки
            newY2 += 3;
            button2.Location = new Point(353, newY2);
        }

        private void button2_Click(object sender, EventArgs e)
        {//вторая кнопка
            button2.Location = new Point(353, 12);
            newY2 = 12;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            window = this.Size.Height;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                score--;
                label1.Text = "Score:" + score.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {//restart
            newY1 = newY2 = 12;
            score = 0;
            label1.Text = "Score:" + score.ToString();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            button5.Visible = false;
        }
    }
}
