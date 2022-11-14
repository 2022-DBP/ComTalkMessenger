using System.Net.Sockets;
using System.Net;
using System.Text;

namespace ChattingFormServerCversion
{
    public partial class FormServer : Form
    {//���� ��ȭ�� �ִ��� query�� Ȯ���ϰ�, ������ ���� ���� ����, ������ ���� ���Ͽ� �����ϰ� ��ȭ ���� �ҷ�����
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate _textAppender;
        Socket mainSock;
        IPAddress thisAddress;
        Socket client;

        public FormServer()
        {
            InitializeComponent();
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            _textAppender = new AppendTextDelegate(AppendText);
        }

        void AppendText(Control ctrl, string s)
        {
            if (ctrl.InvokeRequired) ctrl.Invoke(_textAppender, ctrl, s);
            else
            {
                string source = ctrl.Text;
                ctrl.Text = source + Environment.NewLine + s;
            }
        }

        

        List<Socket> connectedClients = new List<Socket>();
        void AcceptCallback(IAsyncResult ar)
        {
            // Ŭ���̾�Ʈ�� ���� ��û�� �����Ѵ�.
            client = mainSock.EndAccept(ar);

            // �� �ٸ� Ŭ���̾�Ʈ�� ������ ����Ѵ�.
            mainSock.BeginAccept(AcceptCallback, null);

            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = client;

            // ����� Ŭ���̾�Ʈ ����Ʈ�� �߰����ش�.
            connectedClients.Add(client);

            // �ؽ�Ʈ�ڽ��� Ŭ���̾�Ʈ�� ����Ǿ��ٰ� ���ش�.
            AppendText(textBoxHistory, string.Format("Ŭ���̾�Ʈ (@ {0})�� ����Ǿ����ϴ�.", client.RemoteEndPoint));

            // Ŭ���̾�Ʈ�� �����͸� �޴´�.
            client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        void DataReceived(IAsyncResult ar)
        {
            // BeginReceive���� �߰������� �Ѿ�� �����͸� AsyncObject �������� ��ȯ�Ѵ�.
            AsyncObject obj = (AsyncObject)ar.AsyncState;

            // ������ ������ ������.
            try
            {
                int received = obj.WorkingSocket.EndReceive(ar);
            }
            catch (Exception e)
            { // ���� �����Ͱ� ������(���������) ������.
                AppendText(textBoxHistory, string.Format("Ŭ���̾�Ʈ ������ ���������ϴ�."));
                return;
            }

            // �ؽ�Ʈ�� ��ȯ�Ѵ�.
            string text = Encoding.UTF8.GetString(obj.Buffer);

            // 0x01 �������� ¥����.
            // tokens[0] - ���� ��� IP
            // tokens[1] - ���� �޼���
            string[] tokens = text.Split('\x01');
            string ip = tokens[0];
            string msg = tokens[1];

            // �ؽ�Ʈ�ڽ��� �߰����ش�.
            // �񵿱������ �۾��ϱ� ������ ���� UI �����忡�� �۾��� ����� �Ѵ�.
            // ���� �븮�ڸ� ���� ó���Ѵ�.
            AppendText(textBoxHistory, string.Format("[����]{0}: {1}", ip, msg));

            // for�� ���� "����"���� Ŭ���̾�Ʈ���� �����͸� ������.
            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                if (socket != obj.WorkingSocket)
                {
                    try { socket.Send(obj.Buffer); }
                    catch
                    {
                        // ���� �߻��ϸ� ���� ����ϰ� ����Ʈ���� �����Ѵ�.
                        try { socket.Dispose(); } catch { }
                        connectedClients.RemoveAt(i);
                    }
                }
            }

            // �����͸� ���� �Ŀ� �ٽ� ���۸� ����ְ� ���� ������� ������ ����Ѵ�.
            obj.ClearBuffer();

            // ���� ���
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

       

        private void FormServer_Load(object sender, EventArgs e)
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());

            // ó������ �߰ߵǴ� ipv4 �ּҸ� ����Ѵ�.
            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisAddress = addr;
                    break;
                }
            }

            // �ּҰ� ���ٸ�..
            if (thisAddress == null)
                // ����ȣ��Ʈ �ּҸ� ����Ѵ�.
                thisAddress = IPAddress.Loopback;

            textBoxAddress.Text = thisAddress.ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {           
                int port;
                if (!int.TryParse(textBoxPort.Text, out port))
                {
                    MessageBox.Show("��Ʈ ��ȣ�� �߸� �ԷµǾ��ų� �Էµ��� �ʾҽ��ϴ�.");
                    textBoxPort.Focus();
                    textBoxPort.SelectAll();
                    return;
                }

                // �������� Ŭ���̾�Ʈ�� ���� ��û�� ����ϱ� ����
                // ������ ����д�.
                IPEndPoint serverEP = new IPEndPoint(thisAddress, port);
                mainSock.Bind(serverEP);
                mainSock.Listen(10);

                // �񵿱������� Ŭ���̾�Ʈ�� ���� ��û�� �ޱ� ����
                mainSock.BeginAccept(AcceptCallback, null);//AcceptCallback���� ���� ��û ����, Ŭ���̾�Ʈ ������ ���            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // ������ ��������� Ȯ���Ѵ�.
            if (!mainSock.IsBound)
            {
                MessageBox.Show("������ ����ǰ� ���� �ʽ��ϴ�!");
                return;
            }

            // ���� �ؽ�Ʈ
            string tts = textBoxSend.Text.Trim();
            if (string.IsNullOrEmpty(tts))
            {
                MessageBox.Show("�ؽ�Ʈ�� �Էµ��� �ʾҽ��ϴ�!");
                textBoxSend.Focus();
                return;
            }

            // ���ڿ��� utf8 ������ ����Ʈ�� ��ȯ�Ѵ�.
            byte[] bDts = Encoding.UTF8.GetBytes(thisAddress.ToString() + '\x01' + tts);

            // ����� ��� Ŭ���̾�Ʈ���� �����Ѵ�.
            for (int i = connectedClients.Count - 1; i >= 0; i--)
            {
                Socket socket = connectedClients[i];
                try { socket.Send(bDts); }
                catch
                {
                    // ���� �߻��ϸ� ���� ����ϰ� ����Ʈ���� �����Ѵ�.
                    try { socket.Dispose(); } catch { }
                    connectedClients.RemoveAt(i);
                }
            }

            // ���� �Ϸ� �� �ؽ�Ʈ�ڽ��� �߰��ϰ�, ������ ������ �����.
            AppendText(textBoxHistory, string.Format("[����]{0}: {1}", thisAddress.ToString(), tts));
            textBoxSend.Clear();
        }
    }
}