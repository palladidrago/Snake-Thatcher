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
            this.apple2 = new System.Windows.Forms.Label();
            this.apple4 = new System.Windows.Forms.Label();
            this.apple6 = new System.Windows.Forms.Label();
            this.apple5 = new System.Windows.Forms.Label();
            this.apple3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.label_MultiColor = new System.Windows.Forms.Label();
            this.pillar1 = new System.Windows.Forms.Label();
            this.pillar2 = new System.Windows.Forms.Label();
            this.base2 = new System.Windows.Forms.Label();
            this.base1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // snake
            // 
            this.snake.BackColor = System.Drawing.Color.Lime;
            this.snake.Location = new System.Drawing.Point(12, 20);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(37, 33);
            this.snake.TabIndex = 0;
            // 
            // apple1
            // 
            this.apple1.BackColor = System.Drawing.Color.Red;
            this.apple1.Location = new System.Drawing.Point(178, 20);
            this.apple1.Name = "apple1";
            this.apple1.Size = new System.Drawing.Size(37, 33);
            this.apple1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // apple2
            // 
            this.apple2.BackColor = System.Drawing.Color.Red;
            this.apple2.Location = new System.Drawing.Point(766, 20);
            this.apple2.Name = "apple2";
            this.apple2.Size = new System.Drawing.Size(37, 33);
            this.apple2.TabIndex = 0;
            // 
            // apple4
            // 
            this.apple4.BackColor = System.Drawing.Color.Red;
            this.apple4.Location = new System.Drawing.Point(19, 419);
            this.apple4.Name = "apple4";
            this.apple4.Size = new System.Drawing.Size(30, 30);
            this.apple4.TabIndex = 0;
            // 
            // apple6
            // 
            this.apple6.BackColor = System.Drawing.Color.Red;
            this.apple6.Location = new System.Drawing.Point(492, 87);
            this.apple6.Name = "apple6";
            this.apple6.Size = new System.Drawing.Size(30, 30);
            this.apple6.TabIndex = 0;
            // 
            // apple5
            // 
            this.apple5.BackColor = System.Drawing.Color.Red;
            this.apple5.Location = new System.Drawing.Point(12, 87);
            this.apple5.Name = "apple5";
            this.apple5.Size = new System.Drawing.Size(30, 30);
            this.apple5.TabIndex = 0;
            // 
            // apple3
            // 
            this.apple3.BackColor = System.Drawing.Color.Red;
            this.apple3.Location = new System.Drawing.Point(773, 419);
            this.apple3.Name = "apple3";
            this.apple3.Size = new System.Drawing.Size(30, 30);
            this.apple3.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 10;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // label_MultiColor
            // 
            this.label_MultiColor.AutoSize = true;
            this.label_MultiColor.Font = new System.Drawing.Font("Mistral", 72F);
            this.label_MultiColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_MultiColor.Location = new System.Drawing.Point(73, 178);
            this.label_MultiColor.Name = "label_MultiColor";
            this.label_MultiColor.Size = new System.Drawing.Size(419, 143);
            this.label_MultiColor.TabIndex = 0;
            this.label_MultiColor.Text = "YOU WIN";
            this.label_MultiColor.Visible = false;
            // 
            // pillar1
            // 
            this.pillar1.BackColor = System.Drawing.Color.Red;
            this.pillar1.Location = new System.Drawing.Point(637, 419);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(100, 23);
            this.pillar1.TabIndex = 1;
            this.pillar1.Visible = false;
            // 
            // pillar2
            // 
            this.pillar2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pillar2.Location = new System.Drawing.Point(48, 63);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(64, 37);
            this.pillar2.TabIndex = 2;
            this.pillar2.Visible = false;
            // 
            // base2
            // 
            this.base2.BackColor = System.Drawing.Color.Yellow;
            this.base2.Location = new System.Drawing.Point(48, 40);
            this.base2.Name = "base2";
            this.base2.Size = new System.Drawing.Size(100, 23);
            this.base2.TabIndex = 3;
            this.base2.Visible = false;
            // 
            // base1
            // 
            this.base1.BackColor = System.Drawing.Color.Purple;
            this.base1.Location = new System.Drawing.Point(673, 442);
            this.base1.Name = "base1";
            this.base1.Size = new System.Drawing.Size(64, 37);
            this.base1.TabIndex = 4;
            this.base1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(842, 493);
            this.Controls.Add(this.base1);
            this.Controls.Add(this.base2);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Controls.Add(this.label_MultiColor);
            this.Controls.Add(this.snake);
            this.Controls.Add(this.apple6);
            this.Controls.Add(this.apple4);
            this.Controls.Add(this.apple3);
            this.Controls.Add(this.apple5);
            this.Controls.Add(this.apple2);
            this.Controls.Add(this.apple1);
            this.Name = "Form1";
            this.Text = "Snake Thatcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label snake;
        private System.Windows.Forms.Label apple1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label apple2;
        private System.Windows.Forms.Label apple4;
        private System.Windows.Forms.Label apple6;
        private System.Windows.Forms.Label apple5;
        private System.Windows.Forms.Label apple3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Label label_MultiColor;
        private System.Windows.Forms.Label pillar1;
        private System.Windows.Forms.Label pillar2;
        private System.Windows.Forms.Label base2;
        private System.Windows.Forms.Label base1;
    }
}

