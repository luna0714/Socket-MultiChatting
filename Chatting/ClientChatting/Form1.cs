using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ClientChatting
{
    public partial class Form1 : Form
    {
        private static TcpClient client;
        private static byte[] buf;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buf = new byte[1024];
            tb_ip.Text = GetMyIPAddress();
            tb_name.Text = GetMyIPAddress();
        }
        public string GetMyIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            throw new Exception("# Exception: Unable to get your IPv4 Address.");
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tb_msgInput.Text.Length <= 0) return;

            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(tb_name.Text + "," + tb_msgInput.Text);
                client.GetStream().Write(buffer, 0, buffer.Length);
                lb_chatBox.Items.Add("Client(" + tb_name.Text + "): " + tb_msgInput.Text);
                tb_msgInput.Text = "";
                tb_msgInput.Focus();
            }
            catch (Exception ex)
            {
                lb_chatBox.Items.Add("Exception: " + ex.Message);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                MessageBox.Show("You are already connected to the server.");
                return;
            }

            try
            {
                client = new TcpClient(tb_ip.Text, int.Parse(tb_port.Text));
                client.GetStream().BeginRead(buf, 0, buf.Length, new AsyncCallback(ReceiveCallback), client);

                lb_chatBox.Items.Add("# Server에 연결되었습니다.");
                btn_connect.Text = "연결됨";
                tb_ip.Enabled = false;
                tb_port.Enabled = false;
                tb_name.Enabled = false;
                btn_connect.Enabled = false;
                btn_send.Enabled = true;
                tb_msgInput.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }
               
        private void ReceiveCallback(IAsyncResult ar)
        {
            int bytes = client.GetStream().EndRead(ar);
            string strRead = Encoding.UTF8.GetString(buf, 0, bytes);
            lb_chatBox.Items.Add("Server: " + strRead);

            client.GetStream().BeginRead(buf, 0, buf.Length, new AsyncCallback(ReceiveCallback), client);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!btn_send.Enabled) return;

            if (tb_msgInput.Focused && e.KeyCode == Keys.Enter)
                btn_send_Click(sender, e);
        }
    }
}
