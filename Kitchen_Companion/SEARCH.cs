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
    public partial class frm_Search : Form
    {
        LopDungChung lopchung;
        public string tdn { get; set; }
        public string nameofdish { get; set; }
        public frm_Search()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void LoadData()
        {
            string sqlLoad = "SELECT * FROM RECIPE";
            dataGridView1.DataSource = lopchung.LoadDuLieu(sqlLoad);
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string sqlSearch = "select * from RECIPE where tenmonan = '" + txt_Search.Text + "'";
            dataGridView1.DataSource = lopchung.LoadDuLieu(sqlSearch);
        }

        private void frm_Search_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tdn = dataGridView1.CurrentRow.Cells["tendangnhap"].Value.ToString();
            nameofdish = dataGridView1.CurrentRow.Cells["tenmonan"].Value.ToString();

        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Detail"] == null)
            {
                frm_Detail NV = new frm_Detail();
                NV.tdn = tdn;
                NV.nameofdish = nameofdish;
                NV.MdiParent = this.MdiParent;
                NV.Show();
            }
            else Application.OpenForms["frm_Detail"].Activate();
        }
    }
}
