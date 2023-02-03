using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MonitorControl
{
    internal class RemoteServer
    {
        private TcpListener server { get; set; }

        public RemoteServer(int port)
        {
            server = TcpListener.Create(port);
        }

        public void Start()
        {
            server.Start();
            server.BeginAcceptTcpClient(new AsyncCallback(TcpClientCallback), server);
        }

        private static void TcpClientCallback(IAsyncResult ar)
        {
            TcpListener server = ar.AsyncState as TcpListener;
            using (TcpClient client = server.EndAcceptTcpClient(ar))
            {
                if (client.Connected)
                {
                    server.BeginAcceptTcpClient(new AsyncCallback(TcpClientCallback), server);
                    ProcessClient(client);
                }
            }
        }

        private static void ProcessClient(TcpClient client)
        {
            using (StreamReader sr = new StreamReader(client.GetStream()))
            {
                string data = sr.ReadToEnd();
                if (!data.Contains("[MRC]:"))
                    return;
                string message = data.Split(':').Last();
                HotkeyEvent.Hotkey_EventTrigger(null, new CustomEventArgs(message));
            }
        }
    }
}
