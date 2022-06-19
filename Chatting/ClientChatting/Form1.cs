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
            tb_otherIP.Text = getMyIPAddress();
            tb_myName.Text = getMyIPAddress();
        }
        public string getMyIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            throw new Exception("Ipv4주소 없습니다.");
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if(tb_send.Text.Length<=0)
            {
                MessageBox.Show("텍스트를 입력하세요.");
            }

            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(tb_myName.Text + "," + tb_send.Text);
                client.GetStream().Write(buffer, 0, buffer.Length);
                lb_chat.Items.Add("Client(" + tb_myName.Text + ") : " + tb_send.Text);
                tb_send.Text = "";
            }
            catch (Exception ex)
            {
                lb_chat.Items.Add("From btn_send_Click: " + ex.Message);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                MessageBox.Show("이미 연결되어 있습니다");
                return;
            }

            try
            {
                client = new TcpClient(tb_otherIP.Text, int.Parse(tb_otherPort.Text));
                client.GetStream().BeginRead(buf, 0, buf.Length, new AsyncCallback(ReceiveCallback), client);

                lb_chat.Items.Add("Server와 연결되었습니다");
                btn_connect.Text = "연결됨";
                btn_connect.Enabled = false;
                btn_send.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("From btn_connect_Click: " + ex.Message);
            }
        }
               
        private void ReceiveCallback(IAsyncResult ar)
        {
            int bytes = client.GetStream().EndRead(ar);
            string strRead = Encoding.UTF8.GetString(buf, 0, bytes);
            lb_chat.Items.Add("Server : " + strRead);

            client.GetStream().BeginRead(buf, 0, buf.Length, new AsyncCallback(ReceiveCallback), client);
        }      
    }
}
