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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Kitchen_Companion
{
    public partial class frm_SPENDING : Form
    {
        LopDungChung lopchung;
        public string tdn { get; set; }
        public frm_SPENDING()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void LoadData()
        {
            string sqlData = "select * from SPENDING where tendangnhap = '" + tdn + "'";
            dataGridViewSpending.DataSource = lopchung.LoadDuLieu(sqlData);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerDate.Value;
            int day = selectedDate.Day;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            string sqlAdd = "";
            if (cmbPartOfDay.Text == "breakfast")
            {
                sqlAdd = "if not exists (select 1 from SPENDING where tendangnhap = '" + tdn + "' and ngay = '" + month + "/" + day + "/" + year + "')" +
                    "   insert into SPENDING values('" + tdn + "', '" + month + "/" + day + "/" + year + "', 0, 0, 0);" +
                "update SPENDING set breakfast = breakfast + " + txtAmount.Text + " where tendangnhap = '" + tdn + "' and ngay = '" + month + "/" + day + "/" + year + "'";
            }
            else if (cmbPartOfDay.Text == "lunch")
            {
                sqlAdd = "if not exists (select 1 from SPENDING where tendangnhap = '" + tdn + "' and ngay = '" + month + "/" + day + "/" + year + "')" +
                    "   insert into SPENDING values('" + tdn + "', '" + month + "/" + day + "/" + year + "', 0, 0, 0);" +
                "update SPENDING set lunch = lunch + " + txtAmount.Text + " where tendangnhap = '" + tdn + "' and ngay = '" + month + "/" + day + "/" + year + "'";
            }
            else if (cmbPartOfDay.Text == "dinner")
            {
                sqlAdd = "if not exists (select 1 from SPENDING where tendangnhap = '" + tdn + "' and ngay = '" + month + "/" + day + "/" + year + "')" +
                    "   insert into SPENDING values('" + tdn + "', '" + month + "/" + day + "/" + year + "', 0, 0, 0);" +
                "update SPENDING set dinner = dinner + " + txtAmount.Text + " where tendangnhap = '" + tdn + "' and ngay = '" + month + "/" + day + "/" + year + "'";
            }
            lopchung.NonQuery(sqlAdd);
            LoadData();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerDate.Value;
            int day = selectedDate.Day;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            string sqlEdit = "";
            if (cmbPartOfDay.Text == "breakfast")
            {
                sqlEdit = "update SPENDING set breakfast = " + txtAmount.Text + " where tendangnhap = '" + tdn + "' and ngay = '" + month + "/" + day + "/" + year + "'";
            }
            else if (cmbPartOfDay.Text == "lunch")
            {
                sqlEdit = "update SPENDING set lunch = " + txtAmount.Text + " where tendangnhap = '" + tdn + "' and ngay = '" + month + "/" + day + "/" + year + "'";
            }
            else if (cmbPartOfDay.Text == "dinner")
            {
                sqlEdit = "update SPENDING set dinner = " + txtAmount.Text + " where tendangnhap = '" + tdn + "' and ngay = '" + month + "/" + day + "/" + year + "'";
            }
            lopchung.NonQuery(sqlEdit);
            LoadData();
        }

        private void dataGridViewSpending_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePickerDate.Value = (DateTime)dataGridViewSpending.CurrentRow.Cells["ngay"].Value;
        }

        private void frm_SPENDING_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerDate.Value;
            int day = selectedDate.Day;
            int month = selectedDate.Month;
            int year = selectedDate.Year;
            string sqlDelete = "delete from SPENDING where tendangnhap = '" + tdn + "' and ngay = '" + month + "/" + day + "/" + year + "'";
            lopchung.NonQuery(sqlDelete);
            LoadData();
        }
    }
}
