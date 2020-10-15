namespace Calculator
{
    partial class MathOp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(26, 72);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(145, 145);
            this.Add.TabIndex = 0;
            this.Add.Text = "Addition (+)";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(194, 72);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(145, 145);
            this.Sub.TabIndex = 1;
            this.Sub.Text = "Subtraction (-)";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(26, 234);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(145, 145);
            this.Mul.TabIndex = 2;
            this.Mul.Text = "Multiplication (x)";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(194, 234);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(145, 145);
            this.Div.TabIndex = 3;
            this.Div.Text = "Division (/)";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please choose the operation you desire";
            // 
            // MathOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(370, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Name = "MathOp";
            this.Text = "MathOp";
            this.Load += new System.EventHandler(this.MathOp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Label label1;
    }
}