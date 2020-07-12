using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gravity
{
    public partial class frmMain : Form
    {
        int x=365;
        int y=88;
        double speed = 1;
        bool invert=false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            

        }

        private void tmrMovement_Tick(object sender, EventArgs e)
        {
            

            if (y >= 324 && !(speed<=0))
            {
                invert = true;
            }
            else if (speed <= 0 || y >= 324)
            {
                invert = false;
            }

            if (invert)
            {
                speed=speed - 0.155;
                y = Convert.ToInt32(y - speed);
            }
            else if (!invert)
            {
                speed = speed + 0.098;
                y = Convert.ToInt32(y + speed);
            }

            lblY.Text = Convert.ToString(y);
            lblX.Text = Convert.ToString(x);
            lblV.Text = Convert.ToString(speed);

            pbBall.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 365;
            y = 88;
            speed = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
