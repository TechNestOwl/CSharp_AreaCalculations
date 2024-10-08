
/*********************************************************

   Gill Guimaraes

   Lab #6 

   I wrote this code myself...
   I did not use AI or copy code from Google or another student

 *********************************************************/



namespace Area
{
    public partial class Form1 : Form
    {
        void ClearAll()
        {
            rectRadio.Checked = false;
            squareRadio.Checked = false;
            circleRadio.Checked = false;
            areaTitle.Text = "Area";

            areaTxtBox.Clear();
            widthTxtBox.Clear();
            topTxtBox.Clear();
        }
        public string calculateRectangle(int arg1, int arg2)
        {
            double area = arg1 * arg2;
            string areaStr = area.ToString();

            return areaStr;
        }
        public string calculateRaidus(int value)
        {
            //calculate area A =  3.14159 * ( value * value );
            double area = (value * value) * 3.14159;
            string result = area.ToString();

            return result;
        }
        public string calculateSqure(int value)
        {
            int areaNum = value * value;
            string area = areaNum.ToString();

            return area; 
        }
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void areaTitle_Click(object sender, EventArgs e)
        {

        }

        private void rectRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (rectRadio.Checked == true)
            {
                Console.WriteLine("rect checked");
                areaTitle.Text = "Rectangle";
                topLabel.Text = "Height";
                widthTxtBox.Visible = true;
                witdthLbl.Visible = true;
            }
        }

        private void squareRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (squareRadio.Checked == true)
            {
                Console.WriteLine("square checked");
                areaTitle.Text = "Square";
                topLabel.Text = "Sides";
                widthTxtBox.Visible = false;
                witdthLbl.Visible = false;
            }
        }


        private void circleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (circleRadio.Checked == true)
            {
                areaTitle.Text = "Circle";
                topLabel.Text = "Radius";
                widthTxtBox.Visible = false;
                witdthLbl.Visible = false;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            // else { do nothing? }  ** Currently working but needs revision. 

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();

        }

        private void areaTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void widthTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void topLabel_Click(object sender, EventArgs e)
        {

        }

        private void topTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {

            //Circle Area
            if (circleRadio.Checked)
            {
                //grabbing user input for radius
                string value = topTxtBox.Text;
                int userInput = int.Parse(value);

                areaTxtBox.Text = calculateRaidus(userInput);
            }
            //Rectangle Area
            if (rectRadio.Checked)
            {
                string hValue = topTxtBox.Text;
                string wValue = widthTxtBox.Text;

                int heightValue = int.Parse(hValue);
                int widthValue = int.Parse(wValue);


                areaTxtBox.Text = calculateRectangle(heightValue,widthValue);
            }
            //Square Area

            if (squareRadio.Checked)
            {
                string sideValue = topTxtBox.Text;
                int side = int.Parse(sideValue);


                areaTxtBox.Text = calculateSqure(side);
            }

        }
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectRadio.Checked = true;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleRadio.Checked = true;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            squareRadio.Checked = true;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rectRadio.Checked = false;
            //squareRadio.Checked = false;
            //circleRadio.Checked = false;
            //areaTitle.Text = "Area";
            //areaTxtBox.Clear();
            //widthTxtBox.Clear();
            //topTxtBox.Clear();


            // simpler than above copy/paste method 
            //clearBtn.PerformClick();

            //redunant code above. 

            //invoking new global function - ClearAll()
            ClearAll();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitBtn.PerformClick();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0){ rectRadio.Checked = true;}
            else if (comboBox1.SelectedIndex == 1) { circleRadio.Checked = true; }
            else if (comboBox1.SelectedIndex == 2) { squareRadio.Checked = true; }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0) { rectRadio.Checked = true; }
            else if (listBox1.SelectedIndex == 1) { squareRadio.Checked = true; }
            else if (listBox1.SelectedIndex == 2) { circleRadio.Checked = true; }

        }
    }
}
