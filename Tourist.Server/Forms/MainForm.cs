using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Tourist.Server.Forms
{
	public partial class MainForm : MetroForm
	{

		public MainForm( )
		{
			InitializeComponent( );
		}

		private void MainForm_Load( object sender, EventArgs e )
		{
			SetFullScreen( );
			TimerClock.Start( );//conta segundos relogio
		}

		private void SetFullScreen( )
		{
			int x = Screen.PrimaryScreen.Bounds.Width;
			int y = Screen.PrimaryScreen.Bounds.Height;
			Location = new Point( 0, 0 );
			Size = new Size( x, y );
		}

		private void TimerClock_Tick( object sender, EventArgs e )
		{

			ClockLabel.Text = DateTime.Now.ToString( "HH:mm:ss" );

			if ( DateTime.Today.Hour >= 12 && DateTime.Today.Minute >= 0 )
				AmPmLabel.Text = "PM";
			else
				AmPmLabel.Text = "AM";

			if (DateTime.Today.Day < 10)
				DayNumberLabel.Text = "0" + DateTime.Today.Day;
			else 
				DayNumberLabel.Text = DateTime.Today.Day.ToString();
			

			DayOfWeekLabel.Text = DateTime.Today.DayOfWeek.ToString( );
			MonthNameLabel.Text = MonthsName( DateTime.Today.Month );
			YearLabel.Text = DateTime.Today.Year.ToString( );

		}

		private string MonthsName( int aMonth )
		{
			switch ( aMonth )
			{
				case 1: return "January";
				case 2: return "February";
				case 3: return "March";
				case 4: return "April";
				case 5: return "May";
				case 6: return "June";
				case 7: return "July";
				case 8: return "August";
				case 9: return "September";
				case 10: return "October";
				case 11: return "November";
				case 12: return "December";
				default: return "Error";
			}
		}

		private void ClientsTile_Click( object sender, EventArgs e )
		{
			ClientsForm clients = new ClientsForm();
			clients.Show();
		}

		//ver melhor 
		private void MainForm_MouseMove( object sender, MouseEventArgs e )
		{
			int x = SideBarPanel.Location.X;
			int y = SideBarPanel.Location.Y;

			if (x <= e.X && y <= e.Y)
				SideBarPanel.Visible = true;
			else
				SideBarPanel.Visible = false;	
		}

	
	}
}
