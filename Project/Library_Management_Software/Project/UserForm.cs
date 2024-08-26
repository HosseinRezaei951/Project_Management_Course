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
    public partial class UserForm : Form
    {

       
        public UserForm()
        {

            InitializeComponent();
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void SearchBook_Click(object sender, EventArgs e)
        {
            Headre_Lbl.Text = "جستجوی کتاب";
        }

        private void AboutUS_Click(object sender, EventArgs e)
        {
            Headre_Lbl.Text = "درباره‌ی ما";
        }
    }
}
