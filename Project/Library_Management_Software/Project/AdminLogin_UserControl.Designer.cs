namespace Project
{
    partial class AdminLogin_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.Entrance_Button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MemmberId_Lbl = new System.Windows.Forms.Label();
            this.UserName_Lbl = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.Entrance_Button);
            this.panel.Controls.Add(this.textBox2);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.MemmberId_Lbl);
            this.panel.Controls.Add(this.UserName_Lbl);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Font = new System.Drawing.Font("B Zar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel.Size = new System.Drawing.Size(561, 272);
            this.panel.TabIndex = 0;
            // 
            // Entrance_Button
            // 
            this.Entrance_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Entrance_Button.Location = new System.Drawing.Point(427, 202);
            this.Entrance_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Entrance_Button.Name = "Entrance_Button";
            this.Entrance_Button.Size = new System.Drawing.Size(90, 38);
            this.Entrance_Button.TabIndex = 15;
            this.Entrance_Button.Text = "ورود";
            this.Entrance_Button.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 146);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(455, 41);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 41);
            this.textBox1.TabIndex = 13;
            // 
            // MemmberId_Lbl
            // 
            this.MemmberId_Lbl.AutoSize = true;
            this.MemmberId_Lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MemmberId_Lbl.Location = new System.Drawing.Point(451, 110);
            this.MemmberId_Lbl.Name = "MemmberId_Lbl";
            this.MemmberId_Lbl.Size = new System.Drawing.Size(72, 34);
            this.MemmberId_Lbl.TabIndex = 12;
            this.MemmberId_Lbl.Text = "رمز عبور:";
            // 
            // UserName_Lbl
            // 
            this.UserName_Lbl.AutoSize = true;
            this.UserName_Lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserName_Lbl.Location = new System.Drawing.Point(436, 30);
            this.UserName_Lbl.Name = "UserName_Lbl";
            this.UserName_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserName_Lbl.Size = new System.Drawing.Size(87, 34);
            this.UserName_Lbl.TabIndex = 11;
            this.UserName_Lbl.Text = "نام کاربری: ";
            // 
            // AdminLogin_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "AdminLogin_UserControl";
            this.Size = new System.Drawing.Size(561, 272);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Entrance_Button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label MemmberId_Lbl;
        private System.Windows.Forms.Label UserName_Lbl;
    }
}
