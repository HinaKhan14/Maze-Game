namespace WindowsFormsApplication6
{
    partial class Hard_Mode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.change_maze5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Change_maze1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.level6 = new System.Windows.Forms.Button();
            this.level5 = new System.Windows.Forms.Button();
            this.level4 = new System.Windows.Forms.Button();
            this.level3 = new System.Windows.Forms.Button();
            this.level2 = new System.Windows.Forms.Button();
            this.Clear_screen = new System.Windows.Forms.Button();
            this.level1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.change_maze2 = new System.Windows.Forms.Button();
            this.change_maze3 = new System.Windows.Forms.Button();
            this.change_maze4 = new System.Windows.Forms.Button();
            this.change_maze6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 594);
            this.panel1.TabIndex = 25;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1340, 594);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(0, 0);
            this.rectangleShape1.Name = "";
            this.rectangleShape1.Size = new System.Drawing.Size(0, 0);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1337, 603);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // change_maze5
            // 
            this.change_maze5.BackColor = System.Drawing.Color.Black;
            this.change_maze5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_maze5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change_maze5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_maze5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.change_maze5.Location = new System.Drawing.Point(596, 678);
            this.change_maze5.Name = "change_maze5";
            this.change_maze5.Size = new System.Drawing.Size(99, 29);
            this.change_maze5.TabIndex = 34;
            this.change_maze5.Text = "Change Maze";
            this.change_maze5.UseVisualStyleBackColor = false;
            this.change_maze5.Click += new System.EventHandler(this.change_maze5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(701, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Back to Levels";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(12, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(113, 32);
            this.button10.TabIndex = 29;
            this.button10.Text = "<-- Back";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Change_maze1
            // 
            this.Change_maze1.BackColor = System.Drawing.Color.Black;
            this.Change_maze1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Change_maze1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Change_maze1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_maze1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Change_maze1.Location = new System.Drawing.Point(596, 677);
            this.Change_maze1.Name = "Change_maze1";
            this.Change_maze1.Size = new System.Drawing.Size(99, 32);
            this.Change_maze1.TabIndex = 28;
            this.Change_maze1.Text = "Change Maze";
            this.Change_maze1.UseVisualStyleBackColor = false;
            this.Change_maze1.Click += new System.EventHandler(this.Change_maze1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(572, 718);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 32);
            this.button8.TabIndex = 27;
            this.button8.Text = "Solve";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // level6
            // 
            this.level6.BackColor = System.Drawing.Color.Black;
            this.level6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.level6.Location = new System.Drawing.Point(911, 676);
            this.level6.Name = "level6";
            this.level6.Size = new System.Drawing.Size(99, 32);
            this.level6.TabIndex = 26;
            this.level6.Text = "Level-6";
            this.level6.UseVisualStyleBackColor = false;
            this.level6.Click += new System.EventHandler(this.level6_Click);
            // 
            // level5
            // 
            this.level5.BackColor = System.Drawing.Color.Black;
            this.level5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.level5.Location = new System.Drawing.Point(806, 675);
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(99, 32);
            this.level5.TabIndex = 25;
            this.level5.Text = "Level-5";
            this.level5.UseVisualStyleBackColor = false;
            this.level5.Click += new System.EventHandler(this.level5_Click);
            // 
            // level4
            // 
            this.level4.BackColor = System.Drawing.Color.Black;
            this.level4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.level4.Location = new System.Drawing.Point(701, 673);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(99, 32);
            this.level4.TabIndex = 24;
            this.level4.Text = "Level-4";
            this.level4.UseVisualStyleBackColor = false;
            this.level4.Click += new System.EventHandler(this.level4_Click);
            // 
            // level3
            // 
            this.level3.BackColor = System.Drawing.Color.Black;
            this.level3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.level3.Location = new System.Drawing.Point(596, 676);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(99, 32);
            this.level3.TabIndex = 23;
            this.level3.Text = "Level-3";
            this.level3.UseVisualStyleBackColor = false;
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // level2
            // 
            this.level2.BackColor = System.Drawing.Color.Black;
            this.level2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.level2.Location = new System.Drawing.Point(491, 678);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(99, 32);
            this.level2.TabIndex = 22;
            this.level2.Text = "Level-2";
            this.level2.UseVisualStyleBackColor = false;
            this.level2.Click += new System.EventHandler(this.level2_Click_1);
            // 
            // Clear_screen
            // 
            this.Clear_screen.BackColor = System.Drawing.Color.Black;
            this.Clear_screen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_screen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear_screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_screen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clear_screen.Location = new System.Drawing.Point(750, 717);
            this.Clear_screen.Name = "Clear_screen";
            this.Clear_screen.Size = new System.Drawing.Size(122, 33);
            this.Clear_screen.TabIndex = 21;
            this.Clear_screen.Text = "Clear Screen";
            this.Clear_screen.UseVisualStyleBackColor = false;
            this.Clear_screen.Click += new System.EventHandler(this.Clear_screen_Click_1);
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.Color.Black;
            this.level1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.level1.Location = new System.Drawing.Point(386, 678);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(99, 32);
            this.level1.TabIndex = 20;
            this.level1.Text = "Level-1";
            this.level1.UseVisualStyleBackColor = false;
            this.level1.Click += new System.EventHandler(this.level1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 653);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Choose Level:";
            // 
            // change_maze2
            // 
            this.change_maze2.BackColor = System.Drawing.Color.Black;
            this.change_maze2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_maze2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change_maze2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_maze2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.change_maze2.Location = new System.Drawing.Point(596, 677);
            this.change_maze2.Name = "change_maze2";
            this.change_maze2.Size = new System.Drawing.Size(99, 32);
            this.change_maze2.TabIndex = 35;
            this.change_maze2.Text = "Change Maze";
            this.change_maze2.UseVisualStyleBackColor = false;
            this.change_maze2.Click += new System.EventHandler(this.change_maze2_Click);
            // 
            // change_maze3
            // 
            this.change_maze3.BackColor = System.Drawing.Color.Black;
            this.change_maze3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_maze3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change_maze3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_maze3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.change_maze3.Location = new System.Drawing.Point(596, 674);
            this.change_maze3.Name = "change_maze3";
            this.change_maze3.Size = new System.Drawing.Size(99, 32);
            this.change_maze3.TabIndex = 36;
            this.change_maze3.Text = "Change Maze";
            this.change_maze3.UseVisualStyleBackColor = false;
            this.change_maze3.Click += new System.EventHandler(this.change_maze3_Click);
            // 
            // change_maze4
            // 
            this.change_maze4.BackColor = System.Drawing.Color.Black;
            this.change_maze4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_maze4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change_maze4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_maze4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.change_maze4.Location = new System.Drawing.Point(596, 678);
            this.change_maze4.Name = "change_maze4";
            this.change_maze4.Size = new System.Drawing.Size(99, 32);
            this.change_maze4.TabIndex = 37;
            this.change_maze4.Text = "Change Maze";
            this.change_maze4.UseVisualStyleBackColor = false;
            this.change_maze4.Click += new System.EventHandler(this.change_maze4_Click);
            // 
            // change_maze6
            // 
            this.change_maze6.BackColor = System.Drawing.Color.Black;
            this.change_maze6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_maze6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change_maze6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_maze6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.change_maze6.Location = new System.Drawing.Point(596, 675);
            this.change_maze6.Name = "change_maze6";
            this.change_maze6.Size = new System.Drawing.Size(99, 32);
            this.change_maze6.TabIndex = 38;
            this.change_maze6.Text = "Change Maze";
            this.change_maze6.UseVisualStyleBackColor = false;
            this.change_maze6.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1176, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1069, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 41;
            this.label4.Text = "Time left:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1251, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "seconds";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(0, 0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 23);
            this.Start.TabIndex = 0;
            // 
            // goal
            // 
            this.goal.Location = new System.Drawing.Point(0, 0);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(100, 23);
            this.goal.TabIndex = 0;
            this.goal.MouseEnter += new System.EventHandler(this.finish_point);
            // 
            // Hard_Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1364, 775);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.change_maze5);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.change_maze6);
            this.Controls.Add(this.change_maze4);
            this.Controls.Add(this.change_maze3);
            this.Controls.Add(this.change_maze2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.Clear_screen);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.Change_maze1);
            this.Controls.Add(this.level4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.level5);
            this.Controls.Add(this.level6);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.goal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hard_Mode";
            this.Text = "Hard_Mode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button change_maze5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button Change_maze1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button level6;
        private System.Windows.Forms.Button level5;
        private System.Windows.Forms.Button level4;
        private System.Windows.Forms.Button level3;
        private System.Windows.Forms.Button level2;
        private System.Windows.Forms.Button Clear_screen;
        private System.Windows.Forms.Button level1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button change_maze2;
        private System.Windows.Forms.Button change_maze3;
        private System.Windows.Forms.Button change_maze4;
        private System.Windows.Forms.Button change_maze6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label goal;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label2;
        
    }
}