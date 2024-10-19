namespace FibonacciApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox listBoxFibonacci;

        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.listBoxFibonacci = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Oblicz liczby Fibonacciego";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // listBoxFibonacci
            // 
            this.listBoxFibonacci.FormattingEnabled = true;
            this.listBoxFibonacci.Location = new System.Drawing.Point(12, 41);
            this.listBoxFibonacci.Name = "listBoxFibonacci";
            this.listBoxFibonacci.Size = new System.Drawing.Size(160, 147);
            this.listBoxFibonacci.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(632, 401);
            this.Controls.Add(this.listBoxFibonacci);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Fibonacci App";
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
