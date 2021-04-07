using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {


        double n1, n2, aux;
        string sinal = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void ResetaTb()
        {
            textBox1.Text = "0";
        }

        public void AtualizaLabel()
        {
            label1.Text = n1.ToString() + " " + sinal + " " + n2.ToString() + " =";
            textBox1.Text = aux.ToString();
        }

        public void VerificaSinal()
        {
            if (sinal != "")
            {
                btnIgual.PerformClick();
            }

        }

        public void MudaSinal(string op)
        {
            if (sinal == "")
            {
                sinal = op;
                n1 = double.Parse(textBox1.Text);

            }
            else
            {
                sinal = op;
            }
        }

        public void AddTb(string num)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = num;
            }
            else
            {
                textBox1.Text = textBox1.Text + num;
            }
        }

        public void Conta()
        {
            switch (sinal)
            {
                case "+":
                    aux = n1 + n2;
                    break;
                case "-":
                    aux = n1 - n2;
                    break;
                case "x":
                    aux = n1 * n2;
                    break;
                case "/":
                    aux = n1 / n2;
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((n1 / 100) * double.Parse(textBox1.Text)).ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ResetaTb();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if (textBox1.Text.Length == 0)
                {
                    ResetaTb();
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            n1 = 1;
            n2 = double.Parse(textBox1.Text);
            sinal = "/";
            Conta();
            AtualizaLabel();

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            AddTb("0");
        }


        private void Button17_Click(object sender, EventArgs e)
        {
            AddTb("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            AddTb("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            AddTb("3");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            AddTb("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            AddTb("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            AddTb("6");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            AddTb("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            AddTb("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            AddTb("9");
        }

        private void BtnAdc_Click(object sender, EventArgs e)
        {
            VerificaSinal();
           
            MudaSinal("+");
            label1.Text = n1.ToString() + " " + sinal;
            ResetaTb();

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            VerificaSinal();
            

            MudaSinal("-");

            label1.Text = n1.ToString() + " " + sinal;
            ResetaTb();
        }

        private void BtnMtp_Click(object sender, EventArgs e)
        {
            VerificaSinal();

            MudaSinal("x");

            label1.Text = n1.ToString() + " " + sinal;
            ResetaTb();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            VerificaSinal();
            

            MudaSinal("/");

            label1.Text = n1.ToString() + " " + sinal;
            ResetaTb();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            ResetaTb();
            label1.Text = "";
            sinal = "";
            n1 = 0;
            n2 = 0;
            aux = 0;
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (sinal != "") { 
            if (label1.Text.Contains("=") == false)
            {
                n2 = double.Parse(textBox1.Text);

            }
            Conta();
            AtualizaLabel();
            n1 = aux;
        }
        }

        private void BtnX2_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(textBox1.Text);
            n1 = n2;
            sinal = "x";
            Conta();
            AtualizaLabel();
        }

        private void Btnsqrt_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            aux = Math.Sqrt(n1);
            label1.Text = "sqrt(" + n1.ToString() + ") =";
            textBox1.Text = aux.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.D0:
                    btn0.PerformClick();
                    break;
                case (char)Keys.D1:
                    btn1.PerformClick();
                    break;
                case (char)Keys.D2:
                    btn2.PerformClick();
                    break;
                case (char)Keys.D3:
                    btn3.PerformClick();
                    break;
                case (char)Keys.D4:
                    btn4.PerformClick();
                    break;
                case (char)Keys.D5:
                    btn5.PerformClick();
                    break;
                case (char)Keys.D6:
                    btn6.PerformClick();
                    break;
                case (char)Keys.D7:
                    btn7.PerformClick();
                    break;
                case (char)Keys.D8:
                    btn8.PerformClick();
                    break;
                case (char)Keys.D9:
                    btn9.PerformClick();
                    break;
                case (char)47:
                    btnDiv.PerformClick();
                    break;
                case (char)43:
                    btnAdc.PerformClick();
                    break;
                case (char)45:
                    btnSub.PerformClick();
                    break;
                case (char)42:
                    btnMtp.PerformClick();
                    break;
                case (char)Keys.Enter:
                    btnIgual.PerformClick();
                    break;
                case (char)Keys.Back:
                    btnDEL.PerformClick();
                    break;
                case (char)Keys.Escape:
                    btnC.PerformClick();
                    break;
                case (char)46:
                    btnVirgula.PerformClick();
                    break;
            }
        }

        private void BtnSinal_Click(object sender, EventArgs e)
        {
            aux = double.Parse(textBox1.Text);
            aux = aux * -1;
            textBox1.Text = aux.ToString();
        }

        private void Btnponto_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Contains(",") == false)
            {
                textBox1.Text = textBox1.Text + ",";
            }


        }

    }
}