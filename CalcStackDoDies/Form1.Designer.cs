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
            this.Plus.Click += new System.EventHandler(this.Button_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(148, 140);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(75, 23);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Button_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(148, 190);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 2;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Button_Click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(34, 190);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(75, 23);
            this.Mul.TabIndex = 3;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Button_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}

