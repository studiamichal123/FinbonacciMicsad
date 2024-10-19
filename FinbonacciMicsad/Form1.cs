using System;
using System.Windows.Forms;

namespace FibonacciApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();  // Czyszczenie listy
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add($"F{i} = {Fibonacci(i)}");
            }
        }
    }
}
