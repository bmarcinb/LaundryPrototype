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
using DGVPrinterHelper;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public int randomNumber;
		public int TrouserCounter = 0;
		public int FirehoodCounter = 0;
		public int TunicCounter = 0;
		public string TrouserRfid = "";
		public string TrouserRfid2 = "";
		public DateTime JustDate = DateTime.Now;
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
		public string checkemptytuo = "";
		public string checkemtpyto = "";
		public string checkemptyca = "";
		public string checkemptyfo = "";
		public string date = "";
		public string time = "";
		public string selectedtrone = "";
		public string status = "";
		public string Requesttype = "";
		public string FireFighterName = "";
	
		private OleDbConnection connection = new OleDbConnection();

		private OleDbCommand command = new OleDbCommand();

	
	

		public Form1()
		{
			InitializeComponent();
			connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Marcin\Documents\FireServicePrototype\FireServicePrototype\WindowsFormsApp1\NIFRS.accdb";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			FFNO.Text = WindowsFormsApp2.Form2.PassingUsrName;
			Request.SelectedText = "Laundry";
			Request.Items.Add("Laundry + Repair");
			Request.Items.Add("Repair Only");
			Request.Items.Add("Decontamination");
			Request.Items.Add("Inspection");

			NameGenerating();
			AddStationName();
			CoverallBox();
			TrousersBox();
			FireHoodBox();
			TunicBox();
			
			

		}

		private void TrousersBox()
		{
			try
			{
				connection.Open();
				command.Connection = connection;

				string query3 = "select * From [ItemInventory] WHERE FireFighterID='" + FFNO.Text + "' AND Category= ('Trousers')";
				
				command.CommandText = query3;
	
				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox1.Items.Add(reader["Barcode"].ToString());
					TrCb2.Items.Add(reader["Barcode"].ToString());
					TrCb3.Items.Add(reader["Barcode"].ToString());
					
				}
				ChkConLbl.Text = "Connection is Established";
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
		}

		public void  RFIDSorting()
		{
			connection.Open();
			command.Connection = connection;
			string query6 = "select * From [ItemInventory] WHERE Barcode='" + comboBox1.Text+ "' AND Category= ('Trousers')";

			command.CommandText = query6;
			

			OleDbDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				TrouserRfid = (reader["RFID_Code"].ToString());
				
			}
			connection.Close();
		}

		public void RFIDSorting2()
		{
			connection.Open();
			command.Connection = connection;
			string query7 = "select * From [ItemInventory] WHERE Barcode='" + TrCb2.Text + "' AND Category= ('Trousers')";

			command.CommandText = query7;


			OleDbDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				TrouserRfid2 = (reader["RFID_Code"].ToString());

			}
			connection.Close();
		}



		private void FireHoodBox()
		{
			try
			{
				connection.Open();
				command.Connection = connection;

				string query4 = "select * From [ItemInventory] WHERE FireFighterID='" + FFNO.Text + "' AND Category= ('FireHood')";

				command.CommandText = query4;

				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox4.Items.Add(reader["Barcode"].ToString());
					comboBox11.Items.Add(reader["Barcode"].ToString());
					comboBox12.Items.Add(reader["Barcode"].ToString());

				}
			
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
		}

		private void TunicBox()
		{
			try
			{
				connection.Open();
				command.Connection = connection;

				string query = "select * From [ItemInventory]WHERE FireFighterID='" + FFNO.Text + "' AND Category= ('Tunic')";

				command.CommandText = query;

				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox3.Items.Add(reader["Barcode"].ToString());
					comboBox9.Items.Add(reader["Barcode"].ToString());
					comboBox10.Items.Add(reader["Barcode"].ToString());

				}
				
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
		}

		private void CoverallBox()
		{
			try
			{
				connection.Open();
				command.Connection = connection;


				string query2 = "select * From [ItemInventory] WHERE FireFighterID='" + FFNO.Text + "' AND Category= ('Coverall')";

				command.CommandText = query2;
				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox2.Items.Add(reader["Barcode"].ToString());

				}
				
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
		}


		private void AddStationName()
		{
			try
			{
				connection.Open();
				command.Connection = connection;


				string query5 = "select * From [Firefighter] WHERE FireFighterID='"+FFNO.Text+"'";

				command.CommandText = query5;
				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					StationNO.Text= (reader["Station"].ToString());

				}
		
				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
		}

		private void NameGenerating()
		{
			try
			{
				connection.Open();
				command.Connection = connection;


				string query5 = "select * From [Firefighter] WHERE FireFighterID='" + FFNO.Text + "'";

				command.CommandText = query5;
				OleDbDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					FireFighterName = (reader["Name"].ToString());

				}

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex);
			}
}


			public void BarcodeGenerator() { 
				Random rand = new Random(Guid.NewGuid().GetHashCode());
				randomNumber = rand.Next(900000, 999999);
				//Console.WriteLine("B" + randomNumber);
			}
	
		private void AddWashBagBtn_Click(object sender, EventArgs e)
		{
			
			BarcodeGenerator();
			RFIDSorting();
			RFIDSorting2();
		
				try
				{
					connection.Open();
					command.Connection = connection;
					command.CommandText = "INSERT into ProcessFlow (FirefighterID, Station, BagSerialNo, Trousers_One, Coverall, FireHood_One, Tunic_One, Trousers_Two," +
					" Trousers_Three, FireHood_Two, FireHood_Three, Tunic_Two, Tunic_Three, Item1_RFID, Item2_RFID, Status, DateUpdate, TimeUpdate, Request_Type) values ('" + FFNO.Text + "' , '" + StationNO.Text + "' , '" + randomNumber + "','" + comboBox1.Text + "', " +
					 "'" + comboBox2.Text + "', '"+ comboBox3.Text + "', '" + comboBox4.Text + "' , '" + TrCb2.Text + "', '" + TrCb3.Text + "' ," +
					" '" + comboBox11.Text + "', '" + comboBox12.Text + "', '" + comboBox9.Text + "' , '" + comboBox10.Text + "','" + TrouserRfid + "', '" + TrouserRfid2 + "','" + ("Ready for Collection") +"','" +JustDate.ToString("dd/MM/yyyy")+ "', '" + DateTime.Now.ToString("HH:mm:ss") + "', '" +Request.Text+ "')";
					command.ExecuteNonQuery();
					MessageBox.Show("Successfully added");
				connection.Close();
				ReadDataToGrid();
				PrintData();
				//PrintData2();
				
			}
				catch (Exception er)
				{
					MessageBox.Show("Error" + er);
				}
				
				

			}

		private void FFNO_TextChanged(object sender, EventArgs e)
		{

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
				using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
				{
					DataSet ds = new DataSet();


					adapter.Fill(ds);
					dataGridView1.DataSource = ds.Tables[0];
					DataRow dr;
					dr = ds.Tables[0].NewRow();
					ds.Tables[0].Rows.Add(dr);
					



					this.dataGridView1.Columns["ID"].Visible = false;
					this.dataGridView1.Columns["FirefighterID"].Visible = false;
					this.dataGridView1.Columns["Station"].Visible = false;
					this.dataGridView1.Columns["BagSerialNo"].Visible = false;
					this.dataGridView1.Columns["DateUpdate"].Visible = false;
					this.dataGridView1.Columns["TimeUpdate"].Visible = false;
					this.dataGridView1.Columns["Item1_RFID"].Visible = false;
					this.dataGridView1.Columns["Item2_RFID"].Visible = false;
					this.dataGridView1.Columns["Item3_RFID"].Visible = false;
					this.dataGridView1.Columns["Request_Type"].Visible = false;
					this.dataGridView1.Columns["Status"].Visible = false;



					//DataGridFormatting
					this.dataGridView1.Columns["Trousers_One"].Width = 70;
					this.dataGridView1.Columns["Tunic_One"].Width = 70;
					this.dataGridView1.Columns["Coverall"].Width = 70;
					this.dataGridView1.Columns["FireHood_One"].Width = 70;
					this.dataGridView1.Columns["Trousers_Two"].Width = 70;
					this.dataGridView1.Columns["Tunic_Two"].Width = 70;
					this.dataGridView1.Columns["FireHood_Two"].Width = 70;
					this.dataGridView1.Columns["Trousers_Three"].Width = 70;
					this.dataGridView1.Columns["Tunic_Three"].Width = 70;
					this.dataGridView1.Columns["FireHood_Three"].Width = 70;
					
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
						checkemptytuo = (reader["Tunic_One"].ToString());
						checkemptyfo = (reader["FireHood_One"].ToString());
						checkemptyca = (reader["Coverall"].ToString());
						checkemtpyto = (reader["Trousers_One"].ToString());
						status = (reader["Status"].ToString());
						Requesttype = (reader["Request_Type"].ToString());
						date = (reader["DateUpdate"].ToString());
						time = (reader["TimeUpdate"].ToString());
					}

					connection.Close();
						
				
					if (string.IsNullOrEmpty(checkemptyca))
					{
						this.dataGridView1.Columns["Coverall"].Visible = false;
					}

					if (string.IsNullOrEmpty(checkemptyfo))
					{
						this.dataGridView1.Columns["FireHood_One"].Visible = false;
					}
		
					if (string.IsNullOrEmpty(checkemptytuo))
					{
						this.dataGridView1.Columns["Tunic_One"].Visible = false;
					}

					if (string.IsNullOrEmpty(checkemtpyto))
					{
						this.dataGridView1.Columns["Trousers_One"].Visible = false;
					}

					if (string.IsNullOrEmpty(checkemptytt))
					{
						this.dataGridView1.Columns["Trousers_Two"].Visible = false;
					}

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
			Font font2 = new Font("Arial", 20);
			DGVPrinter printer = new DGVPrinter();
			printer.Title = StartB + barcode + StopB + "\r\n";
			printer.DocName = "FireKitMaintenanceReport";
			printer.TitleFont = font1;
			printer.SubTitle =   barcode + "\r\n" + "Firefighter Name: " + FireFighterName + "\r\n" + "Firefighter ID:   " + Firefighter + "\r\n" + "Station:  " + Station + "\r\n\r\n\r\n\r\n";
			printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
			printer.SubTitleSpacing = 30;
			printer.SubTitleFont = font2;
			printer.PageNumbers = false;
			printer.PageNumberInHeader = false;
			printer.PorportionalColumns = true;
			printer.HeaderCellAlignment = StringAlignment.Near;
			printer.Footer = "Request Type: " + Requesttype + "\r\n" + "Status:  " + status + "\r\n"+ "Date: " + date + "  Time:  " + time;
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

		private void PrintData2()
		{
			Font font1 = new Font("Free 3 of 9 Extended", 60);
			DGVPrinter printer = new DGVPrinter();
			printer.Title = StartB + barcode + StopB + "\r\n\r\n";
			printer.TitleFont = font1;
			printer.SubTitle = "Request Type: " + Requesttype + "\r\n" + "Status:  " + status + "\r\n\r\n\r\n" + "Firefighter ID:   " + Firefighter + "\r\n" + "Station:  " + Station + "\r\n\r\n\r\n\r\n";
			printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
			printer.SubTitleSpacing = 30;
			printer.PageNumbers = true;
			printer.PageNumberInHeader = false;
			printer.PorportionalColumns = true;
			printer.HeaderCellAlignment = StringAlignment.Near;
			printer.Footer = "Date: " + date + "  Time:  " + time;
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
			printer.PrintPreviewDataGridView(dataGridView2);
		}


		private void button1_Click(object sender, EventArgs e)
		{
			TunicCounter++;

			if (TunicCounter == 1)
			{
				comboBox9.Visible = true;
			}
			if (TunicCounter == 2)
			{
				comboBox10.Visible = true;
			}
		}

		private void TrousersBtn_Click(object sender, EventArgs e)
		{
			TrouserCounter++;

			if (TrouserCounter == 1)
			{
				TrCb2.Visible = true;
			}
			if (TrouserCounter == 2)
			{
				TrCb3.Visible = true;
			}
		}

		private void FirehoodBtn_Click(object sender, EventArgs e)
		{
			FirehoodCounter++;

			if (FirehoodCounter == 1)
			{
				comboBox11.Visible = true;
			}
			if (FirehoodCounter == 2)
			{
				comboBox12.Visible = true;
			}
		}

		private void Request_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
			connection.Close();
			connection.Dispose();
		}
	}
	}
	

