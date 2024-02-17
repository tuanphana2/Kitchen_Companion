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
    public partial class frm_EditRecipe : Form
    {
        LopDungChung lopchung;
        public string tdn { get; set; }
        public string tenmonan { get; set; }
        public frm_EditRecipe()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            LoadData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void frm_EditRecipe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string sqlLoad = "select count(*) from RECIPE where tenmonan = '" + tenmonan + "' and tendangnhap = '" + tdn + "'";
            int ketqua = (int)lopchung.Scalar(sqlLoad);
            if (ketqua >= 1)
            {
                string sqlNL = "select nguyenlieu from RECIPE where tenmonan = '" + tenmonan + "' and tendangnhap = '" + tdn + "'";
                string sqlCP = "select quytrinhnau from RECIPE where tenmonan = '" + tenmonan + "' and tendangnhap = '" + tdn + "'";
                txt_NOD.Text = tenmonan;
                rtb_Materials.Text = lopchung.GetValue(sqlNL);
                rtb_CP.Text = lopchung.GetValue(sqlCP);
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string sqlEdit = "update RECIPE set tenmonan = '" + txt_NOD.Text + "', nguyenlieu = '" + rtb_Materials.Text + "', quytrinhnau = '"
                + rtb_CP.Text + "' where tenmonan = '" + tenmonan + "' and tendangnhap = '" + tdn + "'";
            lopchung.NonQuery(sqlEdit);
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
