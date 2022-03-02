namespace DigitalATM.UI
{
    partial class AccountCheck
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
            this.balanceLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.returnPicBox = new System.Windows.Forms.PictureBox();
            this.lastActions = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.startDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceLabel
            // 
            this.balanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceLabel.ForeColor = System.Drawing.Color.Green;
            this.balanceLabel.Location = new System.Drawing.Point(712, 13);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(67, 28);
            this.balanceLabel.TabIndex = 0;
            this.balanceLabel.Text = "00000";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(647, 41);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(132, 17);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "up to date : 04/01/22";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(658, 404);
            this.dataGridView1.TabIndex = 2;
            // 
            // returnPicBox
            // 
            this.returnPicBox.Image = global::DigitalATM.UI.Properties.Resources.icons8_left_2_1001;
            this.returnPicBox.Location = new System.Drawing.Point(45, 13);
            this.returnPicBox.Name = "returnPicBox";
            this.returnPicBox.Size = new System.Drawing.Size(61, 45);
            this.returnPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnPicBox.TabIndex = 4;
            this.returnPicBox.TabStop = false;
            this.returnPicBox.Click += new System.EventHandler(this.returnPicBox_Click);
            this.returnPicBox.MouseEnter += new System.EventHandler(this.returnPicBox_MouseEnter);
            this.returnPicBox.MouseLeave += new System.EventHandler(this.returnPicBox_MouseLeave);
            // 
            // lastActions
            // 
            this.lastActions.AutoSize = true;
            this.lastActions.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastActions.ForeColor = System.Drawing.Color.White;
            this.lastActions.Location = new System.Drawing.Point(133, 13);
            this.lastActions.Name = "lastActions";
            this.lastActions.Size = new System.Drawing.Size(144, 31);
            this.lastActions.TabIndex = 5;
            this.lastActions.Text = "Last Actions";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Description",
            "Amount",
            "Date",
            "Id"});
            this.listBox1.Location = new System.Drawing.Point(356, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 24);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sort By : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(485, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Start Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(321, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Show Only from date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(487, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "End Date : ";
            // 
            // showButton
            // 
            this.showButton.Enabled = false;
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.ForeColor = System.Drawing.Color.White;
            this.showButton.Location = new System.Drawing.Point(326, 104);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(153, 29);
            this.showButton.TabIndex = 14;
            this.showButton.Text = "Show!";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // startDateTimePicker1
            // 
            this.startDateTimePicker1.Location = new System.Drawing.Point(574, 75);
            this.startDateTimePicker1.Name = "startDateTimePicker1";
            this.startDateTimePicker1.Size = new System.Drawing.Size(214, 27);
            this.startDateTimePicker1.TabIndex = 15;
            // 
            // endDateTimePicker2
            // 
            this.endDateTimePicker2.Location = new System.Drawing.Point(574, 108);
            this.endDateTimePicker2.Name = "endDateTimePicker2";
            this.endDateTimePicker2.Size = new System.Drawing.Size(214, 27);
            this.endDateTimePicker2.TabIndex = 16;
            this.endDateTimePicker2.ValueChanged += new System.EventHandler(this.endDateTimePicker2_ValueChanged);
            // 
            // AccountCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.endDateTimePicker2);
            this.Controls.Add(this.startDateTimePicker1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lastActions);
            this.Controls.Add(this.returnPicBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.balanceLabel);
            this.Name = "AccountCheck";
            this.Size = new System.Drawing.Size(815, 572);
            this.Load += new System.EventHandler(this.AccountCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label balanceLabel;
        private Label dateLabel;
        private DataGridView dataGridView1;
        private PictureBox returnPicBox;
        private Label lastActions;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button showButton;
        private DateTimePicker startDateTimePicker1;
        private DateTimePicker endDateTimePicker2;
    }
}
