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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFetchQuote
            // 
            btnFetchQuote.Location = new Point(0, 22);
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
            btnGetFact.Location = new Point(162, 22);
            btnGetFact.Name = "btnGetFact";
            btnGetFact.Size = new Size(75, 23);
            btnGetFact.TabIndex = 5;
            btnGetFact.Text = "Fact";
            btnGetFact.UseVisualStyleBackColor = true;
            btnGetFact.Click += btnGetFact_Click;
            // 
            // btnGetJoke
            // 
            btnGetJoke.Location = new Point(81, 22);
            btnGetJoke.Name = "btnGetJoke";
            btnGetJoke.Size = new Size(75, 23);
            btnGetJoke.TabIndex = 6;
            btnGetJoke.Text = "Joke";
            btnGetJoke.UseVisualStyleBackColor = true;
            btnGetJoke.Click += btnGetJoke_Click;
            // 
            // btnGetChuckNorris
            // 
            btnGetChuckNorris.Location = new Point(0, 51);
            btnGetChuckNorris.Name = "btnGetChuckNorris";
            btnGetChuckNorris.Size = new Size(75, 23);
            btnGetChuckNorris.TabIndex = 7;
            btnGetChuckNorris.Text = "Chuck N";
            btnGetChuckNorris.UseVisualStyleBackColor = true;
            btnGetChuckNorris.Click += btnGetChuckNorris_Click;
            // 
            // btnGetTrivia
            // 
            btnGetTrivia.Location = new Point(81, 51);
            btnGetTrivia.Name = "btnGetTrivia";
            btnGetTrivia.Size = new Size(75, 23);
            btnGetTrivia.TabIndex = 8;
            btnGetTrivia.Text = "Trivia";
            btnGetTrivia.UseVisualStyleBackColor = true;
            btnGetTrivia.Click += btnGetTrivia_Click;
            // 
            // btnGetHobbies
            // 
            btnGetHobbies.Location = new Point(162, 51);
            btnGetHobbies.Name = "btnGetHobbies";
            btnGetHobbies.Size = new Size(75, 23);
            btnGetHobbies.TabIndex = 9;
            btnGetHobbies.Text = "Hobbies";
            btnGetHobbies.UseVisualStyleBackColor = true;
            btnGetHobbies.Click += btnGetHobbies_Click;
            // 
            // btnGetDadJoke
            // 
            btnGetDadJoke.Location = new Point(162, 80);
            btnGetDadJoke.Name = "btnGetDadJoke";
            btnGetDadJoke.Size = new Size(75, 23);
            btnGetDadJoke.TabIndex = 12;
            btnGetDadJoke.Text = "Dad Joke";
            btnGetDadJoke.UseVisualStyleBackColor = true;
            btnGetDadJoke.Click += btnGetDadJoke_Click;
            // 
            // btnGetLoremIpsum
            // 
            btnGetLoremIpsum.Location = new Point(81, 80);
            btnGetLoremIpsum.Name = "btnGetLoremIpsum";
            btnGetLoremIpsum.Size = new Size(75, 23);
            btnGetLoremIpsum.TabIndex = 11;
            btnGetLoremIpsum.Text = "LoremIps";
            btnGetLoremIpsum.UseVisualStyleBackColor = true;
            btnGetLoremIpsum.Click += btnGetLoremIpsum_Click;
            // 
            // btnGetRiddle
            // 
            btnGetRiddle.Location = new Point(0, 80);
            btnGetRiddle.Name = "btnGetRiddle";
            btnGetRiddle.Size = new Size(75, 23);
            btnGetRiddle.TabIndex = 10;
            btnGetRiddle.Text = "Riddle";
            btnGetRiddle.UseVisualStyleBackColor = true;
            btnGetRiddle.Click += btnGetRiddle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 25);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 13;
            label1.Text = "Fun API Functions";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFetchQuote);
            groupBox1.Controls.Add(btnGetFact);
            groupBox1.Controls.Add(btnGetDadJoke);
            groupBox1.Controls.Add(btnGetJoke);
            groupBox1.Controls.Add(btnGetLoremIpsum);
            groupBox1.Controls.Add(btnGetChuckNorris);
            groupBox1.Controls.Add(btnGetRiddle);
            groupBox1.Controls.Add(btnGetTrivia);
            groupBox1.Controls.Add(btnGetHobbies);
            groupBox1.Location = new Point(250, 219);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(237, 118);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Name = "Form1";
            Text = "Form1";
            Click += btnGetHobbies_Click;
            groupBox1.ResumeLayout(false);
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
        private Label label1;
        private GroupBox groupBox1;



    }
}