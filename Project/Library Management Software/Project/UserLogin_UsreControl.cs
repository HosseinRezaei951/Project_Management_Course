using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
   
   
    public partial class UserLogin_UsreControl : UserControl
    {



        Form User_FRM = new UserForm();
        public UserLogin_UsreControl()
        {
            InitializeComponent();
        }

        private void Entrance_Button_Click(object sender, EventArgs e)
        {

            ((Form)(Login_Form)this.TopLevelControl).Hide();

            //((Form)this.TopLevelControl).Hide();
            User_FRM.Show();

        }
    }
}
