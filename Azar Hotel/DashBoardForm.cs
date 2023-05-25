using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Azar_Hotel
{
    public partial class DashBoardForm : Form
    {
        Bunifu.UI.WinForms.BunifuButton.BunifuButton OldButton, OldButton2;
        Form oldForm;
        SqlCommand command;
        SqlDataReader reader;
        DataTable data;
        string[] Tabel;
        // <-------------------------------------- Initialize Form ------------------------------------>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public DashBoardForm()
        {
            InitializeComponent();
            Text = string.Empty;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            // For NavBar
            OldButton = HomeBt;
            // For Connection
            command = new SqlCommand("SELECT * FROM Employees WHERE id = " + MainForm.ID, MainForm.connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                Username.Text = reader["Name"] + "";
                Email.Text = reader["Email"] + "";
            }
            reader.Close();
            setCount("EMPLOYEES", NoEmp);
            setCount("GUESTS", NoClients);
            setCount("ROOMS", NoRooms);
            setCount("PRODUCTS", NoOrders);
            OpenLayoutForm(new HomeForm());
        }

        private void Form_MouseDown(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(Handle, 0x112, 0xf012, 0); }
        private void Form_Resize(object sender, EventArgs e)
        {
            FormBorderStyle = WindowState == FormWindowState.Maximized ? FormBorderStyle.None : FormBorderStyle.Sizable;
            Maxmizied.Visible = !(Minmizied.Visible = WindowState == FormWindowState.Maximized);
        }
        // <------------------------------------------ Top Bar ---------------------------------------->
        private void btClose_Click(object sender, EventArgs e)
        {
            MainForm.Warning.show(this, "Do You Want to Close Program?");
            if (MainForm.Warning.action) Application.Exit();
        }
        private void btMin_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        private void Minmizied_Click(object sender, EventArgs e) { WindowState = FormWindowState.Normal; }
        private void Maxmizied_Click(object sender, EventArgs e) { WindowState = FormWindowState.Maximized; }
        private void Logout_Click(object sender, EventArgs e)
        {
            MainForm.Warning.show(this, "Do You Want to Logout?");
            if (MainForm.Warning.action)
            {
                MainForm.signIn.Show();
                MainForm.dashBoard.Close();
            }
        }
        // <-------------------------------------------  NavBar ---------------------------------------->
        // <----------------------------------------- Action Click NavBar ----------------------------------->
        private void MenuBt_Click(object sender, EventArgs e) { NavBar.Width = NavBar.Width == NavBar.MaximumSize.Width ? NavBar.MinimumSize.Width : NavBar.MaximumSize.Width; }
        private void HomeBt_Click(object sender, EventArgs e) { selected_Bt(HomeBt); OpenLayoutForm(new HomeForm()); }
        private void EmpBt_Click(object sender, EventArgs e)
        {
            Tabel = new string[] { "VIEW_EMPLOYEE", "VIEW_DEPARTMENT", "VIEW_LOGIN" };
            selected_Bt(EmpBt);
            loader(Tabel[0]);
            ChangeButton(Menub0, "Employee Data", Properties.Resources.EmpData);
            ChangeButton(Menub1, "Department", Properties.Resources.dep);
            ChangeButton(Menub2, "Employee Login", Properties.Resources.EmpLogin);
            SelectMenuBt(Menub0);
        }
        private void RoomBt_Click(object sender, EventArgs e)
        {
            Tabel = new string[] { "VIEW_ROOM", "VIEW_RESERVED_ROOM" };
            selected_Bt(RoomBt);
            loader(Tabel[0]);
            ChangeButton(Menub0, "Rooms Data", Properties.Resources.Bed);
            ChangeButton(Menub1, "Reserved Rooms", Properties.Resources.BedLight);
            SelectMenuBt(Menub0);
        }
        private void ClientBt_Click(object sender, EventArgs e)
        {
            Tabel = new string[] { "VIEW_CLIENT" };
            selected_Bt(ClientBt);
            loader(Tabel[0]);
            ChangeButton(Menub0, "Guest Data", Properties.Resources.Guset);
            SelectMenuBt(Menub0);
        }
        private void OrderBt_Click(object sender, EventArgs e)
        {
            Tabel = new string[] { "VIEW_PRODUCT", "VIEW_ORDER" };
            selected_Bt(OrderBt);
            loader(Tabel[0]);
            ChangeButton(Menub0, "Products", Properties.Resources.Page_4);
            ChangeButton(Menub1, "Orders", Properties.Resources.Page_41);
            SelectMenuBt(Menub0);
        }
        // <------------------------------------------- Change Header -------------------------------------->
        private void selected_Bt(Bunifu.UI.WinForms.BunifuButton.BunifuButton button)
        {
            tPic.Image = button.LeftIcon.Image;
            Title.Text = button.Text;
            Selected.Location = button.Location;
            OldButton.Enabled = true;
            button.Enabled = false;
            OldButton = button;
            oldForm.Close();
        }
        // <-------------------------------------------- End NavBar ----------------------------------------->
        // <------------------------------------------- Start Layout ---------------------------------------->
        // <------------------------------------- Action Buttons DropMenu ----------------------------------->
        private void Menub0_Click(object sender, EventArgs e) { loader(Tabel[0]); SelectMenuBt(Menub0); }
        private void Menub1_Click(object sender, EventArgs e) { loader(Tabel[1]); SelectMenuBt(Menub1); }
        private void Menub2_Click(object sender, EventArgs e) { loader(Tabel[2]); SelectMenuBt(Menub2); }
        // <------------------------------------- Action Buttons DropMenu ----------------------------------->
        private void OpenLayoutForm(Form newForm)
        {
            //open only form
            if (oldForm != null) oldForm.Close();
            oldForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            LayoutPanel.Controls.Add(newForm);
            LayoutPanel.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
            LayoutPanel.Text = newForm.Text;
        }
        // <----------------------------------- Load Source To DataGridView --------------------------------->
        private void loader(string select, string Condition = "")
        {
            command = new SqlCommand("SELECT * FROM " + select + " " + Condition, MainForm.connection);
            reader = command.ExecuteReader();
            data = new DataTable(select);
            data.Load(reader);
            DataGrid.DataSource = data;
            reader.Close();
        }

        private void changeDropMenu()
        {
            Dropdown.Items.Clear();
            Dropdown.Items.AddRange(data.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray());
            Dropdown.SelectedIndex = 0;
        }
        // <------------------------------- Change Icon Button In DropMenuPanel ----------------------------->
        private void ChangeButton(Bunifu.UI.WinForms.BunifuButton.BunifuButton button, string name, Image image)
        {
            button.LeftIcon.Image = image;
            button.Text = name;
            button.Refresh();
        }
        // <-------------------------- Load Source To DataGridView By Selecte Button ------------------------>
        private void SelectMenuBt(Bunifu.UI.WinForms.BunifuButton.BunifuButton button)
        {
            DropMenu.RightIcon.Image = Tabel.Length > 1 ? Properties.Resources.CarteDown : Properties.Resources.none2;
            DropMenu.LeftIcon.Image = button.LeftIcon.Image;
            DropMenu.Refresh();
            if (OldButton2 != null) OldButton2.Visible = true;
            button.Visible = false;
            DropMenuPanel.Height = 0;
            OldButton2 = button;
            changeDropMenu();
        }
        // <-------------------------------------- dis / Active DropMenu ------------------------------------>
        private void DropMenu_Click(object sender, EventArgs e)
        {
            if (DropMenuPanel.Height != 0)
            {
                DropMenu.RightIcon.Image = Tabel.Length > 1 ? Properties.Resources.CarteDown : Properties.Resources.none2;
                DropMenuPanel.Height = 0;
            }
            else
            {
                DropMenu.RightIcon.Image = Tabel.Length > 1 ? Properties.Resources.CaretUp : Properties.Resources.none2;
                DropMenuPanel.Height = 51 * (Tabel.Length - 1);
            }
            DropMenu.Refresh();
        }
        // <---------------------------------------- dis / Active Slide ------------------------------------->
        private void Dropdown_SelectedIndexChanged(object sender, EventArgs e) { SearchBox.Text = string.Empty; SearchBox.PlaceholderText = (string)Dropdown.SelectedItem; }
        private void SearchBox_TextChanged(object sender, EventArgs e) { loader(data.TableName, "WHERE " + Dropdown.SelectedItem + " LIKE '" + SearchBox.Text + "%'"); }

        private void AddBt_Click(object sender, EventArgs e)
        {
            if (OldButton.Text == ClientBt.Text) { new AddClientForm().ShowDialog(); setCount("GUESTS", NoClients); }
            if (OldButton.Text == RoomBt.Text) { new AddRoomsForm().ShowDialog(); setCount("ROOMS", NoRooms); }
            if (OldButton.Text == OrderBt.Text) { new AddOrdersForm().ShowDialog(); setCount("PRODUCTS", NoOrders); }
            if (OldButton.Text == EmpBt.Text) { new AddEmployeeForm().ShowDialog(); setCount("EMPLOYEES", NoEmp); }
            loader(data.TableName);
        }
        private void SlideMenu_Click(object sender, EventArgs e) { AddBt.Visible = DelBt.Visible = EditBt.Visible = CloseSideMenu.Visible = !(SlideMenu.Visible = false); }
        private void CloseSideMenu_Click(object sender, EventArgs e) { AddBt.Visible = DelBt.Visible = EditBt.Visible = CloseSideMenu.Visible = !(SlideMenu.Visible = true); }

        private void EditBt_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm(data);
            edit.ShowDialog();
        }

        private void DelBt_Click(object sender, EventArgs e)
        {
            DeleteForm delete;
            if (OldButton.Text == EmpBt.Text) delete = new DeleteForm("EMPLOYEES", "Delete Employee");
            else if (OldButton.Text == ClientBt.Text) delete = new DeleteForm("GUESTS", "Delete Guest");
            else if (OldButton.Text == RoomBt.Text) 
                delete = OldButton2.Text == Menub0.Text ? new DeleteForm("ROOMS", "Delete Room") : new DeleteForm("RESERVED_ROOMS", "Delete Reserve");
            else delete = OldButton2.Text == Menub0.Text ? new DeleteForm("PRODUCTS", "Delete Product") : new DeleteForm("ORDERS", "Delete Order");
            delete.ShowDialog();
            loader(data.TableName);
        }
        // <-------------------------------------------- End Layout ----------------------------------------->
        public void setCount(string tableName, Bunifu.UI.WinForms.BunifuLabel label)
        {
            command = new SqlCommand("SELECT COUNT(*) AS N FROM " + tableName + " Where [Available] = 1", MainForm.connection);
            label.Text = command.ExecuteScalar() + "";
        }
    }

}
