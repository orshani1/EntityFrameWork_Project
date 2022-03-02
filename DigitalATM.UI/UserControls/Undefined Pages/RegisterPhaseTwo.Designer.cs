namespace ATM.UI
{
    partial class RegisterPhaseTwo : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPhaseTwo));
            this.registerButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bankListBox = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.verificetionMethodListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.inserCodeLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Enabled = false;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(100, 657);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(276, 51);
            this.registerButton.TabIndex = 52;
            this.registerButton.Text = "Register!";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.registerButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.registerButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(57, 388);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 283);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lastnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameTextBox.ForeColor = System.Drawing.Color.White;
            this.lastnameTextBox.Location = new System.Drawing.Point(110, 283);
            this.lastnameTextBox.Multiline = true;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(278, 35);
            this.lastnameTextBox.TabIndex = 40;
            this.lastnameTextBox.Text = "Last Name";
            this.lastnameTextBox.Click += new System.EventHandler(this.lastnameTextBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DigitalATM.UI.Properties.Resources.icons8_user_male_480;
            this.pictureBox1.Location = new System.Drawing.Point(57, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.firstnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameTextBox.ForeColor = System.Drawing.Color.White;
            this.firstnameTextBox.Location = new System.Drawing.Point(110, 226);
            this.firstnameTextBox.Multiline = true;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(278, 35);
            this.firstnameTextBox.TabIndex = 36;
            this.firstnameTextBox.Text = "First Name";
            this.firstnameTextBox.Click += new System.EventHandler(this.firstnameTextBox_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "Just   a bit more details and we finish";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(179, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 127);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(110, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 1);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(110, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 1);
            this.panel2.TabIndex = 54;
            // 
            // bankListBox
            // 
            this.bankListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bankListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bankListBox.ForeColor = System.Drawing.Color.White;
            this.bankListBox.FormattingEnabled = true;
            this.bankListBox.ItemHeight = 20;
            this.bankListBox.Location = new System.Drawing.Point(110, 388);
            this.bankListBox.Name = "bankListBox";
            this.bankListBox.Size = new System.Drawing.Size(278, 42);
            this.bankListBox.TabIndex = 55;
            this.bankListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(57, 436);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(358, 32);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "check here if you want credit card";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // verificetionMethodListBox
            // 
            this.verificetionMethodListBox.FormattingEnabled = true;
            this.verificetionMethodListBox.ItemHeight = 20;
            this.verificetionMethodListBox.Items.AddRange(new object[] {
            "Phone",
            "Email"});
            this.verificetionMethodListBox.Location = new System.Drawing.Point(100, 540);
            this.verificetionMethodListBox.Name = "verificetionMethodListBox";
            this.verificetionMethodListBox.Size = new System.Drawing.Size(248, 24);
            this.verificetionMethodListBox.TabIndex = 58;
            this.verificetionMethodListBox.SelectedIndexChanged += new System.EventHandler(this.verificetionMethodListBox_SelectedIndexChanged);
            this.verificetionMethodListBox.DoubleClick += new System.EventHandler(this.verificetionMethodListBox_DoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-778, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 28);
            this.label2.TabIndex = 59;
            this.label2.Text = "Choose a verificetion Method (make sure you press the selection)";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeTextBox.BackColor = System.Drawing.Color.White;
            this.CodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.CodeTextBox.Location = new System.Drawing.Point(100, 619);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(248, 20);
            this.CodeTextBox.TabIndex = 60;
            this.CodeTextBox.Visible = false;
            this.CodeTextBox.TextChanged += new System.EventHandler(this.CodeTextBox_TextChanged);
            // 
            // inserCodeLabel
            // 
            this.inserCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inserCodeLabel.AutoSize = true;
            this.inserCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inserCodeLabel.ForeColor = System.Drawing.Color.White;
            this.inserCodeLabel.Location = new System.Drawing.Point(89, 578);
            this.inserCodeLabel.Name = "inserCodeLabel";
            this.inserCodeLabel.Size = new System.Drawing.Size(177, 28);
            this.inserCodeLabel.TabIndex = 61;
            this.inserCodeLabel.Text = "Inser code below:";
            this.inserCodeLabel.Visible = false;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Enabled = false;
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(386, 528);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(110, 51);
            this.sendButton.TabIndex = 62;
            this.sendButton.Text = "Send!";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            this.sendButton.MouseEnter += new System.EventHandler(this.sendButton_MouseEnter);
            this.sendButton.MouseLeave += new System.EventHandler(this.sendButton_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(110, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 63;
            this.label3.Text = "Choose Bank";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 28);
            this.label4.TabIndex = 64;
            this.label4.Text = "Choose Verification Method";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Be Sure you Click The item ";
            // 
            // RegisterPhaseTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inserCodeLabel);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verificetionMethodListBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bankListBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "RegisterPhaseTwo";
            this.Size = new System.Drawing.Size(521, 722);
            this.Load += new System.EventHandler(this.RegisterPhaseTwo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button registerButton;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private TextBox lastnameTextBox;
        private PictureBox pictureBox1;
        private TextBox firstnameTextBox;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private ListBox bankListBox;
        private CheckBox checkBox1;
        private ListBox verificetionMethodListBox;
        private Label label2;
        private TextBox CodeTextBox;
        private Label inserCodeLabel;
        private Button sendButton;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
