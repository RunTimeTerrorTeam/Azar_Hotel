
namespace Azar_Hotel
{
    partial class CorrectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorrectForm));
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Msg = new Bunifu.UI.WinForms.BunifuLabel();
            this.TimerLoad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = global::Azar_Hotel.Properties.Resources.Correct;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(200, 35);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Msg
            // 
            this.Msg.AllowParentOverrides = false;
            this.Msg.AutoEllipsis = false;
            this.Msg.AutoSize = false;
            this.Msg.CursorType = System.Windows.Forms.Cursors.Default;
            this.Msg.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msg.ForeColor = System.Drawing.Color.White;
            this.Msg.Location = new System.Drawing.Point(0, 170);
            this.Msg.Name = "Msg";
            this.Msg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Msg.Size = new System.Drawing.Size(500, 29);
            this.Msg.TabIndex = 1;
            this.Msg.Text = "Saved succesfully";
            this.Msg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Msg.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TimerLoad
            // 
            this.TimerLoad.Tick += new System.EventHandler(this.TimerLoad_Tick);
            // 
            // CorrectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(53)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CorrectForm";
            this.Text = "CorrectForm";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel Msg;
        private System.Windows.Forms.Timer TimerLoad;
    }
}