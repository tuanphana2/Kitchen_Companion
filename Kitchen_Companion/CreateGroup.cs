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
    public partial class frm_CreateGroup : Form
    {
        private List<string> createdGroups;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Testing\Kitchen_Companion\KC.mdf;Integrated Security=True";
        public string tdn { get; set; }
        public frm_CreateGroup()
        {
            InitializeComponent();
            createdGroups = new List<string>();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string GroupName { get; internal set; }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            GroupName = txtGroupName.Text;
            string groupName = txtGroupName.Text;

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Thực thi câu lệnh INSERT để chèn dữ liệu vào bảng "GROUP"
                string insertQuery = "INSERT INTO [dbo].[GROUP] ([manhom], [tennhom], [tendangnhap]) VALUES (@manhom, @tennhom, @tendangnhap)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@manhom", GenerateManhomValue()); // Tạo giá trị cho cột manhom
                command.Parameters.AddWithValue("@tennhom", groupName);
                command.Parameters.AddWithValue("@tendangnhap", GetLoggedInUsername()); // Lấy giá trị của cột tendangnhap từ người dùng đã đăng nhập

                command.ExecuteNonQuery();
            }

            // Sau khi tạo nhóm thành công, cập nhật danh sách các nhóm đã tạo
            createdGroups.Add(groupName);

            // Hiển thị danh sách các nhóm đã tạo
            DisplayCreatedGroups();

        }
        private void DisplayCreatedGroups()
        {
            // Xóa tất cả các nhóm đã hiển thị trước đó
            lbCreatedGroups.Items.Clear();

            // Hiển thị danh sách các nhóm đã tạo
            foreach (string group in createdGroups)
            {
                lbCreatedGroups.Items.Add(group);
            }
        }

        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            if (lbCreatedGroups.SelectedItem != null)
            {
                int selectedIndex = lbCreatedGroups.SelectedIndex;
                string selectedGroup = lbCreatedGroups.SelectedItem.ToString();

                // Tạo một form dialog mới
                using (var form = new Form())
                {
                    form.Text = "Change group name";

                    // Tạo một TextBox để người dùng nhập tên nhóm mới
                    var txtNewGroupName = new TextBox
                    {
                        Text = selectedGroup,
                        Dock = DockStyle.Fill
                    };

                    // Tạo một nút OK để người dùng xác nhận
                    var btnOK = new Button
                    {
                        Text = "OK",
                        DialogResult = DialogResult.OK,
                        Dock = DockStyle.Bottom
                    };

                    form.Controls.Add(txtNewGroupName);
                    form.Controls.Add(btnOK);

                    // Hiển thị form dialog và kiểm tra xem người dùng đã nhấn OK chưa
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string newGroupName = txtNewGroupName.Text;

                        if (!string.IsNullOrEmpty(newGroupName))
                        {
                            // Cập nhật tên nhóm mới trong danh sách createdGroups
                            createdGroups[selectedIndex] = newGroupName;
                            DisplayCreatedGroups();

                            // Kết nối đến cơ sở dữ liệu
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();

                                // Thực thi câu lệnh UPDATE để cập nhật tên nhóm trong cơ sở dữ liệu
                                string updateQuery = "UPDATE GROUP SET tennhom = @newGroupName WHERE [tennhom] = @oldGroupName";
                                SqlCommand command = new SqlCommand(updateQuery, connection);
                                command.Parameters.AddWithValue("@newGroupName", newGroupName);
                                command.Parameters.AddWithValue("@oldGroupName", selectedGroup);

                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (lbCreatedGroups.SelectedItem != null)
            {
                int selectedIndex = lbCreatedGroups.SelectedIndex;
                string selectedGroup = lbCreatedGroups.SelectedItem.ToString();

                // Xóa nhóm khỏi danh sách createdGroups
                createdGroups.RemoveAt(selectedIndex);
                DisplayCreatedGroups();

                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Thực thi câu lệnh DELETE để xóa nhóm khỏi cơ sở dữ liệu
                    string deleteQuery = "DELETE FROM [dbo].[GROUP] WHERE [tennhom] = @groupName";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@groupName", selectedGroup);

                    command.ExecuteNonQuery();
                }
            }
        }
        private string GenerateManhomValue()
        {
            // Hàm này được sử dụng để tạo giá trị cho cột "manhom" trong cơ sở dữ liệu
            Random random = new Random();
            int randomNumber = random.Next(1, 1000000);
            return randomNumber.ToString();
        }

        private string GetLoggedInUsername()
        {
            // Hàm này được sử dụng để lấy tên người dùng đã đăng nhập
            return "admin";
        }
    }

}
