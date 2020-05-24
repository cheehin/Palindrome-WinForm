namespace palidrome
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
            this.components = new System.ComponentModel.Container();
            this.TB_Str = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.TB_Str2 = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.TT1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Str
            // 
            this.TB_Str.Location = new System.Drawing.Point(12, 30);
            this.TB_Str.MaxLength = 1000;
            this.TB_Str.Multiline = true;
            this.TB_Str.Name = "TB_Str";
            this.TB_Str.Size = new System.Drawing.Size(355, 303);
            this.TB_Str.TabIndex = 0;
            this.TB_Str.TextChanged += new System.EventHandler(this.TB_Str_TextChanged);
            this.TB_Str.MouseHover += new System.EventHandler(this.TB_Str_MouseHover);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(125, 336);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(13, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "0";
            // 
            // TB_Str2
            // 
            this.TB_Str2.Location = new System.Drawing.Point(477, 30);
            this.TB_Str2.MaxLength = 1000;
            this.TB_Str2.Multiline = true;
            this.TB_Str2.Name = "TB_Str2";
            this.TB_Str2.Size = new System.Drawing.Size(355, 303);
            this.TB_Str2.TabIndex = 1;
            this.TB_Str2.MouseHover += new System.EventHandler(this.TB_Str2_MouseHover);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(517, 336);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(13, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Longest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Shortest";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(383, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "If need any help, just simply hover your mouse to the particular area and help wi" +
    "ll be shown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.TB_Str2);
            this.Controls.Add(this.TB_Str);
            this.Name = "Form1";
            this.Text = "Palindrome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Str;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox TB_Str2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip TT1;
        private System.Windows.Forms.Label label1;
    }
}

