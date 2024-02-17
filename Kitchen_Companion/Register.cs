using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kitchen_Companion
{
    public partial class frmRegister : Form
    {
        LopDungChung lopchung = new LopDungChung();

        public frmRegister()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public bool CheckEmail(string mail)
        {
            return Regex.IsMatch(mail, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password1 = txtPassword.Text;
            string password2 = txtEnterPassword.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhonenumber.Text;
            string sqlcheck = "select count(*) from TAIKHOAN where tendangnhap = '" + username + "'";
            int result = (int)lopchung.Scalar(sqlcheck);
            if (username == "")
                MessageBox.Show("Enter username");
            else if (password1 == "")
                MessageBox.Show("Enter password");
            else if (password1 != password2)
                MessageBox.Show("The passwords must match");
            else if (name == "")
                MessageBox.Show("Enter full name");
            else if (email == "")
                MessageBox.Show("Enter email");
            else if (!CheckEmail(email))
                MessageBox.Show("Invalid email");
            else if (phone == "")
                MessageBox.Show("Enter phone number");
            else if (result > 0)
                MessageBox.Show("Username already exists");
            else
            {
                string sqlcreate = "insert into TAIKHOAN values('" + username + "', '" + password1
                + "', N'" + name + "', '" + email + "', '" + phone + "')";
                lopchung.NonQuery(sqlcreate);
                this.Close();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Application.OpenForms["frmLogin"] == null)
            {
                frm_Login NV = new frm_Login();
                NV.Show();
            }
            else Application.OpenForms["frmLogin"].Activate();
        }
    }
}
