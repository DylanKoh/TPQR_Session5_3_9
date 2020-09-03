using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session5_3_9
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new Session5Entities())
            {
                if (string.IsNullOrWhiteSpace(txtUserID.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please check your fields!", "Empty Field(s)",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var findUser = (from x in context.Users
                                    where x.userId == txtUserID.Text
                                    select x).FirstOrDefault();
                    if (findUser == null)
                    {
                        MessageBox.Show("No such user exist!", "Invalid Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (findUser.passwd != txtPassword.Text)
                    {
                        MessageBox.Show("User ID or Password do not match our DB!", "Invalid Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Hide();
                        (new AdminMain()).ShowDialog();
                        Close();
                    }
                }
            }
        }
    }
}
