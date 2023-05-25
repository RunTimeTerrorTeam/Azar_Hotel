using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Azar_Hotel
{
    public partial class SignInForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int SPX, int SPY, int EPX, int EPY, int nWidthEllipse, int nHeightEllipse);
        // <--------------------------------- Setup Form ------------------------------------------->
        string result = string.Empty;
        public SignInForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }
        private void FormMouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(Handle, 0x112, 0xf012, 0); }
        // <------------------------------------ Header -------------------------------------------->
        private void btClose_Click(object sender, EventArgs e) { Application.Exit(); } 
        private void btMin_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        // <---------------------------------- Label Password -------------------------------------->
        private void Password_TextChanged(object sender, EventArgs e) { Password.UseSystemPasswordChar = Password.Text != ""; }
        private void RightIconOnHover(object sender, EventArgs e) { Password.UseSystemPasswordChar = false; }
        private void RightIconToDefault(object sender, EventArgs e) { Password.UseSystemPasswordChar = true; }
        // <------------------------------------- LogIn Click -------------------------------------->
        private void LogIn_Click(object sender, EventArgs e) { backGroundWorker.RunWorkerAsync(); }
        
        private void backGroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Username.Text == "" && Password.Text == "") 
                result = "Fildes Are Empty.\r\nPlease Fill Fildes.";
            else if (Username.Text == "") 
                result = "Username is Empty.\r\nPlease Input Username.";
            else if (Password.Text == "") 
                result = "Password is Empty.\r\nPlease Input Password.";
            else {
                SqlCommand command = new SqlCommand("SELECT * FROM DB_INFO WHERE USERNAME = '"+ Username.Text  + "'", MainForm.connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if ((string)reader["PASSWORD"] == Password.Text)
                    {
                        if ((bool)reader["Available"])
                        {
                            MainForm.ID = (int)reader["Employee_ID"];
                            command.CommandText = "INSERT INTO LOGIN(DB_ID) VALUES (" + (int)reader["ID"] + ")";
                            reader.Close();
                            command.ExecuteNonQuery();
                        }
                        else result = "This User Can't Access To The Database.";
                    } 
                    else result = "Wrong Password Try agian.";
                }
                else result = "Username NoT Found.";
                reader.Close();
            }
        }

        private void backGroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (result != "") MainForm.errorForm.show(this, result);
            else
            {
                Hide();
                Username.Text = Password.Text = string.Empty;
                MainForm.dashBoard = new DashBoardForm();
                MainForm.dashBoard.Show();
            }
            result = string.Empty;
        }
    }
}
