namespace Project
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.Dashbord = new System.Windows.Forms.Panel();
            this.Admin_Entrance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.User_Entrance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Icon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.Headre_Lbl = new System.Windows.Forms.Label();
            this.Center_Panel = new System.Windows.Forms.Panel();
            this.Dashbord.SuspendLayout();
            this.Icon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dashbord
            // 
            this.Dashbord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Dashbord.Controls.Add(this.Admin_Entrance);
            this.Dashbord.Controls.Add(this.User_Entrance);
            this.Dashbord.Controls.Add(this.Icon);
            this.Dashbord.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dashbord.Location = new System.Drawing.Point(644, 0);
            this.Dashbord.Name = "Dashbord";
            this.Dashbord.Size = new System.Drawing.Size(163, 322);
            this.Dashbord.TabIndex = 1;
            // 
            // Admin_Entrance
            // 
            this.Admin_Entrance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Admin_Entrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Admin_Entrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Admin_Entrance.BorderRadius = 0;
            this.Admin_Entrance.ButtonText = "ورود کتابدار ";
            this.Admin_Entrance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin_Entrance.DisabledColor = System.Drawing.Color.Gray;
            this.Admin_Entrance.Dock = System.Windows.Forms.DockStyle.Top;
            this.Admin_Entrance.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Admin_Entrance.Iconcolor = System.Drawing.Color.Transparent;
            this.Admin_Entrance.Iconimage = null;
            this.Admin_Entrance.Iconimage_right = null;
            this.Admin_Entrance.Iconimage_right_Selected = null;
            this.Admin_Entrance.Iconimage_Selected = null;
            this.Admin_Entrance.IconMarginLeft = 0;
            this.Admin_Entrance.IconMarginRight = 0;
            this.Admin_Entrance.IconRightVisible = true;
            this.Admin_Entrance.IconRightZoom = 0D;
            this.Admin_Entrance.IconVisible = true;
            this.Admin_Entrance.IconZoom = 90D;
            this.Admin_Entrance.IsTab = false;
            this.Admin_Entrance.Location = new System.Drawing.Point(0, 103);
            this.Admin_Entrance.Margin = new System.Windows.Forms.Padding(4);
            this.Admin_Entrance.Name = "Admin_Entrance";
            this.Admin_Entrance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Admin_Entrance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Admin_Entrance.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.Admin_Entrance.selected = false;
            this.Admin_Entrance.Size = new System.Drawing.Size(163, 53);
            this.Admin_Entrance.TabIndex = 7;
            this.Admin_Entrance.Text = "ورود کتابدار ";
            this.Admin_Entrance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Admin_Entrance.Textcolor = System.Drawing.Color.LightGray;
            this.Admin_Entrance.TextFont = new System.Drawing.Font("B Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Admin_Entrance.Click += new System.EventHandler(this.Admin_Entrance_Click);
            // 
            // User_Entrance
            // 
            this.User_Entrance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.User_Entrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.User_Entrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_Entrance.BorderRadius = 0;
            this.User_Entrance.ButtonText = "ورود اعضا";
            this.User_Entrance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User_Entrance.DisabledColor = System.Drawing.Color.Gray;
            this.User_Entrance.Dock = System.Windows.Forms.DockStyle.Top;
            this.User_Entrance.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.User_Entrance.Iconcolor = System.Drawing.Color.Transparent;
            this.User_Entrance.Iconimage = null;
            this.User_Entrance.Iconimage_right = null;
            this.User_Entrance.Iconimage_right_Selected = null;
            this.User_Entrance.Iconimage_Selected = null;
            this.User_Entrance.IconMarginLeft = 0;
            this.User_Entrance.IconMarginRight = 0;
            this.User_Entrance.IconRightVisible = true;
            this.User_Entrance.IconRightZoom = 0D;
            this.User_Entrance.IconVisible = true;
            this.User_Entrance.IconZoom = 90D;
            this.User_Entrance.IsTab = false;
            this.User_Entrance.Location = new System.Drawing.Point(0, 50);
            this.User_Entrance.Margin = new System.Windows.Forms.Padding(4);
            this.User_Entrance.Name = "User_Entrance";
            this.User_Entrance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.User_Entrance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.User_Entrance.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.User_Entrance.selected = false;
            this.User_Entrance.Size = new System.Drawing.Size(163, 53);
            this.User_Entrance.TabIndex = 6;
            this.User_Entrance.Text = "ورود اعضا";
            this.User_Entrance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.User_Entrance.Textcolor = System.Drawing.Color.LightGray;
            this.User_Entrance.TextFont = new System.Drawing.Font("B Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.User_Entrance.Click += new System.EventHandler(this.User_Entrance_Click);
            // 
            // Icon
            // 
            this.Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(29)))));
            this.Icon.Controls.Add(this.pictureBox1);
            this.Icon.Controls.Add(this.label1);
            this.Icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Icon.Location = new System.Drawing.Point(0, 0);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(163, 50);
            this.Icon.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(64, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "کتابداری";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Headre_Lbl);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Font = new System.Drawing.Font("B Zar", 12F);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(644, 50);
            this.Header.TabIndex = 3;
            // 
            // Headre_Lbl
            // 
            this.Headre_Lbl.AutoSize = true;
            this.Headre_Lbl.Location = new System.Drawing.Point(45, 7);
            this.Headre_Lbl.Name = "Headre_Lbl";
            this.Headre_Lbl.Size = new System.Drawing.Size(0, 34);
            this.Headre_Lbl.TabIndex = 0;
            // 
            // Center_Panel
            // 
            this.Center_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Center_Panel.Location = new System.Drawing.Point(0, 50);
            this.Center_Panel.Name = "Center_Panel";
            this.Center_Panel.Size = new System.Drawing.Size(644, 272);
            this.Center_Panel.TabIndex = 4;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 322);
            this.Controls.Add(this.Center_Panel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Dashbord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کتابدرای";
            this.Dashbord.ResumeLayout(false);
            this.Icon.ResumeLayout(false);
            this.Icon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dashbord;
        private System.Windows.Forms.Panel Icon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuFlatButton Admin_Entrance;
        private Bunifu.Framework.UI.BunifuFlatButton User_Entrance;
        private System.Windows.Forms.Panel Center_Panel;
        private System.Windows.Forms.Label Headre_Lbl;
    }
}