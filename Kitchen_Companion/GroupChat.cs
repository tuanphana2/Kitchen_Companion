using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlClient;

namespace Kitchen_Companion
{

    public partial class frm_GroupChat : Form
    {
        private const int Port = 8888;
        private TcpClient client;
        private NetworkStream stream;
        private Thread clientThread;
        private LopDungChung lopchung;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Testing\Kitchen_Companion\KC.mdf;Integrated Security=True";
        public string tdn { get; set; }
        public frm_GroupChat()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void frm_GroupChat_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(IPAddress.Loopback, Port);
                stream = client.GetStream();

                clientThread = new Thread(ReceiveMessages);
                clientThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string message = txt_Nhap.Text;
            SendMessage(message);
            txt_Nhap.Text = string.Empty;
        }
        private void SendMessage(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);

            // Lưu trữ tin nhắn vào cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Messages (GroupName, MessageContent, Timestamp) VALUES (@GroupName, @MessageContent, @Timestamp)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GroupName", lbGroups.SelectedItem.ToString());
                command.Parameters.AddWithValue("@MessageContent", message);
                command.Parameters.AddWithValue("@Timestamp", DateTime.Now);

                command.ExecuteNonQuery();
            }
        }
        private void ReceiveMessages()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                int bytesRead = stream.Read(data, 0, data.Length);
                string message = Encoding.ASCII.GetString(data, 0, bytesRead);
                AddMessageToChat(message);
            }
        }
        private void AddMessageToChat(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddMessageToChat), message);
                return;
            }

            lbChat.Items.Add(message);
        }

        private void btn_CreateGroup_Click(object sender, EventArgs e)
        {
            frm_CreateGroup createGroupForm = new frm_CreateGroup();
            createGroupForm.ShowDialog();

            string groupName = createGroupForm.GroupName;
            lbGroups.Items.Add(groupName);
        }

        private void lbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbChat.Items.Clear();
            string selectedGroup = lbGroups.SelectedItem.ToString();
            List<string> messages = GetMessagesForGroup(selectedGroup);

            foreach (string message in messages)
            {
                lbChat.Items.Add(message);
            }
        }
        private List<string> GetMessagesForGroup(string groupName)
        {
            List<string> messages = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MessageContent FROM Messages WHERE GroupName = @GroupName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GroupName", groupName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string message = reader.GetString(0);
                        messages.Add(message);
                    }
                }
            }

            return messages;
        }
    }
}
