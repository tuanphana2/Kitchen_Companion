using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_Companion
{
    public partial class frm_Login : Form
    {
        LopDungChung lopchung;
        public frm_Login()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            this.StartPosition = FormStartPosition.CenterScreen;
            Captcha();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRegister"] == null)
            {
                frmRegister NV = new frmRegister();
                NV.MdiParent = this.MdiParent;
                NV.Show();
            }
            else Application.OpenForms["frmRegister"].Activate();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sqlDN = "select count (*) from TAIKHOAN where TenDangNhap = '"
                + txtUsername.Text + "' and MatKhau='" + txtPassword.Text + "'";
            int ketqua = (int)lopchung.Scalar(sqlDN);
            if (ketqua >= 1)
            {
                if (txt_Captcha.Text == captcha.ToString())
                {
                    ((frm_HomePage)this.MdiParent).tdn = txtUsername.Text;
                    MessageBox.Show("Login success");
                    ((frm_HomePage)this.MdiParent).LoadForm();
                    this.Close();
                }
                else MessageBox.Show("Nhập sai Captcha");
            }
            else MessageBox.Show("Nhập sai tên DN hoặc MK");
        }
        string captcha = "";
        private void Captcha()
        {
            Random r1 = new Random();
            captcha = RandomString(5);
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("Lucida Handwriting", 50, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(captcha.ToString(), font, Brushes.Green, new Point(0, 20));
            int count = 0;
            while (count < 20)
            {
                graphics.DrawLine(new Pen(Color.Red), r1.Next(0, image.Width), r1.Next(0, image.Height), r1.Next(0, image.Width), r1.Next(0, image.Height));
                count++;
            }
            pictureBox1.Image = image;

        }
        public string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
