
namespace Azar_Hotel
{
    partial class MessageErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageErrorForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new Bunifu.UI.WinForms.BunifuLabel();
            this.Msg = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.CloseBt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.bunifuPanel1.BorderRadius = 10;
            this.bunifuPanel1.BorderThickness = 7;
            this.bunifuPanel1.Controls.Add(this.panel1);
            this.bunifuPanel1.Controls.Add(this.Msg);
            this.bunifuPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel1.Controls.Add(this.CloseBt);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(400, 315);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 40);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // Title
            // 
            this.Title.AllowParentOverrides = false;
            this.Title.AutoEllipsis = false;
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.CursorType = System.Windows.Forms.Cursors.Default;
            this.Title.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(166, 2);
            this.Title.Name = "Title";
            this.Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Title.Size = new System.Drawing.Size(52, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Error";
            this.Title.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Title.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // Msg
            // 
            this.Msg.AllowParentOverrides = false;
            this.Msg.AutoEllipsis = false;
            this.Msg.AutoSize = false;
            this.Msg.Cursor = System.Windows.Forms.Cursors.Default;
            this.Msg.CursorType = System.Windows.Forms.Cursors.Default;
            this.Msg.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.Msg.Location = new System.Drawing.Point(50, 160);
            this.Msg.Name = "Msg";
            this.Msg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Msg.Size = new System.Drawing.Size(300, 57);
            this.Msg.TabIndex = 10;
            this.Msg.Text = "\r\nUsername and Password is Empty.\r\nPlease Fill Filds.";
            this.Msg.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.Msg.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 40;
            this.bunifuPictureBox1.Image = global::Azar_Hotel.Properties.Resources.Error;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(160, 57);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(80, 80);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 9;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // CloseBt
            // 
            this.CloseBt.AllowAnimations = true;
            this.CloseBt.AllowMouseEffects = true;
            this.CloseBt.AllowToggling = false;
            this.CloseBt.AnimationSpeed = 200;
            this.CloseBt.AutoGenerateColors = false;
            this.CloseBt.AutoRoundBorders = false;
            this.CloseBt.AutoSizeLeftIcon = true;
            this.CloseBt.AutoSizeRightIcon = true;
            this.CloseBt.BackColor = System.Drawing.Color.Transparent;
            this.CloseBt.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(28)))), ((int)(((byte)(150)))));
            this.CloseBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBt.BackgroundImage")));
            this.CloseBt.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CloseBt.ButtonText = "Close";
            this.CloseBt.ButtonTextMarginLeft = 0;
            this.CloseBt.ColorContrastOnClick = 45;
            this.CloseBt.ColorContrastOnHover = 45;
            this.CloseBt.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.CloseBt.CustomizableEdges = borderEdges1;
            this.CloseBt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CloseBt.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CloseBt.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CloseBt.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.CloseBt.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBt.ForeColor = System.Drawing.Color.White;
            this.CloseBt.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CloseBt.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.CloseBt.IconMarginLeft = 11;
            this.CloseBt.IconPadding = 10;
            this.CloseBt.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseBt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CloseBt.IconRightPadding = new System.Windows.Forms.Padding(15);
            this.CloseBt.IconSize = 25;
            this.CloseBt.IdleBorderColor = System.Drawing.Color.Transparent;
            this.CloseBt.IdleBorderRadius = 7;
            this.CloseBt.IdleBorderThickness = 1;
            this.CloseBt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(28)))), ((int)(((byte)(150)))));
            this.CloseBt.IdleIconLeftImage = null;
            this.CloseBt.IdleIconRightImage = null;
            this.CloseBt.IndicateFocus = false;
            this.CloseBt.Location = new System.Drawing.Point(125, 240);
            this.CloseBt.Name = "CloseBt";
            this.CloseBt.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CloseBt.OnDisabledState.BorderRadius = 7;
            this.CloseBt.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CloseBt.OnDisabledState.BorderThickness = 1;
            this.CloseBt.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CloseBt.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CloseBt.OnDisabledState.IconLeftImage = null;
            this.CloseBt.OnDisabledState.IconRightImage = null;
            this.CloseBt.onHoverState.BorderColor = System.Drawing.Color.BlueViolet;
            this.CloseBt.onHoverState.BorderRadius = 7;
            this.CloseBt.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CloseBt.onHoverState.BorderThickness = 1;
            this.CloseBt.onHoverState.FillColor = System.Drawing.Color.BlueViolet;
            this.CloseBt.onHoverState.ForeColor = System.Drawing.Color.White;
            this.CloseBt.onHoverState.IconLeftImage = null;
            this.CloseBt.onHoverState.IconRightImage = null;
            this.CloseBt.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.CloseBt.OnIdleState.BorderRadius = 7;
            this.CloseBt.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CloseBt.OnIdleState.BorderThickness = 1;
            this.CloseBt.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(28)))), ((int)(((byte)(150)))));
            this.CloseBt.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.CloseBt.OnIdleState.IconLeftImage = null;
            this.CloseBt.OnIdleState.IconRightImage = null;
            this.CloseBt.OnPressedState.BorderColor = System.Drawing.Color.BlueViolet;
            this.CloseBt.OnPressedState.BorderRadius = 7;
            this.CloseBt.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CloseBt.OnPressedState.BorderThickness = 1;
            this.CloseBt.OnPressedState.FillColor = System.Drawing.Color.BlueViolet;
            this.CloseBt.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.CloseBt.OnPressedState.IconLeftImage = null;
            this.CloseBt.OnPressedState.IconRightImage = null;
            this.CloseBt.Size = new System.Drawing.Size(150, 50);
            this.CloseBt.TabIndex = 8;
            this.CloseBt.TabStop = false;
            this.CloseBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseBt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseBt.TextMarginLeft = 0;
            this.CloseBt.TextPadding = new System.Windows.Forms.Padding(0);
            this.CloseBt.UseDefaultRadiusAndThickness = true;
            this.CloseBt.Click += new System.EventHandler(this.CloseBt_Click);
            // 
            // MessageErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 315);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ErrorForm";
            this.bunifuPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CloseBt;
        public Bunifu.UI.WinForms.BunifuLabel Msg;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel Title;
    }
}