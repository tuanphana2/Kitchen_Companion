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
    public partial class frm_YourRecipe : Form
    {
        LopDungChung lopchung;
        public string tdn { get; set; }
        public string tenmonan { get; set; }
        public frm_YourRecipe()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void LoadData()
        {
            string sqlLoad = "select * from RECIPE where tendangnhap = '" + tdn + "'";
            dataGridView1.DataSource = lopchung.LoadDuLieu(sqlLoad);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_AddRecipe"] == null)
            {
                frm_AddRecipe NV = new frm_AddRecipe();
                NV.tdn = tdn;
                NV.MdiParent = this.MdiParent;
                NV.Show();
            }
            else Application.OpenForms["frm_AddRecipe"].Activate();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_EditRecipe"] == null)
            {
                frm_EditRecipe NV = new frm_EditRecipe();
                NV.tdn = tdn;
                NV.tenmonan = tenmonan;
                NV.MdiParent = this.MdiParent;
                NV.Show();
            }
            else Application.OpenForms["frm_EditRecipe"].Activate();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string sqlDelete = "delete from RECIPE where tendangnhap = '" + tdn + "' and tenmonan = N'" + tenmonan + "'";
            lopchung.NonQuery(sqlDelete);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tenmonan = dataGridView1.CurrentRow.Cells["tenmonan"].Value.ToString();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frm_YourRecipe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
