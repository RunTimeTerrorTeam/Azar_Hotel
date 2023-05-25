using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Azar_Hotel
{
    public partial class AddClientForm : Form
    {
        public string forms;
        string tabelName = "GUESTS";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int SPX, int SPY, int EPX, int EPY, int nWidthEllipse, int nHeightEllipse);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public AddClientForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Region = Region.FromHrgn(CreateRoundRectRgn(5, 5, Width - 4, Height - 4, 12, 12));
        }

        private void Form_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(Handle, 0x112, 0xf012, 0); }
        private void CloseBt_Click(object sender, EventArgs e) { Close(); }
        private void FirstNameBox_TextChanged(object sender, EventArgs e) { FirstNameLabel.Visible = FirstNameBox.Text.Length != 0; }
        private void StreetBox_TextChanged(object sender, EventArgs e) { StreetLabel.Visible = StreetBox.Text.Length != 0; }
        private void EmailBox_TextChanged(object sender, EventArgs e) { EmailLabel.Visible = EmailBox.Text.Length != 0; }
        private void PhoneNumberBox_TextChanged(object sender, EventArgs e) { PhoneNumberLabel.Visible = PhoneNumberBox.Text.Length != 0; }
        private void NationalIDBox_TextChanged(object sender, EventArgs e) { NationalIDLabel.Visible = NationalIDBox.Text.Length != 0; }
        private void CountryBox_TextChanged(object sender, EventArgs e) { CountryLabel.Visible = CountryBox.Text.Length != 0; }
        private void CityBox_TextChanged(object sender, EventArgs e) { CityLabel.Visible = CityBox.Text.Length != 0; }
        private void LastNameBox_TextChanged(object sender, EventArgs e) { LastNameLabel.Visible = LastNameBox.Text.Length != 0; }
        private void AddBt_Click(object sender, EventArgs e)
        {
            if (!CHandel.isString(FirstNameBox.Text)) MainForm.errorForm.show(this, "Firstname is Not Valid.");
            else if (!CHandel.isString(LastNameBox.Text)) MainForm.errorForm.show(this, "LastName is Not Valid.");
            else if (!CHandel.isEmail(EmailBox.Text)) MainForm.errorForm.show(this, "Email is Not Vaild.");
            else if (!CHandel.isPhone(PhoneNumberBox.Text)) MainForm.errorForm.show(this, "Phonenumber is Not Valid.");
            else if (!CHandel.isInteger(NationalIDBox.Text)) MainForm.errorForm.show(this, "National ID is Not Valid.");
            else if (!CHandel.isString(CountryBox.Text)) MainForm.errorForm.show(this, "Country is Not Valid.");
            else if (!CHandel.isString(CityBox.Text)) MainForm.errorForm.show(this, "City is Not Valid.");
            else if (!CHandel.isString(StreetBox.Text)) MainForm.errorForm.show(this, "Street is Not Valid.");
            else
            {
                if (COUNT("WHERE EMAIL = '" + EmailBox.Text + "'") != 0) MainForm.errorForm.show(this, "Email already exists.");
                else if (COUNT("WHERE PhoneNumber = '" + PhoneNumberBox.Text + "'") != 0) MainForm.errorForm.show(this, "Phone Number already exists.");
                else if (COUNT("WHERE National_ID = '" + NationalIDBox.Text + "'") != 0) MainForm.errorForm.show(this, "National ID already exists.");
                else
                {
                    SqlCommand command = new SqlCommand("INSERT INTO " + tabelName + "(Name, Email, PhoneNumber, Gender, BirthDate, Address, National_ID)" +
                        "VALUES ('" + FirstNameBox.Text + " " + LastNameBox.Text + "', '" + EmailBox.Text + "', '" + PhoneNumberBox.Text + "', " + (GenderOption1.Checked == true ? 0 : 1) + ", '" +
                        BirthdatePicker.Value.ToString("yyyy/M/dd") + "', '" + CountryBox.Text + ", " + CityBox.Text + ", " + StreetBox.Text + "', '" + NationalIDBox.Text + "')", MainForm.connection);
                    try
                    {
                        command.ExecuteNonQuery();
                        MainForm.correct = new CorrectForm();
                        MainForm.correct.show(this, "Add Succecfully.");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MainForm.errorForm.show(this, ex.Message);
                    }
                }
            }
        }

        int COUNT(string condition = "")
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM " + tabelName + " " + condition, MainForm.connection);
            return (int)command.ExecuteScalar();
        }
    }
}
