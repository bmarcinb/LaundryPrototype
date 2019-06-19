using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using DGVPrinterHelper;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form3 : Form
	{
		OleDbConnection connection = new OleDbConnection();
		private OleDbCommand command = new OleDbCommand(); 
		public string Firefighter = "";
		public string Station = "";
		public string StartB = "*";
		public string StopB = "*";
		public string barcode = "";
		public string checkemptytt = "";
		public string checkemptyth = "";
		public string checkemptytut = "";
		public string checkemptytuth = "";
		public string checkemptyfht = "";
		public string checkemptyfhth = "";
		public string date = "";
		public string time = "";
		


		public Form3()
		{
			InitializeComponent();
			
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			try
			{

				connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Marcin\Documents\FireServicePrototype\FireServicePrototype\WindowsFormsApp1\NIFRS.accdb";
				connection.Open();
				

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
			ReadDataToGrid();
		}

		private void ReadDataToGrid()
		{
			try
			{
				connection.Open();
				command.Connection = connection;


				string query = "SELECT * FROM ProcessFlow WHERE ID = (SELECT MAX(ID)  FROM ProcessFlow)";

				command.CommandText = query;
				OleDbDataReader reader = command.ExecuteReader();
				using(OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
				{
					DataSet ds = new DataSet();
					
					
					adapter.Fill(ds);
					dataGridView1.DataSource = ds.Tables[0];
					DataGridViewRow rowtemp = this.dataGridView1.RowTemplate;
					
					this.dataGridView1.Columns["ID"].Visible = false;
					this.dataGridView1.Columns["FirefighterID"].Visible = false;
					this.dataGridView1.Columns["Station"].Visible = false;
					this.dataGridView1.Columns["BagSerialNo"].Visible = false;
					this.dataGridView1.Columns["DateUpdate"].Visible = false;
					this.dataGridView1.Columns["TimeUpdate"].Visible = false;
					this.dataGridView1.Columns["Item1_RFID"].Visible = false;
					this.dataGridView1.Columns["Item2_RFID"].Visible = false;
					this.dataGridView1.Columns["Item3_RFID"].Visible = false;
					//this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
					//this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
					
					

					while (reader.Read())
					{
						Firefighter = (reader["FirefighterID"].ToString());
						Station = (reader["Station"].ToString());
						barcode = (reader["BagSerialNo"].ToString());
						checkemptytt = (reader["Trousers_Two"].ToString());
						checkemptyth = (reader["Trousers_Three"]).ToString();
						checkemptyfht = (reader["FireHood_Two"].ToString());
						checkemptyfhth = (reader["FireHood_Three"].ToString());
						checkemptytut = (reader["Tunic_Two"].ToString());
						checkemptytuth = (reader["Tunic_Three"].ToString());
						date = (reader["DateUpdate"].ToString());
						time = (reader["TimeUpdate"].ToString());

					}

					connection.Close();

					if (string.IsNullOrEmpty(checkemptytt))
					{
						this.dataGridView1.Columns["Trousers_Two"].Visible = false;
					}
					if (string.IsNullOrEmpty(checkemptyth))
					{
						this.dataGridView1.Columns["Trousers_Three"].Visible = false;
					}
					if (string.IsNullOrEmpty(checkemptyfht))
					{
						this.dataGridView1.Columns["FireHood_Two"].Visible = false;
					}
					if (string.IsNullOrEmpty(checkemptyfhth))
					{
						this.dataGridView1.Columns["FireHood_Three"].Visible = false; 
					}
					if (string.IsNullOrEmpty(checkemptytut))
					{
						this.dataGridView1.Columns["Tunic_Two"].Visible = false;
					}
					if (string.IsNullOrEmpty(checkemptytuth))
					{
						this.dataGridView1.Columns["Tunic_Three"].Visible = false;
					}

				}
			
			
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
		}

		private void PrintData()
		{
			Font font1 = new Font("Free 3 of 9 Extended", 60);
			DGVPrinter printer = new DGVPrinter();
			printer.Title = StartB + barcode + StopB + "\r\n\r\n\r\n";
			printer.TitleFont = font1;
			printer.SubTitle = "Firefighter ID:   " + Firefighter + "\r\n" + "Station:  " + Station + "\r\n\r\n\r\n\r\n";
			printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
			printer.SubTitleSpacing = 30;
			printer.PageNumbers = true;
			printer.PageNumberInHeader = false;
			printer.PorportionalColumns = true;
			printer.HeaderCellAlignment = StringAlignment.Near;
			printer.Footer = "Date: " + date + "  Time:  " + time ;
			printer.FooterSpacing = 15;
			printer.printDocument.DefaultPageSettings.Landscape = true;
			printer.RowHeight = DGVPrinter.RowHeightSetting.DataHeight;
			printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;
			DGVPrinter.ImbeddedImage image1 = new DGVPrinter.ImbeddedImage();
			image1.ImageAlignment = DGVPrinter.Alignment.NotSet;
			image1.ImageLocation = DGVPrinter.Location.Absolute;
			image1.ImageX = 0;
			image1.ImageY = 0;
			image1.theImage = new Bitmap("C:/Users/Marcin/Desktop/NIFRS/Shared/NIFRS_logo.png");
			printer.ImbeddedImageList.Add(image1);
			printer.PrintPreviewDataGridView(dataGridView1);
	
		}

		public void btnclicktrigger()
		{
			button1.PerformClick();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PrintData();
		}
	}
}
