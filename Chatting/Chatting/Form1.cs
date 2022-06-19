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

namespace Chatting
{
    public partial class Form1 : Form
    {
        public const int MessageSize = 1024;

        private static TcpListener listener;
        private static byte[] buf;
        private static List<TcpClient> clients;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buf = new byte[1024];
            clients = new List<TcpClient>();
            //폼 로드 시 local computer의 IP Address를 가져와, IP textbox의 text로 초기화 합니다.
            tb_ip.Text = GetMyIPAddress();
        }

        public string GetMyIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            //위 loop에서 return되지 않았을 시, 예외를 발생시킵니다.
            throw new Exception("# Exception: Unable to get your IPv4 Address.");
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                listener = new TcpListener(new IPEndPoint(IPAddress.Parse(tb_ip.Text), int.Parse(tb_port.Text)));
                listener.Start();

                //연결 시도를 받아들이는 비동기 작업을 시작하도록 합니다.
                //파라미터: AcceptCallback 프로시져를 수행할 대리자, 추가정보는 없습니다.
                listener.BeginAcceptTcpClient(new AsyncCallback(AcceptCallback), null);

                lb_chatBox.Items.Add("# Server가 시작되었습니다.");
                btn_connect.Text = "시작됨";
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

        private void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                //비동기적으로 접속 시도를 처리하고 해당 TcpClient 객체를 얻습니다.
                TcpClient client = listener.EndAcceptTcpClient(ar);
                clients.Add(client);
                lb_chatBox.Items.Add("# Client(" + client.Client.RemoteEndPoint + ") 와 연결되었습니다");
                
                //client의 네트워크 스트림에서 비동기 수신 작업을 시작하도록 합니다.
                //파라미터: 데이터를 받을 byte배열, 대리자, 추가정보 client
                client.GetStream().BeginRead(buf, 0, buf.Length, new AsyncCallback(ReceiveCallback), client);
            }
            catch (Exception ex)
            {
                lb_chatBox.Items.Add("# Exception: " + ex.Message);
            }
            finally
            {
                //다시 접속 시도 처리를 시작합니다.
                listener.BeginAcceptTcpClient(new AsyncCallback(AcceptCallback), null);
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                //추가정보로 받은 TcpClient 객체를 가져옵니다.
                TcpClient client = (TcpClient)ar.AsyncState;
                //ar: 완료해야 하는 비동기 요청에 대한 레퍼런스
                int bytes = client.GetStream().EndRead(ar);

                string strRead = Encoding.UTF8.GetString(buf, 0, bytes);
                string searchText = ","; //","를 기점으로 이름과 메시지를 구분합니다.
                string clientName = strRead.Substring(0, strRead.IndexOf(searchText));
                string clientMessage = strRead.Substring(strRead.IndexOf(searchText) + 1);

                lb_chatBox.Items.Add("Client(" + clientName + "): " + clientMessage);
                //다시 수신을 시작합니다.
                client.GetStream().BeginRead(buf, 0, buf.Length, new AsyncCallback(ReceiveCallback), client);
            }
            catch { }
        }
       
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (tb_msgInput.Text.Length <= 0) return;

            byte[] buffer = Encoding.UTF8.GetBytes(tb_msgInput.Text);

            //client 리스트를 참조하여, 메시지를 보냅니다.
            for (int i = clients.Count - 1; i >= 0; i--) //Connect된 Client에게 데이터 전송
            {
                TcpClient client = clients[i];
                try 
                { 
                    client.GetStream().Write(buffer, 0, buffer.Length);
                }
                catch (Exception)
                {
                    //응답 없는 클라이언트가 있으면 해당 connect을 닫고 리스트에서 삭제합니다.
                    client.Close();
                    clients.RemoveAt(i);
                }
            }
            lb_chatBox.Items.Add("Server: " + tb_msgInput.Text);
            tb_msgInput.Text = "";
            tb_msgInput.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!btn_send.Enabled) return;

            if (tb_msgInput.Focused && e.KeyCode == Keys.Enter)
                btn_send_Click(sender, e);
        }
    }
}
