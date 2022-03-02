namespace DigitalATM.UI
{
    partial class CreateSaving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSaving));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amountNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.returnPicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(218, 24);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(284, 41);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Create New Saving";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTextBox.Location = new System.Drawing.Point(224, 169);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(284, 27);
            this.nameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose Name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(221, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Choose Amount for first deposit: ";
            // 
            // amountNum
            // 
            this.amountNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.amountNum.Location = new System.Drawing.Point(224, 296);
            this.amountNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amountNum.Name = "amountNum";
            this.amountNum.Size = new System.Drawing.Size(281, 27);
            this.amountNum.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(221, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // returnPicBox
            // 
            this.returnPicBox.Image = global::DigitalATM.UI.Properties.Resources.icons8_left_2_1001;
            this.returnPicBox.Location = new System.Drawing.Point(127, 24);
            this.returnPicBox.Name = "returnPicBox";
            this.returnPicBox.Size = new System.Drawing.Size(61, 45);
            this.returnPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnPicBox.TabIndex = 17;
            this.returnPicBox.TabStop = false;
            this.returnPicBox.Click += new System.EventHandler(this.returnPicBox_Click);
            this.returnPicBox.MouseEnter += new System.EventHandler(this.returnPicBox_MouseEnter);
            this.returnPicBox.MouseLeave += new System.EventHandler(this.returnPicBox_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 451);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 139);
            this.panel2.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(192, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 1);
            this.panel5.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(363, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 31);
            this.label9.TabIndex = 27;
            this.label9.Text = "ATM";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 139);
            this.panel4.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(283, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 31);
            this.label10.TabIndex = 26;
            this.label10.Text = "Digital";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(537, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 139);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox11.Image = global::DigitalATM.UI.Properties.Resources.icons8_atm_80__1_;
            this.pictureBox11.Location = new System.Drawing.Point(318, 20);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(75, 63);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            // 
            // CreateSaving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.returnPicBox);
            this.Controls.Add(this.amountNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.panel1);
            this.Name = "CreateSaving";
            this.Size = new System.Drawing.Size(750, 590);
            this.Load += new System.EventHandler(this.CreateSaving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private TextBox nameTextBox;
        private Label label1;
        private Label label2;
        private NumericUpDown amountNum;
        private Button button1;
        private PictureBox returnPicBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox11;
    }
}
