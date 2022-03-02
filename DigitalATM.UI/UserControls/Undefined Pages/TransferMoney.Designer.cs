namespace DigitalATM.UI
{
    partial class TransferMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferMoney));
            this.label1 = new System.Windows.Forms.Label();
            this.accountNumLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.blanceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnPicBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnPicBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money Transfer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // accountNumLabel
            // 
            this.accountNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accountNumLabel.AutoSize = true;
            this.accountNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountNumLabel.ForeColor = System.Drawing.Color.White;
            this.accountNumLabel.Location = new System.Drawing.Point(416, 72);
            this.accountNumLabel.Name = "accountNumLabel";
            this.accountNumLabel.Size = new System.Drawing.Size(77, 16);
            this.accountNumLabel.TabIndex = 1;
            this.accountNumLabel.Text = "1234124213";
            this.accountNumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.amountTextBox.Location = new System.Drawing.Point(213, 186);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(359, 22);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.Text = "Amount of transfer";
            this.amountTextBox.Click += new System.EventHandler(this.amountLabel_Click);
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountLabel_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Balance:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blanceLabel
            // 
            this.blanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blanceLabel.AutoSize = true;
            this.blanceLabel.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blanceLabel.ForeColor = System.Drawing.Color.Green;
            this.blanceLabel.Location = new System.Drawing.Point(303, 112);
            this.blanceLabel.Name = "blanceLabel";
            this.blanceLabel.Size = new System.Drawing.Size(43, 17);
            this.blanceLabel.TabIndex = 4;
            this.blanceLabel.Text = "20000";
            this.blanceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(306, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Account number :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clientListBox
            // 
            this.clientListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.ItemHeight = 16;
            this.clientListBox.Location = new System.Drawing.Point(213, 254);
            this.clientListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(359, 20);
            this.clientListBox.TabIndex = 6;
            this.clientListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transfer to";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 330);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(359, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(213, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "When to transefer";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(213, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Choose Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(213, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "Transfer ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(612, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 59);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.returnPicBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 443);
            this.panel1.TabIndex = 16;
            // 
            // returnPicBox
            // 
            this.returnPicBox.Image = global::DigitalATM.UI.Properties.Resources.icons8_left_2_1001;
            this.returnPicBox.Location = new System.Drawing.Point(149, 13);
            this.returnPicBox.Name = "returnPicBox";
            this.returnPicBox.Size = new System.Drawing.Size(61, 45);
            this.returnPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnPicBox.TabIndex = 24;
            this.returnPicBox.TabStop = false;
            this.returnPicBox.Click += new System.EventHandler(this.returnPicBox_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 125);
            this.panel2.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(192, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(386, 1);
            this.panel5.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 125);
            this.panel4.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(578, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 125);
            this.panel3.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(396, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 31);
            this.label9.TabIndex = 21;
            this.label9.Text = "ATM";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(316, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 31);
            this.label10.TabIndex = 20;
            this.label10.Text = "Digital";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox11.Image = global::DigitalATM.UI.Properties.Resources.icons8_atm_80__1_;
            this.pictureBox11.Location = new System.Drawing.Point(351, 9);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(75, 63);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 19;
            this.pictureBox11.TabStop = false;
            // 
            // TransferMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blanceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.accountNumLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransferMoney";
            this.Size = new System.Drawing.Size(774, 560);
            this.Load += new System.EventHandler(this.TransferMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnPicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label accountNumLabel;
        private TextBox amountTextBox;
        private Label label2;
        private Label blanceLabel;
        private Label label3;
        private ListBox clientListBox;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox11;
        private PictureBox returnPicBox;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
    }
}
