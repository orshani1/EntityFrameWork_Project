namespace DigitalATM.UI.UserControls.Admin
{
    partial class WriteToAccounts
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
            this.label1 = new System.Windows.Forms.Label();
            this.bodyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.clientsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Email to accounts";
            // 
            // bodyRichTextBox
            // 
            this.bodyRichTextBox.Location = new System.Drawing.Point(42, 237);
            this.bodyRichTextBox.Name = "bodyRichTextBox";
            this.bodyRichTextBox.Size = new System.Drawing.Size(739, 242);
            this.bodyRichTextBox.TabIndex = 1;
            this.bodyRichTextBox.Text = "";
            // 
            // clientsComboBox
            // 
            this.clientsComboBox.FormattingEnabled = true;
            this.clientsComboBox.Location = new System.Drawing.Point(364, 74);
            this.clientsComboBox.Name = "clientsComboBox";
            this.clientsComboBox.Size = new System.Drawing.Size(151, 28);
            this.clientsComboBox.TabIndex = 2;
            this.clientsComboBox.SelectedValueChanged += new System.EventHandler(this.clientsComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(240, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Client :";
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.ForeColor = System.Drawing.Color.White;
            this.allCheckBox.Location = new System.Drawing.Point(530, 76);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(49, 24);
            this.allCheckBox.TabIndex = 4;
            this.allCheckBox.Text = "All";
            this.allCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(278, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject : ";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(364, 149);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(151, 27);
            this.subjectTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(415, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Body :";
            // 
            // sendButton
            // 
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(364, 511);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(151, 43);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Send ! ";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(290, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email : ";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Enabled = false;
            this.EmailtextBox.Location = new System.Drawing.Point(364, 111);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(151, 27);
            this.EmailtextBox.TabIndex = 10;
            // 
            // WriteToAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientsComboBox);
            this.Controls.Add(this.bodyRichTextBox);
            this.Controls.Add(this.label1);
            this.Name = "WriteToAccounts";
            this.Size = new System.Drawing.Size(846, 584);
            this.Load += new System.EventHandler(this.WriteToAccounts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox bodyRichTextBox;
        private ComboBox clientsComboBox;
        private Label label2;
        private CheckBox allCheckBox;
        private Label label3;
        private TextBox subjectTextBox;
        private Label label4;
        private Button sendButton;
        private Label label5;
        private TextBox EmailtextBox;
    }
}
