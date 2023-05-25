using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Azar_Hotel
{
    public partial class AddRoomsForm : Form
    {
        Bunifu.UI.WinForms.BunifuButton.BunifuButton button;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int SPX, int SPY, int EPX, int EPY, int nWidthEllipse, int nHeightEllipse);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public AddRoomsForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(5, 5, Width - 4, Height - 4, 12, 12));
            button = Tab2;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(Handle, 0x112, 0xf012, 0); }
        private void btClose_Click(object sender, EventArgs e) { Close(); }

        private void Tab1_Click(object sender, EventArgs e)
        {
            Tab1.Enabled = false;
            button.Enabled = true;
            button = Tab1;
            Pages.PageIndex = 1;
        }

        private void Tab2_Click(object sender, EventArgs e)
        {
            Tab2.Enabled = false;
            button.Enabled = true;
            button = Tab2;
            Pages.PageIndex = 0;
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("", MainForm.connection);
            if (button.Text == Tab1.Text)
            {
                command.CommandText = "INSERT INTO ROOMS (Section, Room_Number, Floor, Type, Price) " +
                    "VALUES ('" + SectionBox.Text + "', '" + RoomNumberBox.Text + "', '" + FloorBox.Text + "', '" + RoomTypeBox.Text + "', '" + PriceBox.Text + "')";
            }
            else
            {
                command.CommandText = "INSERT INTO  RESERVED_ROOMS (Contract, Expiry, Guest_ID, Room_ID, Employee_id) " +
                    "VALUES ('" + ContractDatePicker.Value.ToString("yyyy/M/dd") + "', '" + ExpirdatePicker.Value.ToString("yyyy/M/dd") + "', '" + GuestIDBox.Text + "', '" + RoomIDBox.Text + "', '" + MainForm.ID + "')";
            }
            try
            {
                command.ExecuteNonQuery();
                MainForm.correct = new CorrectForm();
                MainForm.correct.show(this, "Add Succecfully.");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MainForm.errorForm.show(this, "Error : " + ex);
            }
        }

        private void RoomTypeBox_TextChanged(object sender, EventArgs e) { RoomTypeLabel.Visible = RoomTypeBox.Text.Length != 0; }
        private void SectionBox_TextChanged(object sender, EventArgs e) { SectionLabel.Visible = SectionBox.Text.Length != 0; }
        private void RoomNumberBox_TextChanged(object sender, EventArgs e) { RoomNumberLabel.Visible = RoomNumberBox.Text.Length != 0; }
        private void PriceBox_TextChanged(object sender, EventArgs e) { PriceLabel.Visible = PriceBox.Text.Length != 0; }
        private void FloorBox_TextChanged(object sender, EventArgs e) { FloorLabel.Visible = FloorBox.Text.Length != 0; }
        private void GuestIDBox_TextChanged(object sender, EventArgs e) { GuestIDLabel.Visible = GuestIDBox.Text.Length != 0; }
        private void RoomIDBox_TextChanged(object sender, EventArgs e) { RoomIDLabel.Visible = RoomIDBox.Text.Length != 0; }

        private void ContractDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ExpirdatePicker.MinDate = ContractDatePicker.Value.AddDays(1);
            ExpirdatePicker.Value = ExpirdatePicker.MinDate;
        }
    }
}
