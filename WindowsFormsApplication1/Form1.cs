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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void buttonIllumCalculate_Click(object sender, EventArgs e)
        {
            computeIllumination();
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

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
            
            if( bottom == 0){
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


        private void computeTwo()
        {
            var length = numTwoLength.Value;
            var width = numTwoWidth.Value;
            var height = numTwoHeight.Value;
            var lumens = numTwoLumens.Value;

            decimal p = 3.14159265M;
            double pi = (double)p;
            double fourpi = 4 * pi;
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

            decimal p = 3.14159265M;
            double pi = (double)p;
            double fourpi = 4 * pi;
            double i = (double)lumens / (double)fourpi;
            double top = (double)i * (double)height;

            var halflength = length / 2;
            halflength = halflength * halflength;
            var halfwidth = width / 2;
            halfwidth = halfwidth * halfwidth;
            height = height * height;
            var square = height + halfwidth + halflength;
            double bottom = Math.Pow((double)square,(double)1.5);

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

            if ( h != 0)
            {
                h = rh;
            }
            if ( h != 0)
            {
                h = rch;
            }
            if ( h != 0)
            {
                h = cch;
            }
            if ( h != 0)
            {
                h = fch;
            }

            var lw = length + width;
            var top = h * lw;
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

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void buttonCavityCalculate_Click(object sender, EventArgs e)
        {
            computeCavity();
        }
                
        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void comboCavity_Click(object sender, EventArgs e)
        {

        }



    }
}
