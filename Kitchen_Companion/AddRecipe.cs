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
    public partial class frm_AddRecipe : Form
    {
        LopDungChung lopchung;
        public string tdn { get; set; }
        public frm_AddRecipe()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string sqlAdd = "insert into RECIPE values('" + tdn + "', N'" + txt_NOD.Text
                + "', N'" + rtb_Materials.Text + "', N'" + rtb_CP.Text + "', 0)";
            lopchung.NonQuery(sqlAdd);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
