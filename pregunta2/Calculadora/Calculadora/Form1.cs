//YURIKA MACUSAYA AGUILAR CI:13846755LP PREGUNTA 2
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculadora{
    public partial class Form1 : Form{        
        private double resultado;
        public Form1()
        {
            InitializeComponent();
        }
        public double getResultado() { 
            return resultado;
        }
        public void setResultado(double res) { 
            resultado = res;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "9";
        }
        private void buttonIgual_Click(object sender, EventArgs e)
        {

            //int num_var = Int32.Parse(tbDisplay.Text);
            //tbDisplay.Text = num_var.ToString(); 
            try
            {
                string expresion = tbDisplay.Text;
                char[] delimiterChars = { '+', '-', '*', '/' };

                string text = expresion;
                System.Console.WriteLine($"Original text: '{text}'");
                //string[] words = text.Split(delimiterChars);            
                string[] words = text.Split();
                System.Console.WriteLine($"{words.Length} words2 in text:");
                double val1 = 0;
                double val2 = 0;
                double resu = 0;
                int c = 0;
                System.Console.WriteLine($" para *");
                for (int r = 0; r < words.Length; r++) { System.Console.Write($"[ {words[r]} ]"); }
                System.Console.WriteLine();
                System.Console.WriteLine($"hasta :{words.Length - 1}");
                for (int i = 0; i < words.Length - 1; i++)
                {
                    System.Console.WriteLine($"i:{i} , i+1 {i + 1}=[{words[i + 1]}]");
                    if (words[i + 1] == "x")
                    {
                        System.Console.WriteLine($"  i::{i}");
                        c++;
                        val1 = double.Parse(words[i]);
                        System.Console.WriteLine($" ____ {words[i + 2]}");
                        if (words[i + 2].Equals("")) {
                            System.Console.WriteLine($" break");
                            tbDisplay.Text = "intrduzca expresion";
                            break;
                        }
                        val2 = double.Parse(words[i + 2]);
                        resu = val1 * val2;
                        words[i] = resu.ToString();
                        int ne = words.Length - 1;
                        int p = i + 1;
                        for (int j = 1; j <= 2; j++)
                        {
                            for (int k = p; k < ne; k++)
                            {
                                words[k] = words[k + 1];
                            }
                            foreach (var item in words) { System.Console.Write($"[  {item} ]"); }
                            System.Console.WriteLine();
                        }
                        System.Console.WriteLine($"  i:::{i}");
                        i = i - 1;
                        System.Console.WriteLine($"  i:::{i}");
                    }
                }

                foreach (var item in words) { System.Console.Write($" {item} "); }
                System.Console.WriteLine();
                System.Console.WriteLine($" para / ");
                int tam = words.Length - (2 * c);
                val1 = 0;
                val2 = 0;
                resu = 0;
                c = 0;
                System.Console.WriteLine($"tam: {tam} ");
                string[] words2 = new string[tam];
                for (int r = 0; r < tam; r++) { words2[r] = words[r]; System.Console.Write($"[ {words2[r]} ]"); }
                System.Console.WriteLine();
                for (int i = 0; i < words2.Length - 1; i++)
                {
                    System.Console.WriteLine($"i:{i} , i+1 {i + 1}=[{words2[i + 1]}]");
                    if (words2[i + 1] == "/")
                    {
                        c++;
                        val1 = double.Parse(words2[i]);
                        if (words2[i + 2].Equals(""))
                        {
                            System.Console.WriteLine($" break");
                            tbDisplay.Text = "intrduzca expresion";
                            break;
                        }
                        val2 = double.Parse(words2[i + 2]);
                        resu = val1 / val2;
                        words2[i] = resu.ToString();
                        int ne = words2.Length - 1;
                        int p = i + 1;
                        for (int j = 1; j <= 2; j++)
                        {
                            for (int k = p; k < ne; k++)
                            {
                                words2[k] = words2[k + 1];
                            }
                        }
                        i = i - 1;
                    }
                }
                foreach (var item in words2) { System.Console.Write($" {item} "); }
                System.Console.WriteLine();

                System.Console.WriteLine($" para - ");
                tam = words2.Length - (2 * c);
                val1 = 0;
                val2 = 0;
                resu = 0;
                c = 0;
                System.Console.WriteLine($"tam: {tam} ");
                string[] words3 = new string[tam];
                for (int r = 0; r < tam; r++) { words3[r] = words2[r]; System.Console.Write($"[ {words3[r]} ]"); }
                System.Console.WriteLine();
                for (int i = 0; i < words3.Length - 1; i++)
                {
                    if (words3[i + 1] == "-")
                    {
                        c++;
                        val1 = double.Parse(words3[i]);
                        if (words3[i + 2].Equals(""))
                        {
                            System.Console.WriteLine($" break");
                            tbDisplay.Text = "intrduzca expresion";
                            break;
                        }
                        val2 = double.Parse(words3[i + 2]);
                        resu = val1 - val2;

                        words3[i] = resu.ToString();
                        System.Console.WriteLine($"resu[]:{words3[i]}");
                        int ne = words3.Length - 1;
                        int p = i + 1;
                        for (int j = 1; j <= 2; j++)
                        {
                            for (int k = p; k < ne; k++)
                            {
                                words3[k] = words3[k + 1];
                            }
                        }
                        i = i - 1;
                    }
                }
                foreach (var item in words3) { System.Console.Write($" {item} "); }
                System.Console.WriteLine();

                System.Console.WriteLine($" para + ");
                tam = words3.Length - (2 * c);
                val1 = 0;
                val2 = 0;
                resu = 0;
                c = 0;
                System.Console.WriteLine($"tam: {tam} ");
                string[] words4 = new string[tam];
                for (int r = 0; r < tam; r++) { words4[r] = words3[r]; System.Console.Write($"[ {words4[r]} ]"); }
                //System.Console.WriteLine($"{words4.Length-1}, {words4[0 + 1]}");

                for (int x = 0; x < words4.Length - 1; x++)
                {
                    if (words4[x + 1] == "+")
                    {
                        System.Console.WriteLine($"es +");
                        c++;
                        val1 = double.Parse(words4[x]);
                        if (words4[x + 2].Equals(""))
                        {
                            System.Console.WriteLine($" break");
                            tbDisplay.Text = "intrduzca expresion";
                            break;
                        }
                        val2 = double.Parse(words4[x + 2]);
                        resu = val1 + val2;
                        words4[x] = resu.ToString();
                        System.Console.WriteLine($" resu: {resu}");
                        int ne = words4.Length - 1;
                        int p = x + 1;
                        for (int j = 1; j <= 2; j++)
                        {
                            for (int k = p; k < ne; k++)
                            {
                                words4[k] = words4[k + 1];
                            }
                        }
                        x = x - 1;
                    }
                }

                string grr = words4[0];
                System.Console.WriteLine($"grr {grr}");
                if (grr != "")
                {
                    setResultado(double.Parse(grr));
                    tbDisplay.Text += " = "+getResultado().ToString();
                }
                else
                {
                    tbDisplay.Text = "intrduzca expresion";
                }
            }
            catch (Exception error){                
                throw error;
                tbDisplay.Text = "intrduzca expresion";
            }
        }
        
        private void buttonPunto_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += ".";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += " + ";
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += " - ";
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += " x ";
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += " / ";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
        }

        
    }
}
