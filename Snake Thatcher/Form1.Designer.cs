namespace Snake_Thatcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.snake = new System.Windows.Forms.Label();
            this.apple1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.apple8 = new System.Windows.Forms.Label();
            this.apple2 = new System.Windows.Forms.Label();
            this.apple10 = new System.Windows.Forms.Label();
            this.apple7 = new System.Windows.Forms.Label();
            this.apple4 = new System.Windows.Forms.Label();
            this.apple6 = new System.Windows.Forms.Label();
            this.apple5 = new System.Windows.Forms.Label();
            this.apple9 = new System.Windows.Forms.Label();
            this.apple3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // snake
            // 
            this.snake.BackColor = System.Drawing.Color.Lime;
            this.snake.Location = new System.Drawing.Point(12, 20);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(69, 33);
            this.snake.TabIndex = 0;
            // 
            // apple1
            // 
            this.apple1.BackColor = System.Drawing.Color.Red;
            this.apple1.Location = new System.Drawing.Point(190, 31);
            this.apple1.Name = "apple1";
            this.apple1.Size = new System.Drawing.Size(22, 22);
            this.apple1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // apple8
            // 
            this.apple8.BackColor = System.Drawing.Color.Red;
            this.apple8.Location = new System.Drawing.Point(25, 165);
            this.apple8.Name = "apple8";
            this.apple8.Size = new System.Drawing.Size(22, 22);
            this.apple8.TabIndex = 0;
            // 
            // apple2
            // 
            this.apple2.BackColor = System.Drawing.Color.Red;
            this.apple2.Location = new System.Drawing.Point(766, 31);
            this.apple2.Name = "apple2";
            this.apple2.Size = new System.Drawing.Size(22, 22);
            this.apple2.TabIndex = 0;
            // 
            // apple10
            // 
            this.apple10.BackColor = System.Drawing.Color.Red;
            this.apple10.Location = new System.Drawing.Point(12, 419);
            this.apple10.Name = "apple10";
            this.apple10.Size = new System.Drawing.Size(22, 22);
            this.apple10.TabIndex = 0;
            // 
            // apple7
            // 
            this.apple7.BackColor = System.Drawing.Color.Red;
            this.apple7.Location = new System.Drawing.Point(230, 317);
            this.apple7.Name = "apple7";
            this.apple7.Size = new System.Drawing.Size(22, 22);
            this.apple7.TabIndex = 0;
            // 
            // apple4
            // 
            this.apple4.BackColor = System.Drawing.Color.Red;
            this.apple4.Location = new System.Drawing.Point(715, 297);
            this.apple4.Name = "apple4";
            this.apple4.Size = new System.Drawing.Size(22, 22);
            this.apple4.TabIndex = 0;
            // 
            // apple6
            // 
            this.apple6.BackColor = System.Drawing.Color.Red;
            this.apple6.Location = new System.Drawing.Point(544, 165);
            this.apple6.Name = "apple6";
            this.apple6.Size = new System.Drawing.Size(22, 22);
            this.apple6.TabIndex = 0;
            // 
            // apple5
            // 
            this.apple5.BackColor = System.Drawing.Color.Red;
            this.apple5.Location = new System.Drawing.Point(463, 267);
            this.apple5.Name = "apple5";
            this.apple5.Size = new System.Drawing.Size(22, 22);
            this.apple5.TabIndex = 0;
            // 
            // apple9
            // 
            this.apple9.BackColor = System.Drawing.Color.Red;
            this.apple9.Location = new System.Drawing.Point(115, 317);
            this.apple9.Name = "apple9";
            this.apple9.Size = new System.Drawing.Size(22, 22);
            this.apple9.TabIndex = 0;
            // 
            // apple3
            // 
            this.apple3.BackColor = System.Drawing.Color.Red;
            this.apple3.Location = new System.Drawing.Point(766, 419);
            this.apple3.Name = "apple3";
            this.apple3.Size = new System.Drawing.Size(22, 22);
            this.apple3.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            // 
            // timer6
            // 
            this.timer6.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.snake);
            this.Controls.Add(this.apple6);
            this.Controls.Add(this.apple4);
            this.Controls.Add(this.apple3);
            this.Controls.Add(this.apple9);
            this.Controls.Add(this.apple5);
            this.Controls.Add(this.apple7);
            this.Controls.Add(this.apple10);
            this.Controls.Add(this.apple2);
            this.Controls.Add(this.apple8);
            this.Controls.Add(this.apple1);
            this.Name = "Form1";
            this.Text = "Snake Thatcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label snake;
        private System.Windows.Forms.Label apple1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label apple8;
        private System.Windows.Forms.Label apple2;
        private System.Windows.Forms.Label apple10;
        private System.Windows.Forms.Label apple7;
        private System.Windows.Forms.Label apple4;
        private System.Windows.Forms.Label apple6;
        private System.Windows.Forms.Label apple5;
        private System.Windows.Forms.Label apple9;
        private System.Windows.Forms.Label apple3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
    }
}

