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
            lblMessage = new Label();
            btnFetchQuote = new Button();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // btnGetMessage
            // 
            btnGetMessage.Location = new Point(322, 278);
            btnGetMessage.Name = "btnGetMessage";
            btnGetMessage.Size = new Size(84, 23);
            btnGetMessage.TabIndex = 0;
            btnGetMessage.Text = "Get Message";
            btnGetMessage.UseVisualStyleBackColor = true;
            btnGetMessage.Click += btnGetMessage_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(333, 260);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 1;
            // 
            // btnFetchQuote
            // 
            btnFetchQuote.Location = new Point(331, 214);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOutput);
            Controls.Add(btnFetchQuote);
            Controls.Add(lblMessage);
            Controls.Add(btnGetMessage);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetMessage;
        private Label lblMessage;
        private Button btnFetchQuote;
        private TextBox txtOutput;
    }
}