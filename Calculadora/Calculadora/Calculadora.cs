using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
            double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();
        Clases.ClsPorcentaje1 obj5 = new Clases.ClsPorcentaje1();





        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Entre_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            double Suma;
            double Resta;
            double Div;
            double Porc;
            double Mult;
            switch (operador)
            {
                case "+":
                    Suma = obj.Sumar((primero), (segundo));
                    
                    pantalla.Text = Suma.ToString();
                    break;
                case "-":
                    Resta = obj2.Restar((primero), (segundo));
                    pantalla.Text = Resta.ToString();
                    break;
                case "*":
                    Div = obj3.Multiplicar((primero), (segundo));
                    pantalla.Text = Div.ToString();
                    break;
                case "/":
                    Mult = obj4.Dividir((primero), (segundo));
                    pantalla.Text = Mult.ToString();
                    break;
                case "%":
                    Porc = obj5.Porcentaje((primero), (segundo));
                    pantalla.Text = Porc.ToString();
                    break;
            }
        }

        private void Porcentaje_Click(object sender, EventArgs e)
        {
            operador = "%";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void C_Click(object sender, EventArgs e)
        {
            if(pantalla.Text.Length==1)
            {
                pantalla.Text = "";
            }
            else
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
            }
        }
    }
}
