using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunchoke
{
    public partial class Form1 : Form
    {

        //https://hort.purdue.edu/newcrop/afcm/jerusart.html   what the sunchoke is typical characteristics of the plant

        //https://food.unl.edu/documents/Horticultural%20Crops%20Weights%20and%20Measures.pdf  this has the pounds per bushel which is (48 pounds per bushel)

        //https://www.researchgate.net/figure/Chemical-composition-of-Jerusalem-artichoke-tubers-as-dry-weight_tbl1_287403828  6.8% this is the moisture content of the sunchoke

        public Form1()
        {
            InitializeComponent();
        }
        /*
            Calculating Bushels/acre To calculate bushels per acre the basic formula is: 
 
            Bushels/acre = (Harvested dry matter lbs) ÷ Standard lbs/bushel ÷ plot area acres  or Yield = “A” lbs ÷ “B” lbs/bushel ÷ “C” acres 

                
            Calculating “A” 
 
            “A” lbs  = [ (100 – measured % moisture) * 0.01) ]  x  [harvest weight] 


            Calculating “B” 
 
            “B” lbs/bushel = [(100 – standard % moisture)* 0.01]  x   standard bushel weight (lbs)  
 
            The standard bushel weight of corn is 56 lbs/bushel.  Corn has a decimal % moisture of 0.155 when a bushel of corn weighs 56 pounds. The standard bushel weight of soybeans is 60 lbs/bushel. 
            
            Beans have a decimal % moisture of 0.13 when a bushel of beans weighs 60lbs. 
 
            Therefore for corn:  “B” lbs/bushel = (1 – 0.155) * (56 lbs/bushel) And for soybeans:   “B” lbs/bushel = (1 – 0.130) * (60 lbs/bushel) 
 
 

            Calculating “C” 
 
            “C” is the plot area in acres. “C” = (plot width ft) * (plot length ft) / 43560 ft2/acre 
 
            For WQFS:  the plot width is 30 ft and the plot length is 160 ft. 
 
            The resulting formula: 
 
            WQFS corn yield bu/acre =  {[(100 - %moisture) * 0.01] * [harvest weight]} / {[56 * (1 – 0.155)]} / {(30 * 160) / 43560} 


        He's not kidding: the average sunchoke tuber weighs about three ounces, or 85 grams; if it's 30 percent inulin, that's 25 grams of the gas-maker right there, already over the daily clinical dose



        https://modernfarmer.com/2018/02/jerusalem-artichoke-sunchoke-recipe-prevents-gas/#:~:text=He's%20not%20kidding%3A%20the%20average,over%20the%20daily%20clinical%20dose.



         */

        private void Form1_Load(object sender, EventArgs e)
        {
            // we have to calculate the formula 
            // the formula goes 
            // Yield = “A” lbs ÷ “B” lbs/bushel ÷ “C” acres 
            /* 
             * finding A
             * to find the pounds [(100- 6.8 ) * 0.01] x ( how many pounds sunchoke)
             * 
             * Finding B
             * to find the pounds per bushel [(100- 6.8) * 0.01] x 48]
             * 
             * Finding C
             * to find the area in acres
             * C = (plot width ft) * (plot length ft) / 43560 ft^2/acre 
             * 
             */

            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // we have to calculate the formula 
            // the formula goes 
            // Yield = “A” lbs ÷ “B” lbs/bushel ÷ “C” acres 
            /* 
             * finding A
             * to find the pounds [(100- 6.8 ) * 0.01] x ( how many pounds sunchoke)
             * 
             * Finding B
             * to find the pounds per bushel [(100- 6.8) * 0.01] x 48]
             * 
             * Finding C
             * to find the area in acres
             * C = (plot width ft) * (plot length ft) / 43560 ft^2/acre 
             * 
             */

            //https://www.investopedia.com/terms/c/crop-yield.asp

            // these are the variables for the main parts in the formula
            double pounds, poundsperbushel, area , areainacres, output , currentprice;

            // constant variables
            double moisturecontent = 6.8;
            double standardweight = 48;

            //user input
            double weight = 100; // baseline number for no user input;
            double length = 100;
            double width = 100;


            //////////////////////////////////////////////////////////////////////////////////////
            ///Weight////////////////////////////////////////////////////////////////////////////
            

            if (txtweight.Text.Equals("")) //if you left the years empty
            {
                DialogResult blankErrorWeight = MessageBox.Show("Weight has been left blank. " +
                    "Weight is HAS BEEN set to 100.", "Missing weight ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (blankErrorWeight == DialogResult.OK)
                {
                    weight = 100.0;
                }
            }
            else if (txtweight.Text.StartsWith("-")) // negative year check
            {
                DialogResult negativeErrorWeight = MessageBox.Show("Weight has been given a NEGATIVE NUMBER. " +
                    "Weight is HAS BEEN set to 100.", "Number of Years NEGATIVE NUMBER ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (negativeErrorWeight == DialogResult.OK)
                {
                    weight = 100.0;
                }
            }
            else
            {
                bool isDouble = Double.TryParse(txtweight.Text, out weight); // non number input. 
                if (isDouble)
                {
                    weight = Convert.ToDouble(txtweight.Text);  // years shouldnt be negative.
                }
                else
                {
                    DialogResult incorrectInputErrorWeight = MessageBox.Show("Weight has been given an incorrect Input. " +
                        "You entered " + txtweight.Text + "Weight is HAS BEEN set to 100.", "Weight NEGATIVE NUMBER ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (incorrectInputErrorWeight == DialogResult.OK)
                    {
                        weight = 100.0;
                    }
                }
            }



            //////////////////////////////////////////////////////////////////////////////////////
            ///length////////////////////////////////////////////////////////////////////////////

            if (txtlength.Text.Equals("")) //if you left the years empty
            {
                DialogResult blankErrorlength = MessageBox.Show("Length has been left blank. " +
                    "Length is HAS BEEN set to 100.", "Missing Length ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (blankErrorlength == DialogResult.OK)
                {
                    length = 100.0;
                }
            }
            else if (txtlength.Text.StartsWith("-")) // negative year check
            {
                DialogResult negativeErrorlength = MessageBox.Show("Length has been given a NEGATIVE NUMBER. " +
                    "Length is HAS BEEN set to 100.", "Length NEGATIVE NUMBER ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (negativeErrorlength == DialogResult.OK)
                {
                    length = 100.0;
                }
            }
            else
            {
                bool isDouble = Double.TryParse(txtlength.Text, out length); // non number input. 
                if (isDouble)
                {
                    length = Convert.ToDouble(txtlength.Text);  // years shouldnt be negative.
                }
                else
                {
                    DialogResult incorrectInputErrorlength = MessageBox.Show("Length has been given an incorrect Input. " +
                        "You entered " + txtlength.Text + "Length is HAS BEEN set to 100.", "Length NEGATIVE NUMBER ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (incorrectInputErrorlength == DialogResult.OK)
                    {
                        length = 100.0;
                    }
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////
            ///width////////////////////////////////////////////////////////////////////////////

            if (txtwidth.Text.Equals("")) //if you left the years empty
            {
                DialogResult blankErrorwidth = MessageBox.Show("width has been left blank. " +
                    "Length is HAS BEEN set to 100.", "Missing Length ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (blankErrorwidth == DialogResult.OK)
                {
                    width = 100.0;
                }
            }
            else if (txtwidth.Text.StartsWith("-")) // negative year check
            {
                DialogResult negativeErrorwidth = MessageBox.Show("Length has been given a NEGATIVE NUMBER. " +
                    "Length is HAS BEEN set to 100.", "Length NEGATIVE NUMBER ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (negativeErrorwidth == DialogResult.OK)
                {
                    width = 100.0;
                }
            }
            else
            {
                bool isDouble = Double.TryParse(txtwidth.Text, out width); // non number input. 
                if (isDouble)
                {
                    width = Convert.ToDouble(txtwidth.Text);  // years shouldnt be negative.
                }
                else
                {
                    DialogResult incorrectInputErrorwidth = MessageBox.Show("Length has been given an incorrect Input. " +
                        "You entered " + txtlength.Text + "Length is HAS BEEN set to 100.", "Length NEGATIVE NUMBER ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (incorrectInputErrorwidth == DialogResult.OK)
                    {
                        width = 100.0;
                    }
                }
            }

            double drymatterratio = ((100 - moisturecontent) * 0.01); //[(100- 6.8 ) * 0.01] x ( how many pounds sunchoke) 
            double weightwwater = (weight * moisturecontent) * 0.01;

            weight = weightwwater + weight;

            label3.Text = drymatterratio.ToString();

            pounds = drymatterratio * weight;

            label4.Text = pounds.ToString();

            double poundsperbushelratio = ((100 - moisturecontent) * 0.01);
            poundsperbushel = poundsperbushelratio * standardweight;

            label5.Text = poundsperbushel.ToString();
            label6.Text = length.ToString();
            label7.Text = width.ToString();

            area = length * width;
            areainacres = area / 43560;

            label8.Text = area.ToString();
            label9.Text = areainacres.ToString();

            //output = pounds / poundsperbushel / areainacres;

            double outputpdp = pounds / poundsperbushel;

            output = outputpdp / areainacres;

            label10.Text = output.ToString();

            label20.Text = DateTime.Now.ToString();

            currentprice = 20;

            Random rnd = new Random();
            int current = rnd.Next(20, 23);


            label22.Text = current.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
