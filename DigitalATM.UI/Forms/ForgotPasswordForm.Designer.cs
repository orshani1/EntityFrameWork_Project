namespace DigitalATM.UI
{
    partial class ForgotPasswordForm : Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.enterCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "aa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 27);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(425, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 97);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send me the code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // codeLabel
            // 
            this.codeLabel.AccessibleName = "";
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.Color.Transparent;
            this.codeLabel.ForeColor = System.Drawing.Color.White;
            this.codeLabel.Location = new System.Drawing.Point(167, 285);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(156, 20);
            this.codeLabel.TabIndex = 6;
            this.codeLabel.Text = "Inser the Code below :";
            this.codeLabel.Visible = false;
            // 
            // codeTextBox
            // 
            this.codeTextBox.AccessibleName = "";
            this.codeTextBox.Location = new System.Drawing.Point(167, 317);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(217, 27);
            this.codeTextBox.TabIndex = 7;
            this.codeTextBox.Visible = false;
            // 
            // enterCodeButton
            // 
            this.enterCodeButton.AccessibleName = "";
            this.enterCodeButton.BackColor = System.Drawing.Color.Transparent;
            this.enterCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterCodeButton.ForeColor = System.Drawing.Color.White;
            this.enterCodeButton.Location = new System.Drawing.Point(167, 363);
            this.enterCodeButton.Name = "enterCodeButton";
            this.enterCodeButton.Size = new System.Drawing.Size(217, 27);
            this.enterCodeButton.TabIndex = 8;
            this.enterCodeButton.Text = "Send me the code";
            this.enterCodeButton.UseVisualStyleBackColor = false;
            this.enterCodeButton.Visible = false;
            this.enterCodeButton.Click += new System.EventHandler(this.enterCodeButton_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DigitalATM.UI.Properties.Resources.chalkboard;
            this.ClientSize = new System.Drawing.Size(621, 476);
            this.Controls.Add(this.enterCodeButton);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ForgotPasswordForm";
            this.Text = "Forgot Password Window";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label codeLabel;
        private TextBox codeTextBox;
        private Button enterCodeButton;
    }
}
