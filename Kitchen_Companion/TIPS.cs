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
    public partial class frm_Tips : Form
    {
        LopDungChung lopchung;
        public string tdn { get; set; }
        public string noidung { get; set; }
        public frm_Tips()
        {
            InitializeComponent();
            lopchung = new LopDungChung();

        }
        public void LoadData()
        {
            string sqlLoad = "select * from TIPS order by liked desc";
            dataGridView1.DataSource = lopchung.LoadDuLieu(sqlLoad);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string sqlKT = "select count(*) from TIPS where tendangnhap = '" + tdn + "' and noidung = '" + txt_Add.Text + "'";
            int kq = (int)lopchung.Scalar(sqlKT);
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else if (kq >= 1)
                MessageBox.Show("This tip already exists");
            else
            {
                string sqlAdd = "insert into TIPS values('" + tdn + "', N'" + txt_Add.Text + "', '0')";
                lopchung.NonQuery(sqlAdd);
                LoadData();
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else
            {
                string sqlEdit = "update TIPS set noidung = '" + txt_Add.Text + "' where tendangnhap = '" + tdn + "' and noidung = '" + noidung + "'";
                lopchung.NonQuery(sqlEdit);
                LoadData();
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else
            {
                string sqlDelete = "delete from TIPS where tendangnhap = '" + tdn + "' and noidung = '" + noidung + "'";
                lopchung.NonQuery(sqlDelete);
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            noidung = dataGridView1.CurrentRow.Cells["noidung"].Value.ToString();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
