namespace WindowsFormsApp2
{
	partial class Form2
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
			this.label2 = new System.Windows.Forms.Label();
			this.ChkCon = new System.Windows.Forms.Label();
			this.usrname = new System.Windows.Forms.TextBox();
			this.passwd = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Firefighter NO:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password:";
			// 
			// ChkCon
			// 
			this.ChkCon.AutoSize = true;
			this.ChkCon.Location = new System.Drawing.Point(303, 255);
			this.ChkCon.Name = "ChkCon";
			this.ChkCon.Size = new System.Drawing.Size(35, 13);
			this.ChkCon.TabIndex = 2;
			this.ChkCon.Text = "label3";
			// 
			// usrname
			// 
			this.usrname.Location = new System.Drawing.Point(133, 106);
			this.usrname.Name = "usrname";
			this.usrname.Size = new System.Drawing.Size(100, 20);
			this.usrname.TabIndex = 3;
			// 
			// passwd
			// 
			this.passwd.Location = new System.Drawing.Point(133, 135);
			this.passwd.Name = "passwd";
			this.passwd.PasswordChar = '*';
			this.passwd.Size = new System.Drawing.Size(100, 20);
			this.passwd.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(281, 106);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(182, 49);
			this.button1.TabIndex = 5;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(92, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(300, 26);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fire Kit Maintenance System";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(475, 277);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.passwd);
			this.Controls.Add(this.usrname);
			this.Controls.Add(this.ChkCon);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label ChkCon;
		private System.Windows.Forms.TextBox usrname;
		private System.Windows.Forms.TextBox passwd;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
	}
}

