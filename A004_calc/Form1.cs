using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A004_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNO1.Text =="" || txtNO2.Text == "") {
                MessageBox.Show("두개의 숫자를 입력해주세요");
                return;
            }
            
            double num1 = double.Parse(txtNO1.Text);
            double num2 = double.Parse(txtNO2.Text);
            double result = num1 + num2;
            lblresult.Text = "(+)결과";
            txtResult.Text = result.ToString();
        }

        private void lblresult_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtNO1.Text == "" || txtNO2.Text == "")
            {
                MessageBox.Show("두개의 숫자를 입력해주세요");
                return;
            }
            double num1 = double.Parse(txtNO1.Text);
            double num2 = double.Parse(txtNO2.Text);
            double result = num1 / num2;
            lblresult.Text = "(/)결과";
            txtResult.Text = result.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNO1.Text == "" || txtNO2.Text == "")
            {
                MessageBox.Show("두개의 숫자를 입력해주세요");
                return;
            }
            double num1 = double.Parse(txtNO1.Text);
            double num2 = double.Parse(txtNO2.Text);
            double result = num1 * num2;
            lblresult.Text = "(*)결과";
            txtResult.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNO1.Text == "" || txtNO2.Text == "")
            {
                MessageBox.Show("두개의 숫자를 입력해주세요");
                return;
            }
            double num1 = double.Parse(txtNO1.Text);
            double num2 = double.Parse(txtNO2.Text);
            double result = num1 - num2;
            lblresult.Text = "(-)결과";
            txtResult.Text = result.ToString();
        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnumber2_Click(object sender, EventArgs e)
        {

        }

        private void lblnumber1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
