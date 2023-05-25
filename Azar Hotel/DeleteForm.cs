using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azar_Hotel
{
    public partial class DeleteForm : Form
    {
        public int ID;
        string TabelName;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int SPX, int SPY, int EPX, int EPY, int nWidthEllipse, int nHeightEllipse);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public DeleteForm(string TabelName, string Title)
        {
            InitializeComponent();
            this.TabelName = TabelName;
            this.Title.Text = Title;
            ShowInTaskbar = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(5, 5, Width - 4, Height - 4, 12, 12));
        }

        private void Form_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(Handle, 0x112, 0xf012, 0); }
        private void CloseBt_Click(object sender, EventArgs e) { Close(); }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            WarningForm warning = new WarningForm();
            warning.Owner = this;
            if (int.TryParse(Username.Text, out ID))
            {
                SqlCommand command = new SqlCommand("Select count(*) from " + TabelName + " Where ID" + " = " + ID, MainForm.connection);
                if ((int)command.ExecuteScalar() != 0)
                {
                    warning.ShowDialog();
                    if(warning.action)
                    {
                        if (TabelName == "ORDERS" ||TabelName == "RESERVED_ROOMS") command.CommandText = "Delete " + TabelName + " Where ID = " + ID;
                        else command.CommandText = "Update " + TabelName + " set Available = 0 where ID = " + ID;
                        try
                        {
                            command.ExecuteNonQuery();
                            CorrectForm correct = new CorrectForm();
                            correct.show(this, "Delete Successfully");
                            Close();
                        } catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    } 
                } else MainForm.errorForm.show(this, "This ID Not Found.\r\nPlease Try agin.");
            }  
            else  MainForm.errorForm.show(this, "This is Not Number.\r\nPlease Try agin.");
        }
    }
}
