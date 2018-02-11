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

        private void numIllumLength_ValueChanged(object sender, EventArgs e)
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
            var luminaires = top * bottom;

            textLuminairesOutput.Text = luminaires.ToString();

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
            var initial = top / bottom;
            var maintained = initial * mf;

            textIllumOutputInit.Text = initial.ToString();
            textIllumOutputMaintained.Text = maintained.ToString();

        }

        private void buttonLuminairesCalculate_Click(object sender, EventArgs e)
        {
            computeLuminaires();
        }
    }
}
