using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_Companion
{
    public class LopDungChung
    {
        string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Testing\Kitchen_Companion\KC.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(ketnoi);
        }

        public object Username { get; internal set; }

        public DataTable LoadDuLieu(string sqlLoad)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlLoad, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void NonQuery(string sqlNon)
        {
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketqua >= 1)
                MessageBox.Show("Success");
            else
                MessageBox.Show("Fail");
        }
        public object Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
        public string GetValue(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            string ketqua = comm.ExecuteScalar()?.ToString();
            conn.Close();
            return ketqua;
        }
    }
}
