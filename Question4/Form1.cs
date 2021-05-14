using System;
using System.Linq;
using System.Windows.Forms;

namespace Question4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] marks = new int[3];
        int count = 0;

        private int FindHighestMark(int inputOne, int inputTwo, int inputThree)
        {
            int highestMark = marks.Max();
            return highestMark;
        }

        private int CalcAverage(int inputOne, int inputTwo, int inputThree)
        {
            int averageMark = (inputOne + inputTwo + inputThree) / marks.Length;
            return averageMark;
        }
        private string Category(int input)
        {
            string message = string.Empty;

            if (input < 40)
            {
                message = input + " "  +  "Failed";
            }
            if (input >= 40 && input < 50)
            {
                message = input + " " + "Supplementary.";
            }
            if (input >= 50 && input < 75)
            {
                message = input + " " + "Passed.";
            }
            if (input >= 75)
            {
                message = input + " " + "Passed with Distinction.";
            }

            return message;
        }

        private void Display(int averageMark, int highestMark)
        {

            string message = string.Empty;

            message = Category(marks[0]);
            string firstLine = "Individual Assignment Mark:" + ' ' + message + Environment.NewLine;

            message = Category(marks[1]);
            string secondLine = "Test Mark:" + ' ' + message + Environment.NewLine;

            message = Category(marks[2]);
            string thirdLine = "Group Assignment Mark:" +  " " + message + Environment.NewLine;

            string fourthLine = "The highest mark is:" + " " + highestMark + Environment.NewLine;


            string fifthLine = "Average mark is:" + " " + averageMark + Environment.NewLine;

            txtResults.Text = firstLine + secondLine + thirdLine + fourthLine + fifthLine;
        }

        private void btnNextMark_Click(object sender, EventArgs e)
        {
            int inputMark = Convert.ToInt32(txtMark.Text);

            if(inputMark > 100 || inputMark < 0 )
            {
                MessageBox.Show("Your Input Number Must between 0 and 100 ", "Error", MessageBoxButtons.OK);
                txtMark.Text = "";
                return;
            }

            switch (lblMarkHeading.Text)
            {
                case "Individual Assignment":
                    marks[0] = inputMark;
                    lblMarkHeading.Text = "Test Marks";
                    txtMark.Text = "";
                    break;
                case "Test Marks":
                    marks[1] = inputMark;
                    lblMarkHeading.Text = "Group Assignment";
                    txtMark.Text = "";
                    break;
                case "Group Assignment":
                    marks[2] = inputMark;
                    txtMark.Text = "";
                    btnNextMark.Enabled = false;
                    txtMark.Enabled = false;
                    btnDisplay.Enabled = true;
                    break;
                default:
                    txtMark.Text = "";
                    lblMarkHeading.Text = "Individual Assesment";
                    break;
            }       
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int highestMark = 0;
            int averageMark = 0;

            averageMark = CalcAverage(marks[0], marks[1], marks[2]);

            highestMark = FindHighestMark(marks[0], marks[1], marks[2]);

            Display(averageMark, highestMark);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDisplay.Enabled = false;
        }
    }
}
