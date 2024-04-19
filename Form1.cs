using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator_MitRao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long OperandOne = 0;
        private long OperandTwo = 0;

        private void ResizeImageForButton(Button TargetButton, string ImagePath)
        {
            Image OriginalImage = Image.FromFile(ImagePath);

            //button width and height
            int TargetButtonWidth = TargetButton.Width;
            int TargetButtonHeight = TargetButton.Height;

            float AspectRatio = (float)OriginalImage.Width / OriginalImage.Height;

            // Calculate new height based on the aspect ratio
            int NewHeight = (int)(TargetButtonWidth / AspectRatio);

            // Resize the image
            Bitmap ResizedImage = new Bitmap(OriginalImage, TargetButtonWidth, NewHeight);

            TargetButton.Image = ResizedImage;
            TargetButton.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.ResizeImageForButton((Button)this.Controls["delete"], "C:\\Users\\sit436\\Pictures\\remove.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            MainOutputLabel.Text = "0";
        }

        private void OnBtnZeroClick(object sender, EventArgs e)
        {
            if (MainOutputLabel.Text != "0")
            {
                MainOutputLabel.Text += 0;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            MainOutputLabel.Text = "0";
            SubOutputLabel.Text = "0";
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            if(MainOutputLabel.Text == "0")
            {
                MainOutputLabel.Text = "1";
            }
            else
            {
                MainOutputLabel.Text += "1";
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (MainOutputLabel.Text == "0")
            {
                MainOutputLabel.Text = "2";
            }
            else
            {
                MainOutputLabel.Text += "2";
            }
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (MainOutputLabel.Text == "0")
            {
                MainOutputLabel.Text = "3";
            }
            else
            {
                MainOutputLabel.Text += "3";
            }
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (MainOutputLabel.Text == "0")
            {
                MainOutputLabel.Text = "4";
            }
            else
            {
                MainOutputLabel.Text += "4";
            }
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (MainOutputLabel.Text == "0")
            {
                MainOutputLabel.Text = "5";
            }
            else
            {
                MainOutputLabel.Text += "5";
            }
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (MainOutputLabel.Text == "0")
            {
                MainOutputLabel.Text = "6";
            }
            else
            {
                MainOutputLabel.Text += "6";
            }
        }

        private void BtnSevem_Click(object sender, EventArgs e)
        {
            if (float.Parse(MainOutputLabel.Text) == 0)
            {
                MainOutputLabel.Text = "7";
            }
            else
            {
                MainOutputLabel.Text += "7";
            }
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            if (float.Parse(MainOutputLabel.Text) == 0)
            {
                MainOutputLabel.Text = "8";
            }
            else
            {
                MainOutputLabel.Text += "8";
            }
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (float.Parse(MainOutputLabel.Text) == 0)
            {
                MainOutputLabel.Text = "9";
            }
            else
            {
                MainOutputLabel.Text += "9";
            }
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (MainOutputLabel.Text.Contains("."))
            {
                return;
            }
            else
            {
                MainOutputLabel.Text += ".";
            }
        }

        private void BtnPveNve_Click(object sender, EventArgs e)
        {
            if(float.Parse(MainOutputLabel.Text) != 0 && !MainOutputLabel.Text.StartsWith("-"))
            {
                MainOutputLabel.Text = "-" + MainOutputLabel.Text;
            }
            else
            {
                if (MainOutputLabel.Text.StartsWith("-"))
                {
                    MainOutputLabel.Text = MainOutputLabel.Text.Substring(1);
                }
            }
        }

        private void OnRemove(object sender, EventArgs e)
        {
           if(MainOutputLabel.Text.Length == 1)
            {
                MainOutputLabel.Text = "0";
            }
            else
            {
                MainOutputLabel.Text = MainOutputLabel.Text.Substring(0, MainOutputLabel.Text.Length - 1);
            }
        }

        private void OnAddition(object sender, EventArgs e)
        {
            if(!(MainOutputLabel.Text == OperandOne.ToString()) && OperandTwo == 0)
            {
                this.OperandOne += Convert.ToInt64(MainOutputLabel.Text);
                SubOutputLabel.Text = OperandOne.ToString() + "+";
            }
        }
    }
}
