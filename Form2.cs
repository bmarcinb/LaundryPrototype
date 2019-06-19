using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApp2
{
	public partial class Form2 : Form
	{
		OleDbConnection connection = new OleDbConnection();

		public static string PassingUsrName = "";

		public Form2()
		{
			InitializeComponent();
			AcceptButton = button1;

		}

		

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{

				connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Marcin\Documents\FireServicePrototype\FireServicePrototype\WindowsFormsApp1\NIFRS.accdb";
				connection.Open();
				ChkCon.Text = "Connection is Established";

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

			connection.Open();
			OleDbCommand command = new OleDbCommand();
			command.Connection = connection;
			command.CommandText = "SELECT * FROM Table1 where FFID='" + usrname.Text + "' and Password='" + passwd.Text + "'";
			
			OleDbDataReader reader = command.ExecuteReader();
			int count = 0;

			while (reader.Read())
			{
				count = count + 1;
			}
			if (count == 1)
			{
				MessageBox.Show("Username and Password are Correct");
				connection.Close();
				connection.Dispose();
				this.Hide();
				WindowsFormsApp1.Form1 f1 = new WindowsFormsApp1.Form1();
				PassingUsrName = usrname.Text;
				f1.ShowDialog();
			}
			if (count > 1)
			{
				MessageBox.Show("Username and Password is not correct");
			}
			



			connection.Close();
		}

		private void txtinput_Keyup(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				button1.PerformClick();
			}
		}
	}
}
