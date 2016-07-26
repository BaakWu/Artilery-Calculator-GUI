using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artilery_Computer
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) //button takes user inputs and outputs distance and bearing
        {
            int angleC;
            int AT;
            int bearing;
            int angBR;
            angleC = ArmaMath.findAngle(int.Parse(bearingToT.Text), int.Parse(bearingToS.Text));
            AT = ArmaMath.lawOfCos(angleC, int.Parse(disFromT.Text), int.Parse(disFromS.Text));
            disFromStoT.Text = AT.ToString();
            angBR = ArmaMath.lawofcosA(int.Parse(disFromT.Text), int.Parse(disFromS.Text), AT);
            bearing = ArmaMath.angleCalcShoot(int.Parse(bearingToT.Text), int.Parse(bearingToS.Text), angBR);
            bearFromStoT.Text = bearing.ToString();

        }
        private void bearingToT_Validating(object sender, CancelEventArgs e) //validation to ensure only correct inputs are made to box
        {
            if (string.IsNullOrWhiteSpace(bearingToT.Text))
            {
                bearingToT.Text = "0";
            }
            int ToT = int.Parse(bearingToT.Text);
            if (ToT > 360)
                ToT = ToT % 360;
            bearingToT.Text = ToT.ToString();
            if (ToT < 0)
                ToT = 0;
            bearingToT.Text = ToT.ToString();
        }

        private void bearingToS_Validating(object sender, CancelEventArgs e) //validation to ensure only correct inputs are made to box
        {
            if (string.IsNullOrWhiteSpace(bearingToS.Text))
            {
                bearingToS.Text = "0";
            }
            int ToS = int.Parse(bearingToS.Text);
            if (ToS > 360)
                ToS = ToS % 360;
            bearingToS.Text = ToS.ToString();
            if (ToS < 0)
                ToS = 0;
            bearingToS.Text = ToS.ToString();

        }
        private void disFromT_Validating(object sender, CancelEventArgs e) //validation to ensure box is not left null
        {
            if (string.IsNullOrWhiteSpace(bearingToT.Text))
            {
                bearingToT.Text = "0";
            }
        }

        private void disFromS_Validating(object sender, CancelEventArgs e) //validation to ensure box is not left null
        {
            if (string.IsNullOrWhiteSpace(bearingToT.Text))
            {
                bearingToT.Text = "0";
            }
        }

        private void bearingToT_KeyPress(object sender, KeyPressEventArgs e) //ensures only integer inputs are made
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void disFromT_KeyPress(object sender, KeyPressEventArgs e) //ensures only integer inputs are made
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bearingToS_KeyPress(object sender, KeyPressEventArgs e) //ensures only integer inputs are made
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void disFromS_KeyPress(object sender, KeyPressEventArgs e) //ensures only integer inputs are made
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}

