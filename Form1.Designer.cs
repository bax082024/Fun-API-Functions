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
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFetchQuote
            // 
            btnFetchQuote.BackColor = Color.LightSteelBlue;
            btnFetchQuote.FlatStyle = FlatStyle.Flat;
            btnFetchQuote.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnFetchQuote.Location = new Point(6, 14);
            btnFetchQuote.Name = "btnFetchQuote";
            btnFetchQuote.Size = new Size(91, 34);
            btnFetchQuote.TabIndex = 3;
            btnFetchQuote.Text = "Quote";
            btnFetchQuote.UseVisualStyleBackColor = false;
            btnFetchQuote.Click += btnFetchQuote_Click;
            btnFetchQuote.Enter += btnFetchQuote_Enter;
            btnFetchQuote.Leave += btnFetchQuote_Leave;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.WhiteSmoke;
            txtOutput.BorderStyle = BorderStyle.FixedSingle;
            txtOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.ForeColor = Color.DarkSlateGray;
            txtOutput.Location = new Point(226, 69);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(318, 134);
            txtOutput.TabIndex = 4;
            // 
            // btnGetFact
            // 
            btnGetFact.BackColor = Color.LightSteelBlue;
            btnGetFact.FlatStyle = FlatStyle.Flat;
            btnGetFact.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGetFact.Location = new Point(200, 14);
            btnGetFact.Name = "btnGetFact";
            btnGetFact.Size = new Size(91, 34);
            btnGetFact.TabIndex = 5;
            btnGetFact.Text = "Fact";
            btnGetFact.UseVisualStyleBackColor = false;
            btnGetFact.Click += btnGetFact_Click;
            // 
            // btnGetJoke
            // 
            btnGetJoke.BackColor = Color.LightSteelBlue;
            btnGetJoke.FlatStyle = FlatStyle.Flat;
            btnGetJoke.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGetJoke.Location = new Point(103, 14);
            btnGetJoke.Name = "btnGetJoke";
            btnGetJoke.Size = new Size(91, 34);
            btnGetJoke.TabIndex = 6;
            btnGetJoke.Text = "Joke";
            btnGetJoke.UseVisualStyleBackColor = false;
            btnGetJoke.Click += btnGetJoke_Click;
            // 
            // btnGetChuckNorris
            // 
            btnGetChuckNorris.BackColor = Color.LightSteelBlue;
            btnGetChuckNorris.FlatStyle = FlatStyle.Flat;
            btnGetChuckNorris.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGetChuckNorris.Location = new Point(6, 54);
            btnGetChuckNorris.Name = "btnGetChuckNorris";
            btnGetChuckNorris.Size = new Size(91, 34);
            btnGetChuckNorris.TabIndex = 7;
            btnGetChuckNorris.Text = "Chuck N";
            btnGetChuckNorris.UseVisualStyleBackColor = false;
            btnGetChuckNorris.Click += btnGetChuckNorris_Click;
            // 
            // btnGetTrivia
            // 
            btnGetTrivia.BackColor = Color.LightSteelBlue;
            btnGetTrivia.FlatStyle = FlatStyle.Flat;
            btnGetTrivia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGetTrivia.Location = new Point(103, 54);
            btnGetTrivia.Name = "btnGetTrivia";
            btnGetTrivia.Size = new Size(91, 34);
            btnGetTrivia.TabIndex = 8;
            btnGetTrivia.Text = "Trivia";
            btnGetTrivia.UseVisualStyleBackColor = false;
            btnGetTrivia.Click += btnGetTrivia_Click;
            // 
            // btnGetHobbies
            // 
            btnGetHobbies.BackColor = Color.LightSteelBlue;
            btnGetHobbies.FlatStyle = FlatStyle.Flat;
            btnGetHobbies.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGetHobbies.Location = new Point(200, 54);
            btnGetHobbies.Name = "btnGetHobbies";
            btnGetHobbies.Size = new Size(91, 34);
            btnGetHobbies.TabIndex = 9;
            btnGetHobbies.Text = "Hobbies";
            btnGetHobbies.UseVisualStyleBackColor = false;
            btnGetHobbies.Click += btnGetHobbies_Click;
            // 
            // btnGetDadJoke
            // 
            btnGetDadJoke.BackColor = Color.LightSteelBlue;
            btnGetDadJoke.FlatStyle = FlatStyle.Flat;
            btnGetDadJoke.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGetDadJoke.Location = new Point(200, 94);
            btnGetDadJoke.Name = "btnGetDadJoke";
            btnGetDadJoke.Size = new Size(91, 34);
            btnGetDadJoke.TabIndex = 12;
            btnGetDadJoke.Text = "Dad Joke";
            btnGetDadJoke.UseVisualStyleBackColor = false;
            btnGetDadJoke.Click += btnGetDadJoke_Click;
            // 
            // btnGetLoremIpsum
            // 
            btnGetLoremIpsum.BackColor = Color.LightSteelBlue;
            btnGetLoremIpsum.FlatStyle = FlatStyle.Flat;
            btnGetLoremIpsum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGetLoremIpsum.Location = new Point(103, 94);
            btnGetLoremIpsum.Name = "btnGetLoremIpsum";
            btnGetLoremIpsum.Size = new Size(91, 34);
            btnGetLoremIpsum.TabIndex = 11;
            btnGetLoremIpsum.Text = "LoremIps";
            btnGetLoremIpsum.UseVisualStyleBackColor = false;
            btnGetLoremIpsum.Click += btnGetLoremIpsum_Click;
            // 
            // btnGetRiddle
            // 
            btnGetRiddle.BackColor = Color.LightSteelBlue;
            btnGetRiddle.FlatStyle = FlatStyle.Flat;
            btnGetRiddle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGetRiddle.Location = new Point(6, 94);
            btnGetRiddle.Name = "btnGetRiddle";
            btnGetRiddle.Size = new Size(91, 34);
            btnGetRiddle.TabIndex = 10;
            btnGetRiddle.Text = "Riddle";
            btnGetRiddle.UseVisualStyleBackColor = false;
            btnGetRiddle.Click += btnGetRiddle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(282, 25);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 13;
            label1.Text = "Fun API Functions";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnFetchQuote);
            groupBox1.Controls.Add(btnGetFact);
            groupBox1.Controls.Add(btnGetDadJoke);
            groupBox1.Controls.Add(btnGetJoke);
            groupBox1.Controls.Add(btnGetLoremIpsum);
            groupBox1.Controls.Add(btnGetChuckNorris);
            groupBox1.Controls.Add(btnGetRiddle);
            groupBox1.Controls.Add(btnGetTrivia);
            groupBox1.Controls.Add(btnGetHobbies);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(226, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 136);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(0, 435);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 15;
            label2.Text = "Bax Creation";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
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
        private Label label2;
    }
}