using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {

        Double value = 0;
        string operetion = "";
        bool oper = false;
        public Form1()
        {
            InitializeComponent();
        }

       

     
        private void Num(object sender, EventArgs e)
        {
            if (textBox1.Text=="0"||oper)
            
                textBox1.Clear();

            oper = false;
            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void Clea(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operetions(object sender, EventArgs e)
        {
                try
            {

            Button b = (Button)sender;
            operetion = b.Text;
            value = Double.Parse(textBox1.Text);
            oper = true;
            Blabel.Text = value + " " + operetion;
               
            }
            catch
            {
                MessageBox.Show("error!\n Ввыдите сначало число!");
            }

        }
        private void Result_Click(object sender, EventArgs e)
        {
           
            switch (operetion)
            {
                case "+":textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();break;
                case "-": textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString(); break;
                case "*": textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString(); break;
                case "%": textBox1.Text = (value * Double.Parse(textBox1.Text)/100).ToString(); break;
                case " √": textBox1.Text = (Math.Sqrt(value)).ToString(); break;
               
                default:
                    break;
            }
        }

        private void CleanAll_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            value = 0;
        }

     
    }
}
