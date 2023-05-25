
namespace Azar_Hotel
{
    partial class WaitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitForm));
            this.LoadTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.WaitShow = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadTimer
            // 
            this.LoadTimer.Interval = 300;
            this.LoadTimer.Tick += new System.EventHandler(this.Load_Tick);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderRadius = 0;
            this.bunifuShadowPanel1.BorderThickness = 0;
            this.bunifuShadowPanel1.Controls.Add(this.WaitShow);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Gradient;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Indigo;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(28)))), ((int)(((byte)(150)))));
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 0;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(400, 200);
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
            this.WaitShow.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.WaitShow.ForeColor = System.Drawing.Color.Transparent;
            this.WaitShow.Location = new System.Drawing.Point(130, 40);
            this.WaitShow.Name = "WaitShow";
            this.WaitShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WaitShow.Size = new System.Drawing.Size(141, 120);
            this.WaitShow.TabIndex = 1;
            this.WaitShow.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.WaitShow.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Azar Hotel";
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer LoadTimer;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuLabel WaitShow;
    }
}