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
    public partial class frm_Detail : Form
    {
        LopDungChung lopchung;
        public string tdn { get; set; }
        public string nameofdish { get; set; }
        public frm_Detail()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void LoadData()
        {
            lbtb_NOD.Text = nameofdish;
            string sqlMaterial = "select nguyenlieu from RECIPE where tendangnhap = '" + tdn
                + "' and tenmonan = '" + nameofdish + "'";
            string sqlCP = "select quytrinhnau from RECIPE where tendangnhap = '" + tdn
                + "' and tenmonan = '" + nameofdish + "'";
            lbtb_CP.Text = lopchung.GetValue(sqlCP);
            lbtb_NAWOM.Text = lopchung.GetValue(sqlMaterial);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Detail_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
