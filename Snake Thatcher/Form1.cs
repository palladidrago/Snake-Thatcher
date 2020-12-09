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
            for (int i = 2; i <= 10; i++)
            {
                this.Controls[$"apple{i}"].Visible=false;
                
            }
        }
        int curApple = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            snake.Left+=10;
            if (snake.Right > this.Controls["apple" + curApple].Right)
            {
                this.Controls["apple" + curApple].Visible = false;
                curApple++;
                this.Controls["apple" + curApple].Visible = true;
                if (curApple == 3)
                {
                    snake.Height *= 2;
                    snake.Width /= 2;
                    snake.Left += snake.Width;
                    timer1.Enabled = false;
                    timer2.Enabled = true; 
                }
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
           

        }
        private void ChangeApple()
        {
            MessageBox.Show(curApple.ToString());

        }
    }
}
