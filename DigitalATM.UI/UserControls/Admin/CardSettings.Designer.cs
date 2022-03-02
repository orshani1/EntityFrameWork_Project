namespace DigitalATM.UI
{
    partial class CardSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.returnPicBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelForId = new System.Windows.Forms.Label();
            this.holderLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cardCcvLabel = new System.Windows.Forms.Label();
            this.cardnumberlabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteCardButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.returnPicBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cards Settings";
            // 
            // returnPicBox
            // 
            this.returnPicBox.Image = global::DigitalATM.UI.Properties.Resources.icons8_left_2_1001;
            this.returnPicBox.Location = new System.Drawing.Point(113, 12);
            this.returnPicBox.Name = "returnPicBox";
            this.returnPicBox.Size = new System.Drawing.Size(61, 45);
            this.returnPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnPicBox.TabIndex = 23;
            this.returnPicBox.TabStop = false;
            this.returnPicBox.Click += new System.EventHandler(this.returnPicBox_Click);
            this.returnPicBox.MouseEnter += new System.EventHandler(this.returnPicBox_MouseEnter);
            this.returnPicBox.MouseLeave += new System.EventHandler(this.returnPicBox_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 28);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Choose Card Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Card Number :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.labelForId);
            this.groupBox1.Controls.Add(this.holderLabel);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.cardCcvLabel);
            this.groupBox1.Controls.Add(this.cardnumberlabel);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(207, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 274);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card Details";
            // 
            // labelForId
            // 
            this.labelForId.AutoSize = true;
            this.labelForId.ForeColor = System.Drawing.Color.White;
            this.labelForId.Location = new System.Drawing.Point(156, 224);
            this.labelForId.Name = "labelForId";
            this.labelForId.Size = new System.Drawing.Size(65, 20);
            this.labelForId.TabIndex = 35;
            this.labelForId.Text = "4555555";
            // 
            // holderLabel
            // 
            this.holderLabel.AutoSize = true;
            this.holderLabel.ForeColor = System.Drawing.Color.White;
            this.holderLabel.Location = new System.Drawing.Point(156, 183);
            this.holderLabel.Name = "holderLabel";
            this.holderLabel.Size = new System.Drawing.Size(65, 20);
            this.holderLabel.TabIndex = 34;
            this.holderLabel.Text = "4555555";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(156, 134);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(65, 20);
            this.dateLabel.TabIndex = 33;
            this.dateLabel.Text = "4555555";
            // 
            // cardCcvLabel
            // 
            this.cardCcvLabel.AutoSize = true;
            this.cardCcvLabel.ForeColor = System.Drawing.Color.White;
            this.cardCcvLabel.Location = new System.Drawing.Point(156, 85);
            this.cardCcvLabel.Name = "cardCcvLabel";
            this.cardCcvLabel.Size = new System.Drawing.Size(65, 20);
            this.cardCcvLabel.TabIndex = 32;
            this.cardCcvLabel.Text = "4555555";
            // 
            // cardnumberlabel
            // 
            this.cardnumberlabel.AutoSize = true;
            this.cardnumberlabel.ForeColor = System.Drawing.Color.White;
            this.cardnumberlabel.Location = new System.Drawing.Point(156, 41);
            this.cardnumberlabel.Name = "cardnumberlabel";
            this.cardnumberlabel.Size = new System.Drawing.Size(93, 20);
            this.cardnumberlabel.TabIndex = 31;
            this.cardnumberlabel.Text = "Choose Card";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(63, 224);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Account Id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Card Holder :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Card Expire Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Card CVV :";
            // 
            // deleteCardButton
            // 
            this.deleteCardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteCardButton.FlatAppearance.BorderSize = 0;
            this.deleteCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCardButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteCardButton.ForeColor = System.Drawing.Color.White;
            this.deleteCardButton.Location = new System.Drawing.Point(207, 473);
            this.deleteCardButton.Name = "deleteCardButton";
            this.deleteCardButton.Size = new System.Drawing.Size(323, 65);
            this.deleteCardButton.TabIndex = 28;
            this.deleteCardButton.Text = "Delete Card";
            this.deleteCardButton.UseVisualStyleBackColor = true;
            this.deleteCardButton.Click += new System.EventHandler(this.deleteCardButton_Click);
            this.deleteCardButton.MouseEnter += new System.EventHandler(this.deleteCardButton_MouseEnter);
            this.deleteCardButton.MouseLeave += new System.EventHandler(this.deleteCardButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.deleteCardButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 565);
            this.panel1.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(479, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 473);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 143);
            this.panel2.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(363, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 31);
            this.label9.TabIndex = 27;
            this.label9.Text = "ATM";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(283, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 31);
            this.label10.TabIndex = 26;
            this.label10.Text = "Digital";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox11.Image = global::DigitalATM.UI.Properties.Resources.icons8_atm_80__1_;
            this.pictureBox11.Location = new System.Drawing.Point(318, 15);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(75, 63);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(174, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 1);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 143);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(543, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 143);
            this.panel3.TabIndex = 0;
            // 
            // CardSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.returnPicBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CardSettings";
            this.Size = new System.Drawing.Size(693, 711);
            this.Load += new System.EventHandler(this.CardSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnPicBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox returnPicBox;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label labelForId;
        private Label holderLabel;
        private Label dateLabel;
        private Label cardCcvLabel;
        private Label cardnumberlabel;
        private Label label20;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button deleteCardButton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox11;
    }
}
