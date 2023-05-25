using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Azar_Hotel
{
    public partial class AddEmployeeForm : Form
    {
        Bunifu.UI.WinForms.BunifuButton.BunifuButton button;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int SPX, int SPY, int EPX, int EPY, int nWidthEllipse, int nHeightEllipse);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public AddEmployeeForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(5, 5, Width - 4, Height - 4, 12, 12));
            button = Tab3;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(Handle, 0x112, 0xf012, 0); }
        private void btClose_Click(object sender, EventArgs e) { Close(); }
        private void FirstNameBox_TextChanged(object sender, EventArgs e) { FirstNameLabel.Visible = FirstNameBox.Text.Length != 0; }
        private void StreetBox_TextChanged(object sender, EventArgs e) { StreetLabel.Visible = StreetBox.Text.Length != 0; }
        private void EmailBox_TextChanged(object sender, EventArgs e) { EmailLabel.Visible = EmailBox.Text.Length != 0; }
        private void PhoneNumberBox_TextChanged(object sender, EventArgs e) { PhoneNumberLabel.Visible = PhoneNumberBox.Text.Length != 0; }
        private void NationalIDBox_TextChanged(object sender, EventArgs e) { NationalIDLabel.Visible = NationalIDBox.Text.Length != 0; }
        private void CountryBox_TextChanged(object sender, EventArgs e) { CountryLabel.Visible = CountryBox.Text.Length != 0; }
        private void CityBox_TextChanged(object sender, EventArgs e) { CityLabel.Visible = CityBox.Text.Length != 0; }
        private void LastNameBox_TextChanged(object sender, EventArgs e) { LastNameLabel.Visible = LastNameBox.Text.Length != 0; }
        private void DepartmentIDBox_TextChanged(object sender, EventArgs e) { DepartmentIDLabel.Visible = DepartmentIDBox.Text.Length != 0; }
        private void SalaryBox_TextChanged(object sender, EventArgs e) { SalaryLabel.Visible = SalaryBox.Text.Length != 0; }
        private void JobBox_TextChanged(object sender, EventArgs e) { JobLabel.Visible = JobBox.Text.Length != 0; }
        private void PasswordBox_TextChanged(object sender, EventArgs e) { PasswordBox.UseSystemPasswordChar = PasswordLabel.Visible = PasswordBox.Text.Length != 0; }
        private void UsernameBox_TextChanged(object sender, EventArgs e) { UsernameLabel.Visible = UsernameBox.Text.Length != 0; }
        private void DepartmentNameBox_TextChanged(object sender, EventArgs e) { DepartmentNameLabel.Visible = DepartmentNameBox.Text.Length != 0; }
        private void EmployeeIDDBox_TextChanged(object sender, EventArgs e) { EmployeeIDDLabel.Visible = EmployeeIDDBox.Text.Length != 0; }
        private void EmployeeIDBox_TextChanged(object sender, EventArgs e) { EmployeeIDLabel.Visible = EmployeeIDBox.Text.Length != 0; }


        private void AddBt_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("", MainForm.connection);
            if (Tab1.Text == button.Text)
            {
                if (!CHandel.isUsername(UsernameBox.Text)) MainForm.errorForm.show(this, "Invalid Username.");
                else if (PasswordBox.Text.Length < 7) MainForm.errorForm.show(this, "Min Length password is 7 digits.");
                else if (!CHandel.isInteger(EmployeeIDBox.Text)) MainForm.errorForm.show(this, "Invalid Employee ID.");
                else
                {
                    if (COUNT("DB_INFO", "WHERE UserName = '" + UsernameBox.Text + "'") != 0) MainForm.errorForm.show(this, "username already exists.");
                    else if (COUNT("DB_INFO", "WHERE Employee_ID = '" + EmployeeIDBox.Text + "'") != 0) MainForm.errorForm.show(this, "Employee ID already Have acount.");
                    else if (COUNT("EMPLOYEES", "WHERE ID = '" + EmployeeIDBox.Text + "'") == 0) MainForm.errorForm.show(this, "Employee ID is Not Exists.");
                    else
                    {
                        command.CommandText = "INSERT INTO DB_INFO ([UserName], [Password], [Employee_ID])" +
                            "VALUES ('" + UsernameBox.Text + "', '" + PasswordBox.Text + "', " + EmployeeIDBox.Text + ")";
                        update(command);
                    }
                }

            }
            else if (Tab2.Text == button.Text)
            {
                if (!CHandel.isString(DepartmentNameBox.Text)) MainForm.errorForm.show(this, "Invalid Department Name.");
                else if (!CHandel.isInteger(EmployeeIDDBox.Text) && EmployeeIDDBox.Text != "") MainForm.errorForm.show(this, "Invalid Manager ID.");
                else
                {
                    if (COUNT("DEPARTMENTS", " Where NAME = '" + DepartmentNameBox.Text + "'") != 0) MainForm.errorForm.show(this, "Department already exists.");
                    else if (COUNT("EMPLOYEES", "WHERE ID = '" + EmployeeIDDBox.Text + "'") == 0) MainForm.errorForm.show(this, "Employee ID is Not Exists.");
                    else
                    {
                        if (EmployeeIDDBox.Text != "")
                            command.CommandText = "INSERT INTO DEPARTMENTS ([Name], [Manager_ID]) " +
                                "VALUES ('" + DepartmentNameBox.Text + "', " + EmployeeIDDBox.Text + ")";
                        else command.CommandText = "INSERT INTO DEPARTMENTS ([Name]) " +
                                "VALUES ('" + DepartmentNameBox.Text + "')";
                        update(command);
                    } 
                }
            }
            else
            {
                if (!CHandel.isString(FirstNameBox.Text)) MainForm.errorForm.show(this, "Firstname is Not Valid.");
                else if (!CHandel.isString(LastNameBox.Text)) MainForm.errorForm.show(this, "LastName is Not Valid.");
                else if (!CHandel.isEmail(EmailBox.Text)) MainForm.errorForm.show(this, "Email is Not Vaild.");
                else if (!CHandel.isPhone(PhoneNumberBox.Text)) MainForm.errorForm.show(this, "Phonenumber is Not Valid.");
                else if (!CHandel.isInteger(NationalIDBox.Text)) MainForm.errorForm.show(this, "National ID is Not Valid.");
                else if (!CHandel.isString(CountryBox.Text)) MainForm.errorForm.show(this, "Country is Not Valid.");
                else if (!CHandel.isString(CityBox.Text)) MainForm.errorForm.show(this, "City is Not Valid.");
                else if (!CHandel.isString(StreetBox.Text)) MainForm.errorForm.show(this, "Street is Not Valid.");
                else if (!CHandel.isDouble(SalaryBox.Text) || double.Parse(SalaryBox.Text) < 0) MainForm.errorForm.show(this, "Salary is Not Valid.");
                else if (!CHandel.isString(JobBox.Text)) MainForm.errorForm.show(this, "Job is Not Valid.");
                else if (!CHandel.isInteger(DepartmentIDBox.Text)) MainForm.errorForm.show(this, "Department ID is Not Valid");
                else
                {
                    if (COUNT("EMPLOYEES", "WHERE EMAIL = '" + EmailBox.Text + "'") != 0) MainForm.errorForm.show(this, "Email already exists.");
                    else if (COUNT("EMPLOYEES", "WHERE PhoneNumber = '" + PhoneNumberBox.Text + "'") != 0) MainForm.errorForm.show(this, "Phone Number already exists.");
                    else if (COUNT("EMPLOYEES", "WHERE National_ID = '" + NationalIDBox.Text + "'") != 0) MainForm.errorForm.show(this, "National ID already exists.");
                    else if (COUNT("Departments", "WHERE ID = '" + DepartmentIDBox.Text + "'") == 0) MainForm.errorForm.show(this, "Department ID is not exists.");
                    else
                    {
                        command.CommandText = "INSERT INTO EMPLOYEES (Name, Email, PhoneNumber, Gender, BirthDate, Address, National_ID, SALARY, JOB, DEPARTMENT_ID) " +
                        "VALUES ('" + FirstNameBox.Text + " " + LastNameBox.Text + "', '" + EmailBox.Text + "', '" + PhoneNumberBox.Text + "', " + (GenderOption1.Checked == true ? 0 : 1) + ", '" +
                        BirthdatePicker.Value.ToString("yyyy/M/dd") + "', '" + CountryBox.Text + ", " + CityBox.Text + ", " + StreetBox.Text + "', '" + NationalIDBox.Text +
                        "', " + SalaryBox.Text + ", '" + JobBox.Text + "', " + DepartmentIDBox.Text + ")";
                        update(command);
                    }
                }
            }
        }

        private void update(SqlCommand command)
        {
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
                MainForm.errorForm.show(this, ex.Message);
            }
        }

        private void Tab2_Click(object sender, EventArgs e)
        {
            Tab2.Enabled = false;
            button.Enabled = true;
            button = Tab2;
            Pages.PageIndex = 1;
        }

        private void Tab3_Click(object sender, EventArgs e)
        {
            Tab3.Enabled = false;
            button.Enabled = true;
            button = Tab3;
            Pages.PageIndex = 0;
        }

        private void Tab1_Click(object sender, EventArgs e)
        {
            Tab1.Enabled = false;
            button.Enabled = true;
            button = Tab1;
            Pages.PageIndex = 2;
        }

        int COUNT(string tabelName, string condition = "")
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM " + tabelName + " " + condition, MainForm.connection);
            return (int)command.ExecuteScalar();
        }

        private void RightIconOnHover(object sender, EventArgs e) { PasswordBox.UseSystemPasswordChar = false; }
        private void RightIconToDefault(object sender, EventArgs e) { PasswordBox.UseSystemPasswordChar = true; }
    }
}
