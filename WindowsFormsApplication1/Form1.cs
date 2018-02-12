using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            p.WaitForInputIdle();
        }


        private void computeLuminaires()
        {
            var length = numLuminairesLength.Value;
            var width = numLuminairesWidth.Value;
            var lumens = numLuminairesLumens.Value;
            var lamps = numLuminanceLamps.Value;
            var cu = numLuminairesCU.Value;
            var mf = numLuminairesMF.Value;
            var illumination = numLuminairesIllumination.Value;

            var top = length * width * illumination;
            var bottom = lamps * lumens * cu * mf;

            if (bottom == 0)
            {
                MessageBox.Show("One of the parameters is zero. Please check and retry.", "Error");
                bottom = 1;
                top = 0;
            }

            var luminaires = top / bottom;

            textLuminairesOutput.Text = luminaires.ToString("#.##");

        }

        private void computeIllumination()
        {
            var length = numIllumLength.Value;
            var width = numIllumWidth.Value;
            var lumens = numIllumLumens.Value;
            var cu = numIllumCU.Value;
            var mf = numIllumMF.Value;

            var top = lumens * cu;
            var bottom = length * width;

            if (bottom == 0)
            {
                MessageBox.Show("One of the parameters is zero. Please check and retry.", "Error");
                bottom = 1;
                top = 0;
            }

            var initial = top / bottom;
            var maintained = initial * mf;

            textIllumOutputInit.Text = initial.ToString("#.##");
            textIllumOutputMaintained.Text = maintained.ToString("#.##");

        }

        private void computeLuminance()
        {
            var length = numLuminanceLength.Value;
            var width = numLuminanceWidth.Value;
            var lumens = numLuminanceLumens.Value;
            var lamps = numLuminanceLamps.Value;
            var tf = numLuminanceTF.Value;

            var top = lamps * lumens * tf;
            var bottom = length * width;

            if (bottom == 0)
            {
                MessageBox.Show("One of the parameters is zero. Please check and retry.", "Error");
                bottom = 1;
                top = 0;
            }

            var luminance = top / bottom;

            textLuminanceOutput.Text = luminance.ToString("#.##");

        }

        double _PI = Math.PI;

        private void computeTwo()
        {
            var length = numTwoLength.Value;
            var width = numTwoWidth.Value;
            var height = numTwoHeight.Value;
            var lumens = numTwoLumens.Value;

            double fourpi = 4 * _PI;
            double i = (double)lumens / (double)fourpi;
            length = length / 2;
            width = width / 2;
            var ratio = length / height;
            var atan = Math.Atan((double)ratio);
            double cosine = Math.Cos((double)atan);
            double top = (double)i * (double)cosine;

            length = length * length;
            width = width * width;
            var bottom = length + width;

            if (bottom == 0)
            {
                MessageBox.Show("One of the parameters is zero. Please check and retry.", "Error");
                bottom = 1;
                top = 0;
            }

            double two = (double)top / (double)bottom;

            textTwoOutput.Text = two.ToString("#.##");

        }

        private void computeThree()
        {
            var length = numThreeLength.Value;
            var width = numThreeWidth.Value;
            var height = numThreeHeight.Value;
            var lumens = numThreeLumens.Value;

            double fourpi = 4 * _PI;
            double i = (double)lumens / (double)fourpi;
            double top = (double)i * (double)height;

            var halflength = length / 2;
            halflength = halflength * halflength;
            var halfwidth = width / 2;
            halfwidth = halfwidth * halfwidth;
            height = height * height;
            var square = height + halfwidth + halflength;
            double bottom = Math.Pow((double)square, (double)1.5);

            if (bottom == 0)
            {
                MessageBox.Show("One of the parameters is zero. Please check and retry.", "Error");
                bottom = 1;
                top = 0;
            }

            double three = (double)top / (double)bottom;

            textThreeOutput.Text = three.ToString("#.##");

        }

        private void computeCavity()
        {

            var length = numCavityLength.Value;
            var width = numCavityWidth.Value;
            var rh = numCavityRH.Value;
            var h = rh;
            var wph = numCavityWPH.Value;
            var cch = numCavityCCH.Value;
            var fch = wph;
            var rch = rh - fch;
            rch = rch - cch;

            if (comboCavity.SelectedIndex == 0)
            {
                h = rh;
            }
            if (comboCavity.SelectedIndex == 1)
            {
                h = rch;
            }
            if (comboCavity.SelectedIndex == 2)
            {
                h = cch;
            }
            if (comboCavity.SelectedIndex == 3)
            {
                h = fch;
            }

            var lw = length + width;
            var top = 5 * h * lw;
            var bottom = length * width;

            if (bottom == 0)
            {
                MessageBox.Show("One of the parameters is zero. Please check and retry.", "Error");
                bottom = 1;
                top = 0;
            }

            var cavity = top / bottom;

            textCavityOutput.Text = cavity.ToString("#.##");

        }
        
        private void buttonIllumCalculate_Click(object sender, EventArgs e)
        {
            computeIllumination();
        }


        private void buttonLuminairesCalculate_Click(object sender, EventArgs e)
        {
            computeLuminaires();
        }

        private void buttonLuminanceCalculate_Click(object sender, EventArgs e)
        {
            computeLuminance();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            computeThree();
        }

        private void buttonLuminanceCalculate_Click_1(object sender, EventArgs e)
        {
            computeLuminance();
        }
        private void buttonTwoCalculate(object sender, EventArgs e)
        {
            computeTwo();
        }

        private void buttonCavityCalculate_Click(object sender, EventArgs e)
        {
            computeCavity();
        }

        #region nonuseful


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rdbEnglish_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }


        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }


      


        #endregion

        private void rdbMetric_Click(object sender, EventArgs e)
        {
            lb11.Text = "meters";
            lb12.Text = "meters";
            lb14.Text = "lux";
            lb21.Text = "meters";
            lb22.Text = "meters";
            lb24.Text = "lux";
            lb25.Text = "lux";
            lb31.Text = "meters";
            lb32.Text = "meters";
            lb34.Text = "mLambert";
            lb41.Text = "meters";
            lb42.Text = "meters";
            lb43.Text = "meters";
            lb45.Text = "lux";
            lb51.Text = "meters";
            lb52.Text = "meters";
            lb53.Text = "meters";
            lb55.Text = "meters";
            lb61.Text = "meters";
            lb62.Text = "meters";
            lb63.Text = "meters";
            lb64.Text = "meters";
            lb65.Text = "meters";

        }

        private void rdbEnglish_Click(object sender, EventArgs e)
        {
            lb11.Text = "feet";
            lb12.Text = "feet";
            lb14.Text = "feet";
            lb21.Text = "feet";
            lb22.Text = "feet";
            lb24.Text = "fc";
            lb25.Text = "fc";
            lb31.Text = "feet";
            lb32.Text = "feet";
            lb34.Text = "ftLambert";
            lb41.Text = "feet";
            lb42.Text = "feet";
            lb43.Text = "feet";
            lb45.Text = "fc";
            lb51.Text = "feet";
            lb52.Text = "feet";
            lb53.Text = "feet";
            lb55.Text = "feet";
            lb61.Text = "feet";
            lb62.Text = "feet";
            lb63.Text = "feet";
            lb64.Text = "feet";
            lb65.Text = "feet";
        }

    }
}
