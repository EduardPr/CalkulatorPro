namespace OOPCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Ctan = new System.Windows.Forms.Button();
            this.Arctan = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.Arith = new System.Windows.Forms.Button();
            this.Geom = new System.Windows.Forms.Button();
            this.Remainder = new System.Windows.Forms.Button();
            this.Expow = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Log2 = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.XPowY = new System.Windows.Forms.Button();
            this.XPow1DivisionY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(298, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(540, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(28, 114);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Calculate);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(208, 113);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(75, 23);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Calculate);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(459, 113);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(75, 23);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Calculate);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(689, 113);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Calculate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первый аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второй аргумент";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат";
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(28, 170);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 10;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(352, 170);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 11;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(109, 170);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(75, 23);
            this.Tan.TabIndex = 12;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(190, 170);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(75, 23);
            this.Arcsin.TabIndex = 13;
            this.Arcsin.Text = "Arcsin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(271, 170);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(75, 23);
            this.Arccos.TabIndex = 14;
            this.Arccos.Text = "Arccos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Ctan
            // 
            this.Ctan.Location = new System.Drawing.Point(433, 170);
            this.Ctan.Name = "Ctan";
            this.Ctan.Size = new System.Drawing.Size(75, 23);
            this.Ctan.TabIndex = 15;
            this.Ctan.Text = "Ctan";
            this.Ctan.UseVisualStyleBackColor = true;
            this.Ctan.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Arctan
            // 
            this.Arctan.Location = new System.Drawing.Point(514, 170);
            this.Arctan.Name = "Arctan";
            this.Arctan.Size = new System.Drawing.Size(75, 23);
            this.Arctan.TabIndex = 16;
            this.Arctan.Text = "Arctan";
            this.Arctan.UseVisualStyleBackColor = true;
            this.Arctan.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(596, 170);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(75, 23);
            this.Min.TabIndex = 17;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Calculate);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(689, 169);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(75, 23);
            this.Max.TabIndex = 18;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Calculate);
            // 
            // Arith
            // 
            this.Arith.Location = new System.Drawing.Point(28, 200);
            this.Arith.Name = "Arith";
            this.Arith.Size = new System.Drawing.Size(75, 23);
            this.Arith.TabIndex = 19;
            this.Arith.Text = "Arith";
            this.Arith.UseVisualStyleBackColor = true;
            this.Arith.Click += new System.EventHandler(this.Calculate);
            // 
            // Geom
            // 
            this.Geom.Location = new System.Drawing.Point(109, 200);
            this.Geom.Name = "Geom";
            this.Geom.Size = new System.Drawing.Size(75, 23);
            this.Geom.TabIndex = 20;
            this.Geom.Text = "Geom";
            this.Geom.UseVisualStyleBackColor = true;
            this.Geom.Click += new System.EventHandler(this.Calculate);
            // 
            // Remainder
            // 
            this.Remainder.Location = new System.Drawing.Point(190, 200);
            this.Remainder.Name = "Remainder";
            this.Remainder.Size = new System.Drawing.Size(75, 23);
            this.Remainder.TabIndex = 21;
            this.Remainder.Text = "Remainder";
            this.Remainder.UseVisualStyleBackColor = true;
            this.Remainder.Click += new System.EventHandler(this.Calculate);
            // 
            // Expow
            // 
            this.Expow.Location = new System.Drawing.Point(271, 199);
            this.Expow.Name = "Expow";
            this.Expow.Size = new System.Drawing.Size(75, 23);
            this.Expow.TabIndex = 22;
            this.Expow.Text = "Expow";
            this.Expow.UseVisualStyleBackColor = true;
            this.Expow.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(352, 200);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(75, 23);
            this.Ln.TabIndex = 23;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Log2
            // 
            this.Log2.Location = new System.Drawing.Point(433, 199);
            this.Log2.Name = "Log2";
            this.Log2.Size = new System.Drawing.Size(75, 23);
            this.Log2.TabIndex = 24;
            this.Log2.Text = "Log2";
            this.Log2.UseVisualStyleBackColor = true;
            this.Log2.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(514, 199);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(75, 23);
            this.Log10.TabIndex = 25;
            this.Log10.Text = "Log10";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(595, 199);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(75, 23);
            this.Pow.TabIndex = 26;
            this.Pow.Text = "Pow";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.OneArgumentCalculate);
            // 
            // XPowY
            // 
            this.XPowY.Location = new System.Drawing.Point(689, 198);
            this.XPowY.Name = "XPowY";
            this.XPowY.Size = new System.Drawing.Size(75, 23);
            this.XPowY.TabIndex = 27;
            this.XPowY.Text = "XPowY";
            this.XPowY.UseVisualStyleBackColor = true;
            this.XPowY.Click += new System.EventHandler(this.Calculate);
            // 
            // XPow1DivisionY
            // 
            this.XPow1DivisionY.Location = new System.Drawing.Point(28, 229);
            this.XPow1DivisionY.Name = "XPow1DivisionY";
            this.XPow1DivisionY.Size = new System.Drawing.Size(75, 23);
            this.XPow1DivisionY.TabIndex = 28;
            this.XPow1DivisionY.Text = "XPow1DivisionY";
            this.XPow1DivisionY.UseVisualStyleBackColor = true;
            this.XPow1DivisionY.Click += new System.EventHandler(this.Calculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.XPow1DivisionY);
            this.Controls.Add(this.XPowY);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.Log2);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Expow);
            this.Controls.Add(this.Remainder);
            this.Controls.Add(this.Geom);
            this.Controls.Add(this.Arith);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Arctan);
            this.Controls.Add(this.Ctan);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Ctan;
        private System.Windows.Forms.Button Arctan;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Arith;
        private System.Windows.Forms.Button Geom;
        private System.Windows.Forms.Button Remainder;
        private System.Windows.Forms.Button Expow;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button Log2;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.Button XPowY;
        private System.Windows.Forms.Button XPow1DivisionY;
    }
}

