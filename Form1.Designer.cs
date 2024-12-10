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
            btnFetchQuote = new Button();
            txtOutput = new TextBox();
            btnGetFact = new Button();
            btnGetJoke = new Button();
            btnGetChuckNorris = new Button();
            btnGetTrivia = new Button();
            btnGetHobbies = new Button();
            btnGetDadJoke = new Button();
            btnGetLoremIpsum = new Button();
            btnGetRiddle = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
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
            // btnGetFact
            // 
            btnGetFact.Location = new Point(412, 214);
            btnGetFact.Name = "btnGetFact";
            btnGetFact.Size = new Size(75, 23);
            btnGetFact.TabIndex = 5;
            btnGetFact.Text = "Fact";
            btnGetFact.UseVisualStyleBackColor = true;
            btnGetFact.Click += btnGetFact_Click;
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
            // btnGetChuckNorris
            // 
            btnGetChuckNorris.Location = new Point(250, 243);
            btnGetChuckNorris.Name = "btnGetChuckNorris";
            btnGetChuckNorris.Size = new Size(75, 23);
            btnGetChuckNorris.TabIndex = 7;
            btnGetChuckNorris.Text = "Chuck N";
            btnGetChuckNorris.UseVisualStyleBackColor = true;
            btnGetChuckNorris.Click += btnGetChuckNorris_Click;
            // 
            // btnGetTrivia
            // 
            btnGetTrivia.Location = new Point(331, 243);
            btnGetTrivia.Name = "btnGetTrivia";
            btnGetTrivia.Size = new Size(75, 23);
            btnGetTrivia.TabIndex = 8;
            btnGetTrivia.Text = "Trivia";
            btnGetTrivia.UseVisualStyleBackColor = true;
            btnGetTrivia.Click += btnGetTrivia_Click;
            // 
            // btnGetHobbies
            // 
            btnGetHobbies.Location = new Point(412, 243);
            btnGetHobbies.Name = "btnGetHobbies";
            btnGetHobbies.Size = new Size(75, 23);
            btnGetHobbies.TabIndex = 9;
            btnGetHobbies.Text = "Hobbies";
            btnGetHobbies.UseVisualStyleBackColor = true;
            btnGetHobbies.Click += btnGetHobbies_Click;
            // 
            // btnGetDadJoke
            // 
            btnGetDadJoke.Location = new Point(412, 272);
            btnGetDadJoke.Name = "btnGetDadJoke";
            btnGetDadJoke.Size = new Size(75, 23);
            btnGetDadJoke.TabIndex = 12;
            btnGetDadJoke.Text = "Dad Joke";
            btnGetDadJoke.UseVisualStyleBackColor = true;
            btnGetDadJoke.Click += btnGetDadJoke_Click;
            // 
            // btnGetLoremIpsum
            // 
            btnGetLoremIpsum.Location = new Point(331, 272);
            btnGetLoremIpsum.Name = "btnGetLoremIpsum";
            btnGetLoremIpsum.Size = new Size(75, 23);
            btnGetLoremIpsum.TabIndex = 11;
            btnGetLoremIpsum.Text = "LoremIps";
            btnGetLoremIpsum.UseVisualStyleBackColor = true;
            btnGetLoremIpsum.Click += btnGetLoremIpsum_Click;
            // 
            // btnGetRiddle
            // 
            btnGetRiddle.Location = new Point(250, 272);
            btnGetRiddle.Name = "btnGetRiddle";
            btnGetRiddle.Size = new Size(75, 23);
            btnGetRiddle.TabIndex = 10;
            btnGetRiddle.Text = "Riddle";
            btnGetRiddle.UseVisualStyleBackColor = true;
            btnGetRiddle.Click += btnGetRiddle_Click;
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
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(btnGetDadJoke);
            Controls.Add(btnGetLoremIpsum);
            Controls.Add(btnGetRiddle);
            Controls.Add(btnGetHobbies);
            Controls.Add(btnGetTrivia);
            Controls.Add(btnGetChuckNorris);
            Controls.Add(btnGetJoke);
            Controls.Add(btnGetFact);
            Controls.Add(txtOutput);
            Controls.Add(btnFetchQuote);
            Name = "Form1";
            Text = "Form1";
            Click += btnGetHobbies_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFetchQuote;
        private TextBox txtOutput;
        private Button btnGetFact;
        private Button btnGetJoke;
        private Button btnGetChuckNorris;
        private Button btnGetTrivia;
        private Button btnGetHobbies;
        private Button btnGetDadJoke;
        private Button btnGetLoremIpsum;
        private Button btnGetRiddle;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}