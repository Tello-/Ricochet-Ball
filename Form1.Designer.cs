using System;
using System.Diagnostics;
using System.Drawing;

namespace Ricochet_Ball
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.display_panel = new System.Windows.Forms.Panel();
            this.header_panel = new System.Windows.Forms.Panel();
            this.lbl_ball = new System.Windows.Forms.Label();
            this.lbl_ricochet = new System.Windows.Forms.Label();
            this.control_panel = new System.Windows.Forms.Panel();
            this.gb_warning = new System.Windows.Forms.GroupBox();
            this.wrn1 = new System.Windows.Forms.Label();
            this.wrn2 = new System.Windows.Forms.Label();
            this.txb_direction = new System.Windows.Forms.TextBox();
            this.txb_speed = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_quit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_y_pos = new System.Windows.Forms.TextBox();
            this.txb_x_pos = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.physics_timer = new System.Windows.Forms.Timer(this.components);
            this.animation_timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ball = new System.Windows.Forms.Button();
            this.display_panel.SuspendLayout();
            this.header_panel.SuspendLayout();
            this.control_panel.SuspendLayout();
            this.gb_warning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // display_panel
            // 
            this.display_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.display_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display_panel.Controls.Add(this.ball);
            this.display_panel.Location = new System.Drawing.Point(0, 50);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(600, 600);
            this.display_panel.TabIndex = 0;
            this.display_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.display_panel_Paint);
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.LightGray;
            this.header_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_panel.Controls.Add(this.lbl_ball);
            this.header_panel.Controls.Add(this.lbl_ricochet);
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(600, 50);
            this.header_panel.TabIndex = 1;
            // 
            // lbl_ball
            // 
            this.lbl_ball.AutoSize = true;
            this.lbl_ball.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ball.Location = new System.Drawing.Point(340, 9);
            this.lbl_ball.Name = "lbl_ball";
            this.lbl_ball.Size = new System.Drawing.Size(74, 37);
            this.lbl_ball.TabIndex = 0;
            this.lbl_ball.Text = "Ball";
            // 
            // lbl_ricochet
            // 
            this.lbl_ricochet.AutoSize = true;
            this.lbl_ricochet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ricochet.Location = new System.Drawing.Point(186, 9);
            this.lbl_ricochet.Name = "lbl_ricochet";
            this.lbl_ricochet.Size = new System.Drawing.Size(148, 37);
            this.lbl_ricochet.TabIndex = 0;
            this.lbl_ricochet.Text = "Ricochet";
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.control_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.control_panel.Controls.Add(this.gb_warning);
            this.control_panel.Controls.Add(this.txb_direction);
            this.control_panel.Controls.Add(this.txb_speed);
            this.control_panel.Controls.Add(this.trackBar1);
            this.control_panel.Controls.Add(this.btn_quit);
            this.control_panel.Controls.Add(this.label4);
            this.control_panel.Controls.Add(this.btn_start);
            this.control_panel.Controls.Add(this.label3);
            this.control_panel.Controls.Add(this.label2);
            this.control_panel.Controls.Add(this.txb_y_pos);
            this.control_panel.Controls.Add(this.txb_x_pos);
            this.control_panel.Controls.Add(this.btn_set);
            this.control_panel.Controls.Add(this.label1);
            this.control_panel.Location = new System.Drawing.Point(0, 650);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(600, 154);
            this.control_panel.TabIndex = 2;
            // 
            // gb_warning
            // 
            this.gb_warning.Controls.Add(this.wrn1);
            this.gb_warning.Controls.Add(this.wrn2);
            this.gb_warning.Location = new System.Drawing.Point(173, 104);
            this.gb_warning.Name = "gb_warning";
            this.gb_warning.Size = new System.Drawing.Size(241, 43);
            this.gb_warning.TabIndex = 11;
            this.gb_warning.TabStop = false;
            // 
            // wrn1
            // 
            this.wrn1.AutoSize = true;
            this.wrn1.Location = new System.Drawing.Point(8, 10);
            this.wrn1.Name = "wrn1";
            this.wrn1.Size = new System.Drawing.Size(217, 13);
            this.wrn1.TabIndex = 10;
            this.wrn1.Text = "Warning: High Speeds may cause tunneling!";
            // 
            // wrn2
            // 
            this.wrn2.AutoSize = true;
            this.wrn2.Location = new System.Drawing.Point(19, 25);
            this.wrn2.Name = "wrn2";
            this.wrn2.Size = new System.Drawing.Size(194, 13);
            this.wrn2.TabIndex = 10;
            this.wrn2.Text = "(Reset app if ball tunnels out of bounds)";
            // 
            // txb_direction
            // 
            this.txb_direction.AcceptsReturn = true;
            this.txb_direction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txb_direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txb_direction.Location = new System.Drawing.Point(234, 27);
            this.txb_direction.Name = "txb_direction";
            this.txb_direction.Size = new System.Drawing.Size(72, 30);
            this.txb_direction.TabIndex = 9;
            this.txb_direction.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // txb_speed
            // 
            this.txb_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txb_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txb_speed.Location = new System.Drawing.Point(369, 70);
            this.txb_speed.Name = "txb_speed";
            this.txb_speed.Size = new System.Drawing.Size(65, 30);
            this.txb_speed.TabIndex = 8;
            this.txb_speed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_speed_KeyUp);
            this.txb_speed.Leave += new System.EventHandler(this.syncTrkb2Txb);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(176, 84);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(194, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_quit
            // 
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_quit.Location = new System.Drawing.Point(12, 104);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(75, 40);
            this.btn_quit.TabIndex = 5;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y";
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_start.Location = new System.Drawing.Point(12, 58);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 40);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(208, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direction(deg)";
            // 
            // txb_y_pos
            // 
            this.txb_y_pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txb_y_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.txb_y_pos.Location = new System.Drawing.Point(539, 9);
            this.txb_y_pos.Name = "txb_y_pos";
            this.txb_y_pos.ReadOnly = true;
            this.txb_y_pos.Size = new System.Drawing.Size(57, 40);
            this.txb_y_pos.TabIndex = 3;
            // 
            // txb_x_pos
            // 
            this.txb_x_pos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txb_x_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.txb_x_pos.Location = new System.Drawing.Point(452, 9);
            this.txb_x_pos.Name = "txb_x_pos";
            this.txb_x_pos.ReadOnly = true;
            this.txb_x_pos.Size = new System.Drawing.Size(57, 40);
            this.txb_x_pos.TabIndex = 3;
            // 
            // btn_set
            // 
            this.btn_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_set.Location = new System.Drawing.Point(12, 12);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 40);
            this.btn_set.TabIndex = 2;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(213, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speed(px/s)";
            // 
            // physics_timer
            // 
            this.physics_timer.Tick += new System.EventHandler(this.physics_timer_Tick);
            // 
            // animation_timer
            // 
            this.animation_timer.Tick += new System.EventHandler(this.animation_timer_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ball.FlatAppearance.BorderSize = 0;
            this.ball.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ball.ForeColor = System.Drawing.Color.Transparent;
            this.ball.Location = new System.Drawing.Point(187, 150);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 802);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.display_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.display_panel.ResumeLayout(false);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            this.gb_warning.ResumeLayout(false);
            this.gb_warning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel display_panel;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Timer physics_timer;
        private System.Windows.Forms.Timer animation_timer;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_y_pos;
        private System.Windows.Forms.TextBox txb_x_pos;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_set;


        private double ball_direction;

        private Point[] recent_ball_coords = new Point[3];
        private double x_vel_normal;
        private double y_vel_normal;

        private bool isSet = false;
        private bool hasStarted = false;

        private bool hasCollided = false;

        private Stopwatch red_text_stopwatch;
        private double redTextDuration = 0.25;


        

        private System.Windows.Forms.TextBox txb_speed;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txb_direction;
        private System.Windows.Forms.Button ball;
        private System.Windows.Forms.Label lbl_ricochet;
        private System.Windows.Forms.Label wrn2;
        private System.Windows.Forms.Label wrn1;
        private System.Windows.Forms.GroupBox gb_warning;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_ball;
    }
}

