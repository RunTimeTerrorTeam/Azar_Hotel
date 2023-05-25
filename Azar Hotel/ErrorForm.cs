using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azar_Hotel
{
    public partial class MessageErrorForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn (int SPX, int SPY, int EPX, int EPY, int nWidthEllipse, int nHeightEllipse);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        // <------------------------------------------ Initialized Form ------------------------------->
        public MessageErrorForm() { 
            InitializeComponent();
            ShowInTaskbar = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(5, 5, Width - 4, Height - 4, 12, 12));
        }
        private void Form_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(Handle, 0x112, 0xf012, 0); }
        // <-------------------------------------------- Controler ------------------------------------->
        private void CloseBt_Click(object sender, EventArgs e) { Close(); }
        // <-------------------------------------------- Custom Show ------------------------------------>
        public void show(Form form, string result, string title = "Error") { 
            Msg.Text = result;
            Owner = form;
            Title.Text = title;
            ShowDialog(); 
        }
    }
}
