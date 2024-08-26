namespace Project
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.Header = new System.Windows.Forms.Panel();
            this.Headre_Lbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Icon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AboutUS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Dashbord = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.Icon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Dashbord.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.Headre_Lbl);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Header.Size = new System.Drawing.Size(894, 50);
            this.Header.TabIndex = 2;
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            // 
            // Headre_Lbl
            // 
            this.Headre_Lbl.AutoSize = true;
            this.Headre_Lbl.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Headre_Lbl.Location = new System.Drawing.Point(83, 7);
            this.Headre_Lbl.Name = "Headre_Lbl";
            this.Headre_Lbl.Size = new System.Drawing.Size(0, 34);
            this.Headre_Lbl.TabIndex = 1;
            // 
            // Icon
            // 
            this.Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(29)))));
            this.Icon.Controls.Add(this.pictureBox1);
            this.Icon.Controls.Add(this.label1);
            this.Icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Icon.Location = new System.Drawing.Point(0, 0);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(203, 50);
            this.Icon.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(82, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "کتابداری";
            // 
            // SearchBook
            // 
            this.SearchBook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SearchBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBook.BorderRadius = 0;
            this.SearchBook.ButtonText = "جستجوی کتاب  ";
            this.SearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBook.DisabledColor = System.Drawing.Color.Gray;
            this.SearchBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBook.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchBook.Iconcolor = System.Drawing.Color.Transparent;
            this.SearchBook.Iconimage = null;
            this.SearchBook.Iconimage_right = null;
            this.SearchBook.Iconimage_right_Selected = null;
            this.SearchBook.Iconimage_Selected = null;
            this.SearchBook.IconMarginLeft = 0;
            this.SearchBook.IconMarginRight = 0;
            this.SearchBook.IconRightVisible = true;
            this.SearchBook.IconRightZoom = 0D;
            this.SearchBook.IconVisible = true;
            this.SearchBook.IconZoom = 90D;
            this.SearchBook.IsTab = false;
            this.SearchBook.Location = new System.Drawing.Point(0, 50);
            this.SearchBook.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SearchBook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SearchBook.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.SearchBook.selected = false;
            this.SearchBook.Size = new System.Drawing.Size(203, 53);
            this.SearchBook.TabIndex = 3;
            this.SearchBook.Text = "جستجوی کتاب  ";
            this.SearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchBook.Textcolor = System.Drawing.Color.LightGray;
            this.SearchBook.TextFont = new System.Drawing.Font("B Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
            // 
            // AboutUS
            // 
            this.AboutUS.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.AboutUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.AboutUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AboutUS.BorderRadius = 0;
            this.AboutUS.ButtonText = "درباره‌ی ما";
            this.AboutUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutUS.DisabledColor = System.Drawing.Color.Gray;
            this.AboutUS.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutUS.Font = new System.Drawing.Font("B Zar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AboutUS.Iconcolor = System.Drawing.Color.Transparent;
            this.AboutUS.Iconimage = null;
            this.AboutUS.Iconimage_right = null;
            this.AboutUS.Iconimage_right_Selected = null;
            this.AboutUS.Iconimage_Selected = null;
            this.AboutUS.IconMarginLeft = 0;
            this.AboutUS.IconMarginRight = 0;
            this.AboutUS.IconRightVisible = true;
            this.AboutUS.IconRightZoom = 0D;
            this.AboutUS.IconVisible = true;
            this.AboutUS.IconZoom = 90D;
            this.AboutUS.IsTab = false;
            this.AboutUS.Location = new System.Drawing.Point(0, 103);
            this.AboutUS.Margin = new System.Windows.Forms.Padding(4);
            this.AboutUS.Name = "AboutUS";
            this.AboutUS.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.AboutUS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.AboutUS.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.AboutUS.selected = false;
            this.AboutUS.Size = new System.Drawing.Size(203, 53);
            this.AboutUS.TabIndex = 5;
            this.AboutUS.Text = "درباره‌ی ما";
            this.AboutUS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutUS.Textcolor = System.Drawing.Color.LightGray;
            this.AboutUS.TextFont = new System.Drawing.Font("B Zar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AboutUS.Click += new System.EventHandler(this.AboutUS_Click);
            // 
            // Dashbord
            // 
            this.Dashbord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Dashbord.Controls.Add(this.AboutUS);
            this.Dashbord.Controls.Add(this.SearchBook);
            this.Dashbord.Controls.Add(this.Icon);
            this.Dashbord.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dashbord.Location = new System.Drawing.Point(894, 0);
            this.Dashbord.Name = "Dashbord";
            this.Dashbord.Size = new System.Drawing.Size(203, 431);
            this.Dashbord.TabIndex = 0;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1097, 431);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Dashbord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Icon.ResumeLayout(false);
            this.Icon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Dashbord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Icon;
        private Bunifu.Framework.UI.BunifuFlatButton SearchBook;
        private Bunifu.Framework.UI.BunifuFlatButton AboutUS;
        private System.Windows.Forms.Panel Dashbord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Headre_Lbl;
    }
}

