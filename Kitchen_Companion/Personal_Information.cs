using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_Companion
{
    public partial class frm_Personal_Information : Form
    {
        LopDungChung lopchung;
        public string tdn { get; set; }
        public frm_Personal_Information()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void frm_Personal_Information_Load(object sender, EventArgs e)
        {
            lb_Username.Text = tdn;
            lb_Username.Visible = true;
            string sqlName = "select hoten from TAIKHOAN where tendangnhap = '" + tdn + "'";
            string sqlEmail = "select email from TAIKHOAN where tendangnhap = '" + tdn + "'";
            string sqlSDT = "select sdt from TAIKHOAN where tendangnhap = '" + tdn + "'";
            txtFullName.Text = lopchung.GetValue(sqlName);
            txtEmail.Text = lopchung.GetValue(sqlEmail);
            txtPhoneNumber.Text = lopchung.GetValue(sqlSDT);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlEdit = "update TAIKHOAN set hoten = '" + txtFullName.Text + "', email = '" + txtEmail.Text
                + "', sdt = '" + txtPhoneNumber.Text + "' where tendangnhap = '" + tdn + "'";
            lopchung.NonQuery(sqlEdit);
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Change"] == null)
            {
                frm_Change NV = new frm_Change();
                NV.tdn = tdn;
                NV.MdiParent = this.MdiParent;
                NV.Show();
            }
            else Application.OpenForms["frm_Change"].Activate();
        }
    }
}
