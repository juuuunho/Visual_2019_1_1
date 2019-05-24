using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A005_calcurator
{
    public partial class Form1 : Form
    {
        private bool opFlag;   
        double saved;
        char op;
        

        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnDot_Click(object sender, EventArgs e)
        {
            
            if (txtResult.Text.Contains(".") == false)
            {
                txtResult.Text = txtResult.Text + ".";
            }
 
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            double v = double.Parse(txtResult.Text);
            double r = 0;

            switch (op)
            {
                case '+':
                    r = saved + v;
                    break;
                case '-':
                    r = saved - v;
                    break;
                case '×':
                    r = saved * v;
                    break;
                case '÷':
                    r = saved / v;
                    break;
            }
            txtResult.Text = r.ToString();
        }
        //숫자버튼 0~9까지를 클릭했을 때 실행되는 이벤트 처리 메서드
        private void Number_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            Button btn = sender as Button;
            string no = btn.Text; 
            if (txtResult.Text == "0" || opFlag == true)
            {
                txtResult.Text = no;
                opFlag = false;
            }
            else
                txtResult.Text += no;
        }

        private void Op_Click(object sender, EventArgs e)
        {
            opFlag = true;
            saved = double.Parse(txtResult.Text);

            Button btn = sender as Button;
            if (btn.Text == "+")
                op = '+';
            else if (btn.Text == "-")
                op = '-';
            else if (btn.Text == "×")
                op = '×';
            else if (btn.Text == "÷")
                op = '÷';
        }
    }
}