using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{

    public partial class Login_Form : Form
    {
       
        UserControl UserLogin_UC = new UserLogin_UsreControl();
        UserControl AdminLogin_UC = new AdminLogin_UserControl();
       
        public Login_Form()
        {
            InitializeComponent();
           
            if (!Center_Panel.Controls.Contains(UserLogin_UC))
            {
                Center_Panel.Controls.Add(UserLogin_UC);
                Headre_Lbl.Text = "پنل ورود اعضا";
                User_Entrance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
                Admin_Entrance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            }
            
        }



        private void User_Entrance_Click(object sender, EventArgs e)
        {
            User_Entrance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55))))); 
            Admin_Entrance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
          

            if (!Center_Panel.Controls.Contains(UserLogin_UC))
            {
                Center_Panel.Controls.Clear();
                Center_Panel.Controls.Add(UserLogin_UC);
                Headre_Lbl.Text = "پنل ورود اعضا";
            }

        }

        private void Admin_Entrance_Click(object sender, EventArgs e)
        {
            User_Entrance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            Admin_Entrance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            if (!Center_Panel.Controls.Contains(AdminLogin_UC))
            {
                Center_Panel.Controls.Clear();
                Center_Panel.Controls.Add(AdminLogin_UC);
                Headre_Lbl.Text = "پنل ورود کتابدار";
            }
        }
        
        
    }
}
