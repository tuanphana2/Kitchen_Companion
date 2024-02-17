using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_Companion
{
    public partial class frm_Change : Form
    {
        LopDungChung lopchung;
        public string tdn { get; set; }
        public frm_Change()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            string sqlGetPass = "select matkhau from TAIKHOAN where tendangnhap = '" + tdn + "'";
            string pass = lopchung.GetValue(sqlGetPass);
            if (pass != txt_Old.Text)
                MessageBox.Show("Enter wrong old password");
            else if (txt_New.Text != txt_Confirm.Text)
                MessageBox.Show("The passwords must match");
            else
            {
                string sqlChange = "update TAIKHOAN set matkhau = '" + txt_New.Text + "' where tendangnhap = '" + tdn + "'";
                lopchung.NonQuery(sqlChange);
            }
        }
    }
}
