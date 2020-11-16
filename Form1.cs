using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ricochet_Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            animation_timer.Enabled = false;
            animation_timer.Interval = 5; 
            physics_timer.Enabled = false;
            physics_timer.Interval = 10;

            foreach (Control contr in control_panel.Controls)
            {
                contr.
            }

                toolTip1.SetToolTip(gb_warning, 
                "This is discrete collision detection, and it ignores what happens \n" +
                " between the previous and current steps. \n" +
                "For this reason, some collisions might not be detected, \n" +
                "especially for fast moving objects. This issue is known as tunneling.");

            toolTip1.SetToolTip(wrn1,
                "This is discrete collision detection, and it ignores what happens \n" +
                " between the previous and current steps. \n" +
                "For this reason, some collisions might not be detected, \n" +
                "especially for fast moving objects. This issue is known as tunneling.");

            toolTip1.SetToolTip(wrn2,
                "This is discrete collision detection, and it ignores what happens \n" +
                " between the previous and current steps. \n" +
                "For this reason, some collisions might not be detected, \n" +
                "especially for fast moving objects. This issue is known as tunneling.");


            recent_ball_coords[0].X = recent_ball_coords[1].X = recent_ball_coords[2].X = -1;
            recent_ball_coords[0].Y = recent_ball_coords[1].Y = recent_ball_coords[2].Y = -1;

            red_text_stopwatch = new Stopwatch();
        }

        private void animation_timer_Tick(object sender, EventArgs e)
        {
            txb_x_pos.Text = ballCenter().X.ToString();
            txb_y_pos.Text = ballCenter().Y.ToString();

            if (red_text_stopwatch.IsRunning && red_text_stopwatch.Elapsed.TotalSeconds <= redTextDuration)
            {
                lbl_ricochet.ForeColor = Color.Red;               
            }
            else
            {
                lbl_ricochet.ForeColor = Color.Black;
            }

            display_panel.Invalidate();
            control_panel.Invalidate();

        }
        private void physics_timer_Tick(object sender, EventArgs e)
        {

            hasCollided = false;
            if (ball.Location.X + ball.Size.Width >= display_panel.Size.Width || ball.Location.X <= display_panel.Location.X)
            {
                x_vel_normal = -x_vel_normal;
                hasCollided = true;
                red_text_stopwatch.Reset();
                red_text_stopwatch.Start();

            }
            if (ball.Location.Y + ball.Size.Height >= display_panel.Size.Height
                || ball.Location.Y <= 0)
            {
                y_vel_normal = -y_vel_normal;
                hasCollided = true;
                red_text_stopwatch.Reset();
                red_text_stopwatch.Start();

            }

            Point newLoc = new Point(
                (int)(ball.Location.X + (x_vel_normal)),
                (int)(ball.Location.Y + (y_vel_normal)));
            ball.Location = newLoc;
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            // TODO call "verify input" function
            // TODO call actual button success event code in a separate function to be called by verify
            if (isSet)
            {
                hasStarted = false;
                animation_timer.Enabled = false;
                physics_timer.Enabled = false;
                lbl_ricochet.ForeColor = Color.Black;
                red_text_stopwatch.Reset();
            }
            syncTrkb2Txb(sender, e);
            isSet = true;

            getComponentVectors(trackBar1.Value, toRadians(Parse_Direction()), ref x_vel_normal, ref y_vel_normal);
            btn_set.Text = "Reset";
            btn_start.Enabled = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (!hasStarted)
            {
                // ... then move baby, move
                hasStarted = true;
                animation_timer.Enabled = true;
                physics_timer.Enabled = true;
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point ballCenter()
        {
            Point center = new Point();
            center.X = ball.Location.X + (ball.Size.Width / 2);
            center.Y = ball.Location.Y + (ball.Size.Height / 2);
            return center;
        }

        private void getComponentVectors(double Speed, double Direction, ref double x_comp, ref double y_comp)
        {

            x_comp = (Speed * Math.Cos(Direction)) / physics_timer.Interval;
            y_comp = (Speed * Math.Sin(Direction)) / physics_timer.Interval;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Display the trackbar value in the text box.
            txb_speed.Text = "" + trackBar1.Value;
        }

        private void syncTrkb2Txb(object sender, EventArgs e)
        {
            int temp = trackBar1.Value;
            if (txb_speed.TextLength == 0 && trackBar1.Value != 0)
            {
                txb_speed.Text = trackBar1.Value.ToString();
            }
            else if (txb_speed.TextLength == 0)
            {
                txb_speed.Text = "0";
            }
            else if (int.TryParse(txb_speed.Text, out temp)
                && temp != trackBar1.Value
                && temp <= trackBar1.Maximum
                && temp >= trackBar1.Minimum)
            {
                trackBar1.Value = temp;
            }
            else
            {
                txb_speed.Text = trackBar1.Value.ToString();
            }
        }

        private void txb_speed_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                syncTrkb2Txb(sender, e);
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Parse_Direction();
        }

       
        private double Parse_Direction()
        {
            double ret;
            if (double.TryParse(txb_direction.Text, out ret))
            {
                ball_direction = ret;
                return ball_direction;
            }
            else
            {
                return 0.0;
            }
        }

        private double toRadians(double rads)
        {
            return rads * (Math.PI / 180);
        }

        private void display_panel_Paint(object sender, PaintEventArgs e)
        {
           
            
        }
    }
}
