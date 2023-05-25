using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace Azar_Hotel
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int SPX, int SPY, int EPX, int EPY, int nWidthEllipse, int nHeightEllipse);
        // <------------------------------------------- Start Initialize Static Elements ------------------------------------------->
        public static SignInForm signIn = new SignInForm();
        public static DashBoardForm dashBoard;
        public static SqlConnection connection = new SqlConnection("Data Source=PC;Initial Catalog=AZAR_HOTEL;Integrated Security=True");
        public static WarningForm Warning = new WarningForm();
        public static MessageErrorForm errorForm = new MessageErrorForm();
        public static CorrectForm correct = new CorrectForm();
        public static int ID;
        public static int acsses;
        // <-------------------------------------------- End Initialize Static Elements -------------------------------------------->
        public MainForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(5, 5, Width - 5, Height - 5, 10, 10));
            LoadTimer.Start();
            ConnectionDB.RunWorkerAsync();
        }

        private void LoadTimer_Tick(object sender, EventArgs e) 
        { 
            if (WaitShow.Text.Length >= 9) WaitShow.Text = ""; 
            else WaitShow.Text += ". "; 
        }

        private void ConnectionDB_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try { 
                connection.Open();
                Thread.Sleep(1500);
            }
            catch {}
        }

        private void ConnectionDB_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            LoadTimer.Stop();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                Hide();
                signIn.Show();
            } 
            else
            {
                errorForm.show(this, "Error In Connect To DataBase.");
                Application.Exit();
            }
            
        }
    }
}
