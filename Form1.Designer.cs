namespace GUI_API_Formss
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
            btnGetMessage = new Button();
            btnFetchQuote = new Button();
            txtOutput = new TextBox();
            button1 = new Button();
            btnGetJoke = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // btnGetMessage
            // 
            btnGetMessage.Location = new Point(322, 334);
            btnGetMessage.Name = "btnGetMessage";
            btnGetMessage.Size = new Size(84, 23);
            btnGetMessage.TabIndex = 0;
            btnGetMessage.Text = "Get Message";
            btnGetMessage.UseVisualStyleBackColor = true;
            btnGetMessage.Click += btnGetMessage_Click;
            // 
            // btnFetchQuote
            // 
            btnFetchQuote.Location = new Point(250, 214);
            btnFetchQuote.Name = "btnFetchQuote";
            btnFetchQuote.Size = new Size(75, 23);
            btnFetchQuote.TabIndex = 3;
            btnFetchQuote.Text = "Quote";
            btnFetchQuote.UseVisualStyleBackColor = true;
            btnFetchQuote.Click += btnFetchQuote_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(233, 101);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(290, 91);
            txtOutput.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(412, 214);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Quote";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnGetJoke
            // 
            btnGetJoke.Location = new Point(331, 214);
            btnGetJoke.Name = "btnGetJoke";
            btnGetJoke.Size = new Size(75, 23);
            btnGetJoke.TabIndex = 6;
            btnGetJoke.Text = "Joke";
            btnGetJoke.UseVisualStyleBackColor = true;
            btnGetJoke.Click += btnGetJoke_Click;
            // 
            // button3
            // 
            button3.Location = new Point(250, 243);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Quote";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(331, 243);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Quote";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(412, 243);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 9;
            button5.Text = "Quote";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(412, 272);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 12;
            button6.Text = "Quote";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(331, 272);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 11;
            button7.Text = "Quote";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(250, 272);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 10;
            button8.Text = "Quote";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(412, 301);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 15;
            button9.Text = "Quote";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(331, 301);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 14;
            button10.Text = "Quote";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(250, 301);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 13;
            button11.Text = "Quote";
            button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnGetJoke);
            Controls.Add(button1);
            Controls.Add(txtOutput);
            Controls.Add(btnFetchQuote);
            Controls.Add(btnGetMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetMessage;
        private Button btnFetchQuote;
        private TextBox txtOutput;
        private Button button1;
        private Button btnGetJoke;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}