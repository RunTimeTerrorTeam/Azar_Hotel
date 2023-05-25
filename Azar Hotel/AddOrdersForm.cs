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
    public partial class AddOrdersForm : Form
    {
        Bunifu.UI.WinForms.BunifuButton.BunifuButton button;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int SPX, int SPY, int EPX, int EPY, int nWidthEllipse, int nHeightEllipse);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public AddOrdersForm()
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
        private void QuantityPBox_TextChanged(object sender, EventArgs e) { QuantityPLabel.Visible = QuantityPBox.Text.Length != 0;}
        private void NameBox_TextChanged(object sender, EventArgs e) { NameLabel.Visible = NameBox.Text.Length != 0;}
        private void PriceBox_TextChanged(object sender, EventArgs e) { PriceLabel.Visible = PriceBox.Text.Length != 0;}
        private void GuestIDBox_TextChanged(object sender, EventArgs e) { GuestIDLabel.Visible = GuestIDBox.Text.Length != 0;}
        private void QuantityOBox_TextChanged(object sender, EventArgs e) { QuantityOLabel.Visible = QuantityOBox.Text.Length != 0;}
        private void ProductIDBox_TextChanged(object sender, EventArgs e) { ProductIDLabel.Visible = ProductIDBox.Text.Length != 0;}
        
        private void AddBt_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("", MainForm.connection);
            if (button.Text == Tab1.Text)
            {
                if (!CHandel.isString(NameBox.Text)) MainForm.errorForm.show(this, "Name is Not Valid");
                else if (!CHandel.isInteger(QuantityPBox.Text) || int.Parse(QuantityPBox.Text) < 0) MainForm.errorForm.show(this, "Quantity is Not Valid");
                else if (!CHandel.isDouble(PriceBox.Text) || double.Parse(PriceBox.Text) < 0) MainForm.errorForm.show(this, "Price is Not Valid");
                else if (COUNT("PRODUCTS", "WHERE NAME = " + NameBox.Text) != 0) MainForm.errorForm.show(this, "Product is Already Exists.");
                else
                {
                    command.CommandText = "INSERT INTO PRODUCTS (NAME, QUANTITY, PRICE) " +
                        "VALUES ('" + NameBox.Text + "', " + QuantityPBox.Text + ", " + PriceBox.Text + ")";
                    update(command);
                }
            }
            else
            {
                command.CommandText = "Select Quantity From Products where ID = " + ProductIDBox.Text;
                if (!CHandel.isInteger(ProductIDBox.Text)) MainForm.errorForm.show(this, "Product ID is Not Valid");
                else if(!CHandel.isInteger(GuestIDBox.Text)) MainForm.errorForm.show(this, "Guest ID is Not Valid");
                else if (!CHandel.isInteger(QuantityOBox.Text) || double.Parse(QuantityOBox.Text) < 0) MainForm.errorForm.show(this, "Quantity is Not Valid");
                else if (COUNT("Guests", "WHERE ID = " + GuestIDBox.Text) == 0) MainForm.errorForm.show(this, "Client ID is Not Exists");
                else if (COUNT("PRODUCTS", "WHERE ID = " + ProductIDBox.Text) == 0) MainForm.errorForm.show(this, "Product ID is Not Exists");
                else if (int.Parse(QuantityOBox.Text) > (int)command.ExecuteScalar()) MainForm.errorForm.show(this, "Quantity is Bigger than Exists Quantity");
                else
                {
                    command.CommandText = "INSERT INTO  ORDERS (QUANTITY, Guest_ID, PRODUCT_ID, Employee_id) " +
                  "VALUES (" + QuantityOBox.Text + ", " + GuestIDBox.Text + ", " + ProductIDBox.Text + ", " + MainForm.ID + ")";
                    update(command);
                }
            }
            
        }

        int COUNT(string tabelName, string condition = "")
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM " + tabelName + " " + condition, MainForm.connection);
            return (int)command.ExecuteScalar();
        }

        void update(SqlCommand command)
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
            }
        }
    }
}
