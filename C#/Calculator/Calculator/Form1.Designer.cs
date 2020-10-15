namespace Calculator
{
    partial class Form1
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UNlbl = new System.Windows.Forms.Label();
            this.PWlbl = new System.Windows.Forms.Label();
            this.UNbox = new System.Windows.Forms.TextBox();
            this.PWbox = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.HelpPanel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Nlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HelpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(288, 178);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(112, 35);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(147, 178);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 35);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UNlbl
            // 
            this.UNlbl.AutoSize = true;
            this.UNlbl.Location = new System.Drawing.Point(18, 76);
            this.UNlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UNlbl.Name = "UNlbl";
            this.UNlbl.Size = new System.Drawing.Size(85, 20);
            this.UNlbl.TabIndex = 2;
            this.UNlbl.Text = "UserName";
            // 
            // PWlbl
            // 
            this.PWlbl.AutoSize = true;
            this.PWlbl.Location = new System.Drawing.Point(20, 112);
            this.PWlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PWlbl.Name = "PWlbl";
            this.PWlbl.Size = new System.Drawing.Size(82, 20);
            this.PWlbl.TabIndex = 3;
            this.PWlbl.Text = "PassWord";
            // 
            // UNbox
            // 
            this.UNbox.Location = new System.Drawing.Point(130, 71);
            this.UNbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UNbox.Name = "UNbox";
            this.UNbox.Size = new System.Drawing.Size(268, 26);
            this.UNbox.TabIndex = 4;
            // 
            // PWbox
            // 
            this.PWbox.Location = new System.Drawing.Point(130, 108);
            this.PWbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PWbox.Name = "PWbox";
            this.PWbox.PasswordChar = '*';
            this.PWbox.Size = new System.Drawing.Size(268, 26);
            this.PWbox.TabIndex = 5;
            this.PWbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(147, 235);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(112, 35);
            this.buttonHelp.TabIndex = 9;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // HelpPanel
            // 
            this.HelpPanel.Controls.Add(this.buttonExit);
            this.HelpPanel.Controls.Add(this.listBox1);
            this.HelpPanel.Location = new System.Drawing.Point(4, 283);
            this.HelpPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HelpPanel.Name = "HelpPanel";
            this.HelpPanel.Size = new System.Drawing.Size(602, 126);
            this.HelpPanel.TabIndex = 10;
            this.HelpPanel.Visible = false;
            this.HelpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(554, 6);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(39, 40);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "To access the calculator you must enter the correct credentials in the given fiel" +
                "ds",
            "To continue click \'Login\'",
            "To leave click \'Exit\'"});
            this.listBox1.Location = new System.Drawing.Point(8, 55);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(588, 64);
            this.listBox1.TabIndex = 0;
            // 
            // Nlbl
            // 
            this.Nlbl.AutoSize = true;
            this.Nlbl.Location = new System.Drawing.Point(51, 39);
            this.Nlbl.Name = "Nlbl";
            this.Nlbl.Size = new System.Drawing.Size(51, 20);
            this.Nlbl.TabIndex = 12;
            this.Nlbl.Text = "Name";
            this.Nlbl.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 26);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(619, 420);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nlbl);
            this.Controls.Add(this.HelpPanel);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.PWbox);
            this.Controls.Add(this.UNbox);
            this.Controls.Add(this.PWlbl);
            this.Controls.Add(this.UNlbl);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HelpPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label UNlbl;
        private System.Windows.Forms.Label PWlbl;
        private System.Windows.Forms.TextBox UNbox;
        private System.Windows.Forms.TextBox PWbox;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Panel HelpPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label Nlbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}

