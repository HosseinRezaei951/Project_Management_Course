namespace Project
{
    partial class UserLogin_UsreControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin_UsreControl));
            this.panel = new System.Windows.Forms.Panel();
            this.Family_TXT = new System.Windows.Forms.TextBox();
            this.Family_Lbl = new System.Windows.Forms.Label();
            this.NewUserRegistre_Button = new System.Windows.Forms.Button();
            this.Entrance_Button = new System.Windows.Forms.Button();
            this.MemmberID_TXT = new System.Windows.Forms.TextBox();
            this.Name_TXT = new System.Windows.Forms.TextBox();
            this.MemmberID_Lbl = new System.Windows.Forms.Label();
            this.Name_Lbl = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            resources.ApplyResources(this.panel, "panel");
            this.panel.Controls.Add(this.Family_TXT);
            this.panel.Controls.Add(this.Family_Lbl);
            this.panel.Controls.Add(this.NewUserRegistre_Button);
            this.panel.Controls.Add(this.Entrance_Button);
            this.panel.Controls.Add(this.MemmberID_TXT);
            this.panel.Controls.Add(this.Name_TXT);
            this.panel.Controls.Add(this.MemmberID_Lbl);
            this.panel.Controls.Add(this.Name_Lbl);
            this.panel.Name = "panel";
            // 
            // Family_TXT
            // 
            resources.ApplyResources(this.Family_TXT, "Family_TXT");
            this.Family_TXT.Name = "Family_TXT";
            // 
            // Family_Lbl
            // 
            resources.ApplyResources(this.Family_Lbl, "Family_Lbl");
            this.Family_Lbl.Name = "Family_Lbl";
            // 
            // NewUserRegistre_Button
            // 
            resources.ApplyResources(this.NewUserRegistre_Button, "NewUserRegistre_Button");
            this.NewUserRegistre_Button.Name = "NewUserRegistre_Button";
            this.NewUserRegistre_Button.UseVisualStyleBackColor = true;
            // 
            // Entrance_Button
            // 
            resources.ApplyResources(this.Entrance_Button, "Entrance_Button");
            this.Entrance_Button.Name = "Entrance_Button";
            this.Entrance_Button.UseVisualStyleBackColor = true;
            this.Entrance_Button.Click += new System.EventHandler(this.Entrance_Button_Click);
            // 
            // MemmberID_TXT
            // 
            resources.ApplyResources(this.MemmberID_TXT, "MemmberID_TXT");
            this.MemmberID_TXT.Name = "MemmberID_TXT";
            // 
            // Name_TXT
            // 
            resources.ApplyResources(this.Name_TXT, "Name_TXT");
            this.Name_TXT.Name = "Name_TXT";
            // 
            // MemmberID_Lbl
            // 
            resources.ApplyResources(this.MemmberID_Lbl, "MemmberID_Lbl");
            this.MemmberID_Lbl.Name = "MemmberID_Lbl";
            // 
            // Name_Lbl
            // 
            resources.ApplyResources(this.Name_Lbl, "Name_Lbl");
            this.Name_Lbl.Name = "Name_Lbl";
            // 
            // UserLogin_UsreControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "UserLogin_UsreControl";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button NewUserRegistre_Button;
        private System.Windows.Forms.Button Entrance_Button;
        private System.Windows.Forms.TextBox MemmberID_TXT;
        private System.Windows.Forms.TextBox Name_TXT;
        private System.Windows.Forms.Label MemmberID_Lbl;
        private System.Windows.Forms.Label Name_Lbl;
        private System.Windows.Forms.TextBox Family_TXT;
        private System.Windows.Forms.Label Family_Lbl;
    }
}
