namespace MultidimensionalOptimization_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GradientDescent = new System.Windows.Forms.Button();
            this.X1 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.FastestGradient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DescentOfTheSecondOrder = new System.Windows.Forms.Button();
            this.FletcherReevesMethod = new System.Windows.Forms.Button();
            this.ModifiedNewtonsMethod = new System.Windows.Forms.Button();
            this.Iterations = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 0;
            // 
            // GradientDescent
            // 
            this.GradientDescent.Location = new System.Drawing.Point(37, 53);
            this.GradientDescent.Name = "GradientDescent";
            this.GradientDescent.Size = new System.Drawing.Size(133, 47);
            this.GradientDescent.TabIndex = 1;
            this.GradientDescent.Text = "Градиентный спуск";
            this.GradientDescent.UseVisualStyleBackColor = true;
            this.GradientDescent.Click += new System.EventHandler(this.GradientDescent_Click);
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Location = new System.Drawing.Point(314, 28);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(28, 15);
            this.X1.TabIndex = 2;
            this.X1.Text = "0.00";
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Location = new System.Drawing.Point(314, 70);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(28, 15);
            this.X2.TabIndex = 3;
            this.X2.Text = "0.00";
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(314, 106);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(28, 15);
            this.F.TabIndex = 4;
            this.F.Text = "0.00";
            // 
            // FastestGradient
            // 
            this.FastestGradient.Location = new System.Drawing.Point(37, 106);
            this.FastestGradient.Name = "FastestGradient";
            this.FastestGradient.Size = new System.Drawing.Size(133, 47);
            this.FastestGradient.TabIndex = 5;
            this.FastestGradient.Text = "Наискорейший градиентный спуск";
            this.FastestGradient.UseVisualStyleBackColor = true;
            this.FastestGradient.Click += new System.EventHandler(this.FastestGradient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "X1 - ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "X2 - ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "F - ";
            // 
            // DescentOfTheSecondOrder
            // 
            this.DescentOfTheSecondOrder.Location = new System.Drawing.Point(37, 159);
            this.DescentOfTheSecondOrder.Name = "DescentOfTheSecondOrder";
            this.DescentOfTheSecondOrder.Size = new System.Drawing.Size(133, 47);
            this.DescentOfTheSecondOrder.TabIndex = 9;
            this.DescentOfTheSecondOrder.Text = "Ускоренный спуск второго порядка;";
            this.DescentOfTheSecondOrder.UseVisualStyleBackColor = true;
            this.DescentOfTheSecondOrder.Click += new System.EventHandler(this.DescentOfTheSecondOrder_Click);
            // 
            // FletcherReevesMethod
            // 
            this.FletcherReevesMethod.Location = new System.Drawing.Point(37, 212);
            this.FletcherReevesMethod.Name = "FletcherReevesMethod";
            this.FletcherReevesMethod.Size = new System.Drawing.Size(133, 47);
            this.FletcherReevesMethod.TabIndex = 10;
            this.FletcherReevesMethod.Text = "Метод Флетчера-Ривза";
            this.FletcherReevesMethod.UseVisualStyleBackColor = true;
            this.FletcherReevesMethod.Click += new System.EventHandler(this.FletcherReevesMethod_Click);
            // 
            // ModifiedNewtonsMethod
            // 
            this.ModifiedNewtonsMethod.Location = new System.Drawing.Point(37, 265);
            this.ModifiedNewtonsMethod.Name = "ModifiedNewtonsMethod";
            this.ModifiedNewtonsMethod.Size = new System.Drawing.Size(133, 47);
            this.ModifiedNewtonsMethod.TabIndex = 11;
            this.ModifiedNewtonsMethod.Text = "Модифицированный метод Ньютона";
            this.ModifiedNewtonsMethod.UseVisualStyleBackColor = true;
            this.ModifiedNewtonsMethod.Click += new System.EventHandler(this.ModifiedNewtonsMethod_Click);
            // 
            // Iterations
            // 
            this.Iterations.AutoSize = true;
            this.Iterations.Location = new System.Drawing.Point(314, 138);
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(28, 15);
            this.Iterations.TabIndex = 12;
            this.Iterations.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Iterations -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.ModifiedNewtonsMethod);
            this.Controls.Add(this.FletcherReevesMethod);
            this.Controls.Add(this.DescentOfTheSecondOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FastestGradient);
            this.Controls.Add(this.F);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.GradientDescent);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Многомерная оптимизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button GradientDescent;
        private Label X1;
        private Label X2;
        private Label F;
        private Button FastestGradient;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button DescentOfTheSecondOrder;
        private Button FletcherReevesMethod;
        private Button ModifiedNewtonsMethod;
        private Label Iterations;
        private Label label1;
    }
}