using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBtn
{
    public partial class Form1 : Form
    {
        private double valor1, valor2;
        private String sValor1, sValor2, operador;
        /**
         * 0 = Passo 1
         */
        private int fase;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fase = 0;
        }

        private void limpar()
        {
            fase = 0;
            valor1 = 0;
            valor2 = 0;
            txtLabel.Text = "";
        }

        private void inputValue(String digito)
        {
            if (fase == 0)
            {
                sValor1 = sValor1 + digito;
                txtLabel.Text = sValor1;
            }

            if (fase == 1)
            {
                sValor2 = sValor2 + digito;
                txtLabel.Text = sValor2;
            }
        }

        private void inputOperacao(String operador)
        {
            if (fase == 0)
            {
                fase = 1;
                valor1 = Double.Parse(sValor1, CultureInfo.InvariantCulture);
                this.operador = operador;
                txtLabel.Text = "";
            }
        }

        private void calculaResultado()
        {
            double resultado = 0;
            if (fase == 1)
            {
                fase = 0;
                valor2 = Double.Parse(sValor2, CultureInfo.InvariantCulture);
                
                switch (operador)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;
                    case "-":
                        resultado = valor1 - valor2;
                        break;
                    case "*":
                        resultado = valor1 * valor2;
                        break;
                    case "/":
                        resultado = valor1 / valor2;
                        break;
                }

                txtLabel.Text = resultado.ToString();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            inputValue("5");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            inputValue("7");
        }

        private void btn78_Click(object sender, EventArgs e)
        {
            inputValue("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            inputValue("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            inputValue("4");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            inputValue("6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            inputValue("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inputValue("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            inputValue("3");
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            inputOperacao("+");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            inputOperacao("-");
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            inputOperacao("*");
        }

        private void bntIgual_Click(object sender, EventArgs e)
        {
            calculaResultado();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            inputOperacao("/");
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            inputValue(".");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            inputValue("0");
        }
    }
}
