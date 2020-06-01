using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        int primero;
        int segundo;
        int resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void cero_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "0";
        }

        private void uno_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "6";

        }

        private void siete_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "7";

        }

        private void ocho_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "8";

        }

        private void nueve_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "9";

        }

        private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = int.Parse(texto.Text);
            texto.Clear();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = int.Parse(texto.Text);
            texto.Clear();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = int.Parse(texto.Text);
            texto.Clear();
        }

        private void division_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = int.Parse(texto.Text);
            texto.Clear();
        }
        private void borrar_Click(object sender, EventArgs e)
        {
            texto.Clear();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            segundo = int.Parse(texto.Text);
            switch (operacion)
            {

                case "+":
                    resultado = primero + segundo;
                    texto.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    texto.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    texto.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    texto.Text = resultado.ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void borrar_Click_1(object sender, EventArgs e)
        {
            texto.Clear();
        }
    }
}
