using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Calculator
{
    public partial class calnew1 : Form
    {
        
        double FirstNumber;
        string Operation; 
        public calnew1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtvalue.Text = txtvalue.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0" && txtvalue.Text != null)
            {
                txtvalue.Text = "1";
            }
            else
            {
                txtvalue.Text = txtvalue.Text + "1";
            }  
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0" && txtvalue.Text != null)
            {
                txtvalue.Text = "2";
            }
            else
            {
                txtvalue.Text = txtvalue.Text + "2";
            }  
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0" && txtvalue.Text != null)
            {
                txtvalue.Text = "3";
            }
            else
            {
                txtvalue.Text = txtvalue.Text + "3";
            }  
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0" && txtvalue.Text != null)
            {
                txtvalue.Text = "4";
            }
            else
            {
                txtvalue.Text = txtvalue.Text + "4";
            }  
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0" && txtvalue.Text != null)
            {
                txtvalue.Text = "5";
            }
            else
            {
                txtvalue.Text = txtvalue.Text + "5";
            }  
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0" && txtvalue.Text != null)
            {
                txtvalue.Text = "6";
            }
            else
            {
                txtvalue.Text = txtvalue.Text + "6";
            }  
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0" && txtvalue.Text != null)
            {
                txtvalue.Text = "7";
            }
            else
            {
                txtvalue.Text = txtvalue.Text + "7";
            }  
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0" && txtvalue.Text != null)
            {
                txtvalue.Text = "8";
            }
            else
            {
                txtvalue.Text = txtvalue.Text + "8";
            }  
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtvalue.Text == "0" && txtvalue.Text != null)
            {
                txtvalue.Text = "9";
            }
            else
            {
                txtvalue.Text = txtvalue.Text + "9";
            }  
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
                txtvalue.Text = " ";
        }

        private void cmdadd_Click(object sender, EventArgs e)
        {
            double FirstNumber = Convert.ToDouble(txtvalue.Text);
            txtvalue.Text = " ";
            Operation = " + ";              
        }

        private void cmdequal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

             SecondNumber = Convert.ToDouble(txtvalue.Text);

            if (Operation == " + ")
            {
                Result = (FirstNumber + SecondNumber);
                txtvalue.Text = Convert.ToString(Result);
                FirstNumber = Result;

            }
            if (Operation == " * ")
            {
                Result = (FirstNumber * SecondNumber);
                txtvalue.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == " % ")
            {
                if (FirstNumber != 0 && SecondNumber == null)
                {
                    Result = (FirstNumber / 100);
                    txtvalue.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == " / ")
            {
                if(SecondNumber==0)
                {
                    txtvalue.Text = "Invalid operation";   
                }
                else
                {
                Result = (FirstNumber / SecondNumber);
                txtvalue.Text = Convert.ToString(Result);
                FirstNumber = Result;
                }
            }
            if ( Operation == " - ")
            {
                Result = (FirstNumber - SecondNumber);
                txtvalue.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            txtvalue.Text = Convert.ToString(FirstNumber);
        }

        private void cmdmultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtvalue.Text);
            txtvalue.Text = " ";
            Operation = " * ";  
        }

        private void cmdsubstract_Click(object sender, EventArgs e)
        {      
            FirstNumber = Convert.ToDouble(txtvalue.Text);
            txtvalue.Text = " ";
            Operation = " - ";  
        }

        private void cmdpresentage_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtvalue.Text);
            txtvalue.Text = " ";
            Operation = " % ";  
        }

        private void cmddevided_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtvalue.Text);
            txtvalue.Text = " ";
            Operation = " / ";  
        }






    }
}
