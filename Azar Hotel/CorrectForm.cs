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
    public partial class CorrectForm : Form
    {
        int count = 0;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int SPX, int SPY, int EPX, int EPY, int nWidthEllipse, int nHeightEllipse);
        public CorrectForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(5, 5, Width - 4, Height - 4, 12, 12));
            Opacity = 0.7;
        }

        public void show(Form form, string message)
        {
            Owner = form;
            Msg.Text = message;
            TimerLoad.Start();
            ShowDialog();
        }

        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            count += 1;
            Opacity += 0.05;
            if (count == 20) Close();
        }

        ~CorrectForm() { TimerLoad.Stop(); }
    }
}
