namespace WindowsFormsApp1
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
			this.LabelBox = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.FirstNameBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.LastNameBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.countrieBox = new System.Windows.Forms.ListBox();
			this.otherbox = new System.Windows.Forms.FlowLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.otherCountryName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.othercountryCode = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label4 = new System.Windows.Forms.Label();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cancel = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.otherbox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// LabelBox
			// 
			this.LabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelBox.FormattingEnabled = true;
			this.LabelBox.ItemHeight = 25;
			this.LabelBox.Location = new System.Drawing.Point(2, 2);
			this.LabelBox.Name = "LabelBox";
			this.LabelBox.Size = new System.Drawing.Size(431, 104);
			this.LabelBox.TabIndex = 0;
			this.LabelBox.SelectedIndexChanged += new System.EventHandler(this.LabelBox_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(548, 331);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(174, 72);
			this.button1.TabIndex = 1;
			this.button1.Text = "start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button);
			// 
			// FirstNameBox
			// 
			this.FirstNameBox.Location = new System.Drawing.Point(3, 20);
			this.FirstNameBox.Name = "FirstNameBox";
			this.FirstNameBox.Size = new System.Drawing.Size(333, 22);
			this.FirstNameBox.TabIndex = 2;
			// 
			// NameLabel
			// 
			this.NameLabel.AllowDrop = true;
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(3, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(76, 17);
			this.NameLabel.TabIndex = 3;
			this.NameLabel.Text = "First Name";
			this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.NameLabel);
			this.flowLayoutPanel1.Controls.Add(this.FirstNameBox);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.LastNameBox);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.countrieBox);
			this.flowLayoutPanel1.Controls.Add(this.otherbox);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.dateTimePicker1);
			this.flowLayoutPanel1.Controls.Add(this.splitContainer1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(439, 2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(337, 279);
			this.flowLayoutPanel1.TabIndex = 4;
			this.flowLayoutPanel1.Visible = false;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// label1
			// 
			this.label1.AllowDrop = true;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "LastName";
			// 
			// LastNameBox
			// 
			this.LastNameBox.Location = new System.Drawing.Point(3, 65);
			this.LastNameBox.Name = "LastNameBox";
			this.LastNameBox.Size = new System.Drawing.Size(333, 22);
			this.LastNameBox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Country";
			// 
			// countrieBox
			// 
			this.countrieBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.countrieBox.FormattingEnabled = true;
			this.countrieBox.ItemHeight = 16;
			this.countrieBox.Location = new System.Drawing.Point(66, 93);
			this.countrieBox.Name = "countrieBox";
			this.countrieBox.Size = new System.Drawing.Size(114, 116);
			this.countrieBox.TabIndex = 11;
			this.countrieBox.SelectedIndexChanged += new System.EventHandler(this.countrieBox_SelectedIndexChanged);
			// 
			// otherbox
			// 
			this.otherbox.Controls.Add(this.label5);
			this.otherbox.Controls.Add(this.otherCountryName);
			this.otherbox.Controls.Add(this.label6);
			this.otherbox.Controls.Add(this.othercountryCode);
			this.otherbox.Enabled = false;
			this.otherbox.Location = new System.Drawing.Point(186, 93);
			this.otherbox.Name = "otherbox";
			this.otherbox.Size = new System.Drawing.Size(117, 100);
			this.otherbox.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 17);
			this.label5.TabIndex = 14;
			this.label5.Text = "Country Name";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// otherCountryName
			// 
			this.otherCountryName.Location = new System.Drawing.Point(3, 20);
			this.otherCountryName.Name = "otherCountryName";
			this.otherCountryName.Size = new System.Drawing.Size(100, 22);
			this.otherCountryName.TabIndex = 13;
			this.otherCountryName.TextChanged += new System.EventHandler(this.otherCountry_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "Country Code";
			// 
			// othercountryCode
			// 
			this.othercountryCode.Location = new System.Drawing.Point(3, 65);
			this.othercountryCode.Name = "othercountryCode";
			this.othercountryCode.Size = new System.Drawing.Size(100, 22);
			this.othercountryCode.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AllowDrop = true;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 212);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 200, 0);
			this.label3.Size = new System.Drawing.Size(265, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Birthdate";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(3, 232);
			this.dateTimePicker1.MaxDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(334, 22);
			this.dateTimePicker1.TabIndex = 10;
			this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(3, 260);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Size = new System.Drawing.Size(54, 8);
			this.splitContainer1.SplitterDistance = 25;
			this.splitContainer1.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(612, 293);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "label4";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(38, 356);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(198, 22);
			this.searchBox.TabIndex = 6;
			this.searchBox.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(35, 315);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 17);
			this.label7.TabIndex = 7;
			this.label7.Text = "Search";
			this.label7.Visible = false;
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(421, 355);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 8;
			this.cancel.Text = "cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.LabelBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.otherbox.ResumeLayout(false);
			this.otherbox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox FirstNameBox;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox LastNameBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.DateTimePicker dateTimePicker1;
		public System.Windows.Forms.ListBox LabelBox;
		private System.Windows.Forms.ListBox countrieBox;
		private System.Windows.Forms.SplitContainer splitContainer1;
		public System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox otherCountryName;
		private System.Windows.Forms.FlowLayoutPanel otherbox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox othercountryCode;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button cancel;
	}
}

