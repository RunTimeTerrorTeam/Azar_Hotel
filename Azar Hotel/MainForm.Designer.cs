
namespace Azar_Hotel
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.WaitShow = new Bunifu.UI.WinForms.BunifuLabel();
            this.LoadTimer = new System.Windows.Forms.Timer(this.components);
            this.ConnectionDB = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = global::Azar_Hotel.Properties.Resources.LogoWhite;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(200, 25);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(200, 200);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azar_Hotel.Properties.Resources.Page_5;
            this.pictureBox1.Location = new System.Drawing.Point(480, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderRadius = 0;
            this.bunifuShadowPanel1.BorderThickness = 0;
            this.bunifuShadowPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuShadowPanel1.Controls.Add(this.WaitShow);
            this.bunifuShadowPanel1.Controls.Add(this.pictureBox1);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Gradient;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Indigo;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(28)))), ((int)(((byte)(150)))));
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.BlueViolet;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 0;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(600, 315);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Lowered;
            this.bunifuShadowPanel1.TabIndex = 0;
            // 
            // WaitShow
            // 
            this.WaitShow.AllowParentOverrides = false;
            this.WaitShow.AutoEllipsis = false;
            this.WaitShow.AutoSize = false;
            this.WaitShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.WaitShow.CursorType = System.Windows.Forms.Cursors.Default;
            this.WaitShow.Font = new System.Drawing.Font("Calibri", 48F);
            this.WaitShow.ForeColor = System.Drawing.Color.Transparent;
            this.WaitShow.Location = new System.Drawing.Point(230, 215);
            this.WaitShow.Name = "WaitShow";
            this.WaitShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WaitShow.Size = new System.Drawing.Size(141, 120);
            this.WaitShow.TabIndex = 3;
            this.WaitShow.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.WaitShow.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LoadTimer
            // 
            this.LoadTimer.Tick += new System.EventHandler(this.LoadTimer_Tick);
            // 
            // ConnectionDB
            // 
            this.ConnectionDB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ConnectionDB_DoWork);
            this.ConnectionDB.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ConnectionDB_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(600, 315);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Timer LoadTimer;
        private Bunifu.UI.WinForms.BunifuLabel WaitShow;
        private System.ComponentModel.BackgroundWorker ConnectionDB;
    }
}