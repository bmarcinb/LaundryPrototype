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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nIFRSDataSet = new WindowsFormsApp1.NIFRSDataSet();
			this.itemsTableAdapter = new WindowsFormsApp1.NIFRSDataSetTableAdapters.ItemsTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.FFNO = new System.Windows.Forms.TextBox();
			this.firefighterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.StationNO = new System.Windows.Forms.TextBox();
			this.firefighterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.firefighterTableAdapter = new WindowsFormsApp1.NIFRSDataSetTableAdapters.FirefighterTableAdapter();
			this.label4 = new System.Windows.Forms.Label();
			this.AddWashBagBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.ChkConLbl = new System.Windows.Forms.Label();
			this.randombox = new System.Windows.Forms.TextBox();
			this.processFlowBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.processFlowTableAdapter = new WindowsFormsApp1.NIFRSDataSetTableAdapters.ProcessFlowTableAdapter();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.itemInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nIFRSDataSet1 = new WindowsFormsApp1.NIFRSDataSet1();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.itemInventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.itemInventoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.itemInventoryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.itemInventoryTableAdapter = new WindowsFormsApp1.NIFRSDataSet1TableAdapters.ItemInventoryTableAdapter();
			this.TrCb2 = new System.Windows.Forms.ComboBox();
			this.TrCb3 = new System.Windows.Forms.ComboBox();
			this.comboBox9 = new System.Windows.Forms.ComboBox();
			this.comboBox10 = new System.Windows.Forms.ComboBox();
			this.comboBox11 = new System.Windows.Forms.ComboBox();
			this.TunicBtn = new System.Windows.Forms.Button();
			this.FirehoodBtn = new System.Windows.Forms.Button();
			this.TrousersBtn = new System.Windows.Forms.Button();
			this.comboBox12 = new System.Windows.Forms.ComboBox();
			this.Request = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nIFRSDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.firefighterBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.firefighterBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.processFlowBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemInventoryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nIFRSDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemInventoryBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemInventoryBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemInventoryBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// itemsBindingSource
			// 
			this.itemsBindingSource.DataMember = "Items";
			this.itemsBindingSource.DataSource = this.nIFRSDataSet;
			// 
			// nIFRSDataSet
			// 
			this.nIFRSDataSet.DataSetName = "NIFRSDataSet";
			this.nIFRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// itemsTableAdapter
			// 
			this.itemsTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 220);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Trousers";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Firefighter No:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Station Callsign:";
			// 
			// FFNO
			// 
			this.FFNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firefighterBindingSource, "FirefighterID", true));
			this.FFNO.Location = new System.Drawing.Point(113, 67);
			this.FFNO.Name = "FFNO";
			this.FFNO.ReadOnly = true;
			this.FFNO.Size = new System.Drawing.Size(100, 20);
			this.FFNO.TabIndex = 4;
			this.FFNO.TextChanged += new System.EventHandler(this.FFNO_TextChanged);
			// 
			// firefighterBindingSource
			// 
			this.firefighterBindingSource.DataMember = "Firefighter";
			this.firefighterBindingSource.DataSource = this.nIFRSDataSet;
			// 
			// StationNO
			// 
			this.StationNO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.firefighterBindingSource1, "Station", true));
			this.StationNO.Location = new System.Drawing.Point(113, 96);
			this.StationNO.Name = "StationNO";
			this.StationNO.ReadOnly = true;
			this.StationNO.Size = new System.Drawing.Size(100, 20);
			this.StationNO.TabIndex = 5;
			// 
			// firefighterBindingSource1
			// 
			this.firefighterBindingSource1.DataMember = "Firefighter";
			this.firefighterBindingSource1.DataSource = this.nIFRSDataSet;
			// 
			// firefighterTableAdapter
			// 
			this.firefighterTableAdapter.ClearBeforeFill = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Enter Quantity of Items:";
			// 
			// AddWashBagBtn
			// 
			this.AddWashBagBtn.Location = new System.Drawing.Point(504, 246);
			this.AddWashBagBtn.Name = "AddWashBagBtn";
			this.AddWashBagBtn.Size = new System.Drawing.Size(120, 76);
			this.AddWashBagBtn.TabIndex = 8;
			this.AddWashBagBtn.Text = "Print";
			this.AddWashBagBtn.UseVisualStyleBackColor = true;
			this.AddWashBagBtn.Click += new System.EventHandler(this.AddWashBagBtn_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(630, 246);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 76);
			this.button2.TabIndex = 9;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ChkConLbl
			// 
			this.ChkConLbl.AutoSize = true;
			this.ChkConLbl.Location = new System.Drawing.Point(670, 428);
			this.ChkConLbl.Name = "ChkConLbl";
			this.ChkConLbl.Size = new System.Drawing.Size(35, 13);
			this.ChkConLbl.TabIndex = 10;
			this.ChkConLbl.Text = "label5";
			// 
			// randombox
			// 
			this.randombox.Location = new System.Drawing.Point(778, 425);
			this.randombox.Name = "randombox";
			this.randombox.Size = new System.Drawing.Size(10, 20);
			this.randombox.TabIndex = 11;
			this.randombox.Visible = false;
			// 
			// processFlowBindingSource
			// 
			this.processFlowBindingSource.DataMember = "ProcessFlow";
			this.processFlowBindingSource.DataSource = this.nIFRSDataSet;
			// 
			// processFlowTableAdapter
			// 
			this.processFlowTableAdapter.ClearBeforeFill = true;
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 259);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Coverall";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 301);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Tunic";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(14, 347);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Fire Hood";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(17, 236);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 17;
			// 
			// itemInventoryBindingSource
			// 
			this.itemInventoryBindingSource.DataMember = "ItemInventory";
			this.itemInventoryBindingSource.DataSource = this.nIFRSDataSet1;
			// 
			// nIFRSDataSet1
			// 
			this.nIFRSDataSet1.DataSetName = "NIFRSDataSet1";
			this.nIFRSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(17, 275);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 18;
			// 
			// itemInventoryBindingSource1
			// 
			this.itemInventoryBindingSource1.DataMember = "ItemInventory";
			this.itemInventoryBindingSource1.DataSource = this.nIFRSDataSet1;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(17, 317);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 19;
			// 
			// itemInventoryBindingSource2
			// 
			this.itemInventoryBindingSource2.DataMember = "ItemInventory";
			this.itemInventoryBindingSource2.DataSource = this.nIFRSDataSet1;
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(17, 363);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 21);
			this.comboBox4.TabIndex = 20;
			// 
			// itemInventoryBindingSource3
			// 
			this.itemInventoryBindingSource3.DataMember = "ItemInventory";
			this.itemInventoryBindingSource3.DataSource = this.nIFRSDataSet1;
			// 
			// itemInventoryTableAdapter
			// 
			this.itemInventoryTableAdapter.ClearBeforeFill = true;
			// 
			// TrCb2
			// 
			this.TrCb2.FormattingEnabled = true;
			this.TrCb2.Location = new System.Drawing.Point(154, 236);
			this.TrCb2.Name = "TrCb2";
			this.TrCb2.Size = new System.Drawing.Size(121, 21);
			this.TrCb2.TabIndex = 21;
			this.TrCb2.Visible = false;
			// 
			// TrCb3
			// 
			this.TrCb3.FormattingEnabled = true;
			this.TrCb3.Location = new System.Drawing.Point(293, 236);
			this.TrCb3.Name = "TrCb3";
			this.TrCb3.Size = new System.Drawing.Size(121, 21);
			this.TrCb3.TabIndex = 22;
			this.TrCb3.Visible = false;
			// 
			// comboBox9
			// 
			this.comboBox9.FormattingEnabled = true;
			this.comboBox9.Location = new System.Drawing.Point(154, 317);
			this.comboBox9.Name = "comboBox9";
			this.comboBox9.Size = new System.Drawing.Size(121, 21);
			this.comboBox9.TabIndex = 25;
			this.comboBox9.Visible = false;
			// 
			// comboBox10
			// 
			this.comboBox10.FormattingEnabled = true;
			this.comboBox10.Location = new System.Drawing.Point(293, 317);
			this.comboBox10.Name = "comboBox10";
			this.comboBox10.Size = new System.Drawing.Size(121, 21);
			this.comboBox10.TabIndex = 26;
			this.comboBox10.Visible = false;
			// 
			// comboBox11
			// 
			this.comboBox11.FormattingEnabled = true;
			this.comboBox11.Location = new System.Drawing.Point(154, 363);
			this.comboBox11.Name = "comboBox11";
			this.comboBox11.Size = new System.Drawing.Size(121, 21);
			this.comboBox11.TabIndex = 27;
			this.comboBox11.Visible = false;
			// 
			// TunicBtn
			// 
			this.TunicBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TunicBtn.BackgroundImage")));
			this.TunicBtn.Location = new System.Drawing.Point(429, 310);
			this.TunicBtn.Name = "TunicBtn";
			this.TunicBtn.Size = new System.Drawing.Size(31, 32);
			this.TunicBtn.TabIndex = 37;
			this.TunicBtn.UseVisualStyleBackColor = true;
			this.TunicBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// FirehoodBtn
			// 
			this.FirehoodBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirehoodBtn.BackgroundImage")));
			this.FirehoodBtn.Location = new System.Drawing.Point(429, 356);
			this.FirehoodBtn.Name = "FirehoodBtn";
			this.FirehoodBtn.Size = new System.Drawing.Size(31, 32);
			this.FirehoodBtn.TabIndex = 39;
			this.FirehoodBtn.UseVisualStyleBackColor = true;
			this.FirehoodBtn.Click += new System.EventHandler(this.FirehoodBtn_Click);
			// 
			// TrousersBtn
			// 
			this.TrousersBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TrousersBtn.BackgroundImage")));
			this.TrousersBtn.Location = new System.Drawing.Point(429, 229);
			this.TrousersBtn.Name = "TrousersBtn";
			this.TrousersBtn.Size = new System.Drawing.Size(31, 32);
			this.TrousersBtn.TabIndex = 40;
			this.TrousersBtn.UseVisualStyleBackColor = true;
			this.TrousersBtn.Click += new System.EventHandler(this.TrousersBtn_Click);
			// 
			// comboBox12
			// 
			this.comboBox12.FormattingEnabled = true;
			this.comboBox12.Location = new System.Drawing.Point(293, 363);
			this.comboBox12.Name = "comboBox12";
			this.comboBox12.Size = new System.Drawing.Size(121, 21);
			this.comboBox12.TabIndex = 28;
			this.comboBox12.Visible = false;
			// 
			// Request
			// 
			this.Request.FormattingEnabled = true;
			this.Request.Location = new System.Drawing.Point(585, 367);
			this.Request.Name = "Request";
			this.Request.Size = new System.Drawing.Size(106, 21);
			this.Request.TabIndex = 42;
			this.Request.SelectedIndexChanged += new System.EventHandler(this.Request_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(603, 347);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 13);
			this.label8.TabIndex = 43;
			this.label8.Text = "Request Type";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.Location = new System.Drawing.Point(762, 428);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.DividerHeight = 20;
			this.dataGridView1.RowTemplate.Height = 100;
			this.dataGridView1.Size = new System.Drawing.Size(10, 13);
			this.dataGridView1.TabIndex = 44;
			this.dataGridView1.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(458, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(330, 139);
			this.pictureBox1.TabIndex = 45;
			this.pictureBox1.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(0, 401);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 13);
			this.label9.TabIndex = 46;
			this.label9.Text = "Powered By ";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox2.Location = new System.Drawing.Point(77, 401);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(146, 55);
			this.pictureBox2.TabIndex = 47;
			this.pictureBox2.TabStop = false;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(346, 88);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(18, 20);
			this.dataGridView2.TabIndex = 48;
			this.dataGridView2.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Request);
			this.Controls.Add(this.TrousersBtn);
			this.Controls.Add(this.FirehoodBtn);
			this.Controls.Add(this.TunicBtn);
			this.Controls.Add(this.comboBox12);
			this.Controls.Add(this.comboBox11);
			this.Controls.Add(this.comboBox10);
			this.Controls.Add(this.comboBox9);
			this.Controls.Add(this.TrCb3);
			this.Controls.Add(this.TrCb2);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.randombox);
			this.Controls.Add(this.ChkConLbl);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.AddWashBagBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.StationNO);
			this.Controls.Add(this.FFNO);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nIFRSDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.firefighterBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.firefighterBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.processFlowBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemInventoryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nIFRSDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemInventoryBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemInventoryBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemInventoryBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private NIFRSDataSet nIFRSDataSet;
		private System.Windows.Forms.BindingSource itemsBindingSource;
		private NIFRSDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox FFNO;
		private System.Windows.Forms.TextBox StationNO;
		private System.Windows.Forms.BindingSource firefighterBindingSource;
		private NIFRSDataSetTableAdapters.FirefighterTableAdapter firefighterTableAdapter;
		private System.Windows.Forms.BindingSource firefighterBindingSource1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button AddWashBagBtn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label ChkConLbl;
		private System.Windows.Forms.TextBox randombox;
		private System.Windows.Forms.BindingSource processFlowBindingSource;
		private NIFRSDataSetTableAdapters.ProcessFlowTableAdapter processFlowTableAdapter;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox4;
		private NIFRSDataSet1 nIFRSDataSet1;
		private System.Windows.Forms.BindingSource itemInventoryBindingSource;
		private NIFRSDataSet1TableAdapters.ItemInventoryTableAdapter itemInventoryTableAdapter;
		private System.Windows.Forms.BindingSource itemInventoryBindingSource1;
		private System.Windows.Forms.BindingSource itemInventoryBindingSource2;
		private System.Windows.Forms.BindingSource itemInventoryBindingSource3;
		private System.Windows.Forms.ComboBox TrCb2;
		private System.Windows.Forms.ComboBox TrCb3;
		private System.Windows.Forms.ComboBox comboBox9;
		private System.Windows.Forms.ComboBox comboBox10;
		private System.Windows.Forms.ComboBox comboBox11;
		private System.Windows.Forms.Button TunicBtn;
		private System.Windows.Forms.Button FirehoodBtn;
		private System.Windows.Forms.Button TrousersBtn;
		private System.Windows.Forms.ComboBox comboBox12;
		private System.Windows.Forms.ComboBox Request;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DataGridView dataGridView2;
	}
}

