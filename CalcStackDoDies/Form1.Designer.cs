namespace CalcStackDoDies
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
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Ctan = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.In = new System.Windows.Forms.Button();
            this.Sqr = new System.Windows.Forms.Button();
            this.Twoinx = new System.Windows.Forms.Button();
            this.Modul = new System.Windows.Forms.Button();
            this.Onedivx = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Arctan = new System.Windows.Forms.Button();
            this.Log2 = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.teninx = new System.Windows.Forms.Button();
            this.minusx = new System.Windows.Forms.Button();
            this.Singrad = new System.Windows.Forms.Button();
            this.Cosgrad = new System.Windows.Forms.Button();
            this.Arcsingrad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(34, 140);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 23);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.TwoArgumentButtonClick);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(148, 140);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 23);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.TwoArgumentButtonClick);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(148, 190);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 2;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.TwoArgumentButtonClick);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(34, 190);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(75, 23);
            this.Mul.TabIndex = 3;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.TwoArgumentButtonClick);
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(34, 60);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(189, 20);
            this.Input2.TabIndex = 4;
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(34, 34);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(189, 20);
            this.Input1.TabIndex = 5;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(34, 86);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(189, 20);
            this.Result.TabIndex = 6;
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(549, 34);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 7;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(549, 64);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 8;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(549, 94);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(75, 23);
            this.Tan.TabIndex = 9;
            this.Tan.Text = "Tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Ctan
            // 
            this.Ctan.Location = new System.Drawing.Point(549, 124);
            this.Ctan.Name = "Ctan";
            this.Ctan.Size = new System.Drawing.Size(75, 23);
            this.Ctan.TabIndex = 10;
            this.Ctan.Text = "Ctan";
            this.Ctan.UseVisualStyleBackColor = true;
            this.Ctan.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(549, 154);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(75, 23);
            this.Exp.TabIndex = 11;
            this.Exp.Text = "Exp";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(630, 35);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(75, 23);
            this.In.TabIndex = 12;
            this.In.Text = "In";
            this.In.UseVisualStyleBackColor = true;
            this.In.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Sqr
            // 
            this.Sqr.Location = new System.Drawing.Point(630, 64);
            this.Sqr.Name = "Sqr";
            this.Sqr.Size = new System.Drawing.Size(75, 23);
            this.Sqr.TabIndex = 13;
            this.Sqr.Text = "x^2";
            this.Sqr.UseVisualStyleBackColor = true;
            this.Sqr.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Twoinx
            // 
            this.Twoinx.Location = new System.Drawing.Point(630, 94);
            this.Twoinx.Name = "Twoinx";
            this.Twoinx.Size = new System.Drawing.Size(75, 23);
            this.Twoinx.TabIndex = 14;
            this.Twoinx.Text = "2^x";
            this.Twoinx.UseVisualStyleBackColor = true;
            this.Twoinx.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Modul
            // 
            this.Modul.Location = new System.Drawing.Point(631, 124);
            this.Modul.Name = "Modul";
            this.Modul.Size = new System.Drawing.Size(75, 23);
            this.Modul.TabIndex = 15;
            this.Modul.Text = "|x|";
            this.Modul.UseVisualStyleBackColor = true;
            this.Modul.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Onedivx
            // 
            this.Onedivx.Location = new System.Drawing.Point(631, 154);
            this.Onedivx.Name = "Onedivx";
            this.Onedivx.Size = new System.Drawing.Size(75, 23);
            this.Onedivx.TabIndex = 16;
            this.Onedivx.Text = "1\\x";
            this.Onedivx.UseVisualStyleBackColor = true;
            this.Onedivx.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(292, 30);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(75, 23);
            this.Arcsin.TabIndex = 17;
            this.Arcsin.Text = "Arcsin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(292, 64);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(75, 23);
            this.Arccos.TabIndex = 18;
            this.Arccos.Text = "Arccos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Arctan
            // 
            this.Arctan.Location = new System.Drawing.Point(292, 93);
            this.Arctan.Name = "Arctan";
            this.Arctan.Size = new System.Drawing.Size(75, 23);
            this.Arctan.TabIndex = 19;
            this.Arctan.Text = "Arctan";
            this.Arctan.UseVisualStyleBackColor = true;
            this.Arctan.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Log2
            // 
            this.Log2.Location = new System.Drawing.Point(292, 124);
            this.Log2.Name = "Log2";
            this.Log2.Size = new System.Drawing.Size(75, 23);
            this.Log2.TabIndex = 20;
            this.Log2.Text = "Log2";
            this.Log2.UseVisualStyleBackColor = true;
            this.Log2.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(292, 154);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(75, 23);
            this.Log10.TabIndex = 21;
            this.Log10.Text = "Log10";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // teninx
            // 
            this.teninx.Location = new System.Drawing.Point(388, 30);
            this.teninx.Name = "teninx";
            this.teninx.Size = new System.Drawing.Size(75, 23);
            this.teninx.TabIndex = 22;
            this.teninx.Text = "10^x";
            this.teninx.UseVisualStyleBackColor = true;
            this.teninx.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // minusx
            // 
            this.minusx.Location = new System.Drawing.Point(388, 64);
            this.minusx.Name = "minusx";
            this.minusx.Size = new System.Drawing.Size(75, 23);
            this.minusx.TabIndex = 23;
            this.minusx.Text = "-x";
            this.minusx.UseVisualStyleBackColor = true;
            this.minusx.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Singrad
            // 
            this.Singrad.Location = new System.Drawing.Point(388, 92);
            this.Singrad.Name = "Singrad";
            this.Singrad.Size = new System.Drawing.Size(75, 23);
            this.Singrad.TabIndex = 24;
            this.Singrad.Text = "Singrad";
            this.Singrad.UseVisualStyleBackColor = true;
            this.Singrad.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Cosgrad
            // 
            this.Cosgrad.Location = new System.Drawing.Point(388, 124);
            this.Cosgrad.Name = "Cosgrad";
            this.Cosgrad.Size = new System.Drawing.Size(75, 23);
            this.Cosgrad.TabIndex = 25;
            this.Cosgrad.Text = "Cosgrad";
            this.Cosgrad.UseVisualStyleBackColor = true;
            this.Cosgrad.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Arcsingrad
            // 
            this.Arcsingrad.Location = new System.Drawing.Point(388, 153);
            this.Arcsingrad.Name = "Arcsingrad";
            this.Arcsingrad.Size = new System.Drawing.Size(75, 23);
            this.Arcsingrad.TabIndex = 26;
            this.Arcsingrad.Text = "Arcsingrad";
            this.Arcsingrad.UseVisualStyleBackColor = true;
            this.Arcsingrad.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 261);
            this.Controls.Add(this.Arcsingrad);
            this.Controls.Add(this.Cosgrad);
            this.Controls.Add(this.Singrad);
            this.Controls.Add(this.minusx);
            this.Controls.Add(this.teninx);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.Log2);
            this.Controls.Add(this.Arctan);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Onedivx);
            this.Controls.Add(this.Modul);
            this.Controls.Add(this.Twoinx);
            this.Controls.Add(this.Sqr);
            this.Controls.Add(this.In);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Ctan);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Ctan;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button In;
        private System.Windows.Forms.Button Sqr;
        private System.Windows.Forms.Button Twoinx;
        private System.Windows.Forms.Button Modul;
        private System.Windows.Forms.Button Onedivx;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Arctan;
        private System.Windows.Forms.Button Log2;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button teninx;
        private System.Windows.Forms.Button minusx;
        private System.Windows.Forms.Button Singrad;
        private System.Windows.Forms.Button Cosgrad;
        private System.Windows.Forms.Button Arcsingrad;
    }
}

