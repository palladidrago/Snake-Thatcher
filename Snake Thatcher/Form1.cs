using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Thatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 2; i <= 6; i++)
            {
                this.Controls[$"apple{i}"].Visible = false;

            }
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer("humor.wav");
        const int speed = 10;
        const int gain = 20;

        const int height = 33;
        int width = 37;
        int curApple = 1;
        int funCount = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            snake.Left += speed;
            if (snake.Right > this.Controls["apple" + curApple].Right)
            {
                
                this.Controls["apple" + curApple].Visible = false;
                curApple++;
                this.Controls["apple" + curApple].Visible = true;

                if (curApple == 2)
                {
                    snake.Width += gain;
                    width += gain;
                    snake.Left -= gain;
                }
                int temp;
                if (curApple == 3)
                {
                    temp = snake.Height;
                    snake.Height = snake.Width + gain;
                    snake.Left += snake.Width - temp;
                    snake.Width = temp;
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                }
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            snake.Top += speed;

            if (snake.Top + snake.Height > this.Controls["apple" + curApple].Top + this.Controls["apple" + curApple].Height)
            {
                this.Controls["apple" + curApple].Visible = false;
                curApple++;
                this.Controls["apple" + curApple].Visible = true;
                if (curApple == 4)
                {
                    int temp = snake.Width;
                    snake.Top += height ;
                    snake.Left = snake.Left + snake.Width / 2 - snake.Height;

                    snake.Width = snake.Height + gain;
                    width += gain;
                    snake.Height = temp;

                    timer2.Enabled = false;
                    timer3.Enabled = true;
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            int temp;
            snake.Left -= speed;
            if (snake.Left < this.Controls["apple" + curApple].Left)
            {
                this.Controls["apple" + curApple].Visible = false;
                curApple++;
                this.Controls["apple" + curApple].Visible = true;
                temp = snake.Height;
                snake.Height = snake.Width+gain;
                width += gain;
                
                snake.Width = temp;
                snake.Top += -snake.Height+ snake.Width-3;
                
                timer3.Enabled = false;
                timer4.Enabled = true;
                
            }




        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int temp;
            snake.Top -= speed;
            if (snake.Top < this.Controls["apple" + curApple].Top)
            {
                this.Controls["apple" + curApple].Visible = false;
                curApple++;
                this.Controls["apple" + curApple].Visible = true;
                temp = snake.Width;
                snake.Width = snake.Height;
                snake.Height = temp;
                

                timer4.Enabled = false;
                timer5.Enabled = true;

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            snake.Left += speed;
            if (snake.Right > this.Controls["apple" + curApple].Right)
            {
                this.Controls["apple" + curApple].Visible = false;
                curApple++;
                timer5.Enabled = false;
                snake.Left = 0;
                snake.Top = 0;
                player.Play();
                timer6.Enabled = true;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
           
            if (snake.Height < 5000) {
                
                snake.Height += 10;
                snake.Width += 10;
                
            }
            label_MultiColor.Visible = true;
            Random rnd = new Random();

            pillar1.Visible = true;
            pillar2.Visible = true;
            base1.Visible = true;
            base2.Visible = true;
            pillar1.Height += 2;
            pillar1.Top -= 2;
            pillar2.Height +=2;
            base1.Width += 2;
            base1.Left -= 2;
            base2.Width += 2;
            switch (rnd.Next(1, 5))
            {
                case 1:

                    label_MultiColor.ForeColor = Color.Red;
                    
                    break;
                case 2:

                    label_MultiColor.BackColor = Color.Green;
                    
                    break;
                case 3:

                    label_MultiColor.ForeColor = Color.Blue;
                    
                    break;
                case 4:

                    label_MultiColor.BackColor = Color.Yellow;
                    break;
                default:
                    break;
            }
            
            switch (funCount)
            {
                case 100:
                    label_MultiColor.Font = new Font("Mistral", 68);break;
                case 200:
                    label_MultiColor.Font = new Font("Monotxt", 50);break;
                case 300:
                    label_MultiColor.Font = new Font("Mistral", 80);break;
                case 400:
                    label_MultiColor.Font = new Font("Papyrus", 75);funCount = 0 ;break;
        }
            funCount++;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
