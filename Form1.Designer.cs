namespace jurnal3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttont = new Button();
            button0 = new Button();
            buttons = new Button();
            output = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 118);
            button1.Name = "button1";
            button1.Size = new Size(64, 58);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(101, 118);
            button2.Name = "button2";
            button2.Size = new Size(64, 58);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(171, 118);
            button3.Name = "button3";
            button3.Size = new Size(64, 58);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(31, 182);
            button4.Name = "button4";
            button4.Size = new Size(64, 58);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(101, 182);
            button5.Name = "button5";
            button5.Size = new Size(64, 58);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(171, 182);
            button6.Name = "button6";
            button6.Size = new Size(64, 58);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(31, 246);
            button7.Name = "button7";
            button7.Size = new Size(64, 58);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(101, 246);
            button8.Name = "button8";
            button8.Size = new Size(64, 58);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(171, 246);
            button9.Name = "button9";
            button9.Size = new Size(64, 58);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttont
            // 
            buttont.Location = new Point(303, 118);
            buttont.Name = "buttont";
            buttont.Size = new Size(64, 58);
            buttont.TabIndex = 9;
            buttont.Text = "+";
            buttont.UseVisualStyleBackColor = true;
            buttont.Click += buttont_Click;
            // 
            // button0
            // 
            button0.Location = new Point(101, 310);
            button0.Name = "button0";
            button0.Size = new Size(64, 58);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttons
            // 
            buttons.Location = new Point(302, 182);
            buttons.Name = "buttons";
            buttons.Size = new Size(64, 58);
            buttons.TabIndex = 11;
            buttons.Text = "=";
            buttons.UseVisualStyleBackColor = true;
            buttons.Click += buttons_Click;
            // 
            // output
            // 
            output.Location = new Point(50, 56);
            output.Name = "output";
            output.Size = new Size(302, 23);
            output.TabIndex = 12;
            output.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 450);
            Controls.Add(output);
            Controls.Add(buttons);
            Controls.Add(button0);
            Controls.Add(buttont);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttont;
        private Button button0;
        private Button buttons;
        private TextBox output;
    }
}
