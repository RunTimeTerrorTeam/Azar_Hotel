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
    public partial class WaitForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int SPX, int SPY, int EPX, int EPY, int nWidthEllipse, int nHeightEllipse);
        public WaitForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(5, 5, Width - 5, Height - 5, 10, 10));
            LoadTimer.Start();
        }
        ~WaitForm() { LoadTimer.Stop(); }
        private void Load_Tick(object sender, EventArgs e) { if (WaitShow.Text.Length >= 9) WaitShow.Text = ""; else WaitShow.Text += ". "; }
    }
}
