using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;
namespace windows_app
{
    public delegate void DataAvailableEventHandler(Object sender, DataAvailableEventArgs e);

    public class DataAvailableEventArgs : EventArgs
    {

        public DataAvailableEventArgs(Socket socket, Stream stream)
        {
            this.socket = socket;
            this.stream = stream;
        }
        public Socket socket { get; set; }
        public Stream stream { get; set; }
        public bool Connected { get; set; }
        public bool Error { get; set; }
        public bool Data_avaiable { get; set; }
        public string? Data { get; set; }
        public void Send(string msg) 

        {
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream)
            { AutoFlush = true };
            if(socket.Connected)
            {
                writer.WriteLine(msg);
            }
            
        }
    }
    internal class ServerClass
    {
        //---------events
        public event DataAvailableEventHandler DataAvailalble;

        protected virtual void OnDataAvailable(DataAvailableEventArgs e)
        {
            DataAvailableEventHandler handler = DataAvailalble;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        //---------------
        Thread t;

        int port;
        public bool connected;
        public ServerClass(int port)
        {
            connected = false;
            this.port = port;
            t = new Thread(new ThreadStart(srun));
            t.Start();
        }

        public void sendToClient(Socket socket, Stream stream, string msg)
        {
            if (socket != null)
            {
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream)
                { AutoFlush = true };

                writer.WriteLine(msg);
            }
            
        }
        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        private void srun()
        {
            TcpListener myListner = new
            TcpListener(new IPAddress(0x00000000), port);
            myListner.Start();
            bool quit = false;

            while (!quit)
            {
                Socket mySocket = myListner.AcceptSocket();
                Stream myStream = new NetworkStream(mySocket);
                StreamReader reader = new StreamReader(myStream);
                StreamWriter writer = new StreamWriter(myStream)
                { AutoFlush = true };
                while (!quit)
                {
                    connected = true;
                    try
                    {
                        string text = reader.ReadLine();


                        if (text != null && text.ToLower() == "quit")
                        {
                            myStream.Close();
                            mySocket.Close();
                            quit = true;
                        }
                        if (text != null)
                        {
                            DataAvailableEventArgs args = new DataAvailableEventArgs(mySocket,myStream);

                            args.Data_avaiable = true;
                            args.Connected = true;
                            args.Error = false;
                            args.Data = text;
                            args.socket = mySocket;
                            args.stream = myStream;
                           
                            OnDataAvailable(args);
                        }
                    }
                    catch (Exception e)
                    {
                        DataAvailableEventArgs args = new DataAvailableEventArgs(mySocket, myStream);
                        args.Data_avaiable = true;
                        args.Connected = false;
                        args.Error = true;
                        args.Data = e.Message;
                        OnDataAvailable(args);

                        try
                        {
                            myStream.Close();
                            mySocket.Close();
                            quit = true;
                        }
                        catch
                        {
                            quit = true;
                            args.Data = args.Data + "socket close error";
                        }
                    }
                
                    try
                    {
                        DataAvailableEventArgs args = new DataAvailableEventArgs(mySocket, myStream);
                    }
                    catch(Exception e)
                    {
                        DataAvailableEventArgs args = new DataAvailableEventArgs(mySocket, myStream);
                        args.Data_avaiable = true;
                        args.Connected = false;
                        args.Error = true;
                        args.Data = e.Message;
                        OnDataAvailable(args);

                        try
                        {
                            myStream.Close();
                            mySocket.Close();
                            quit = true;
                        }
                        catch
                        {
                            args.Data = args.Data + "socket close error";
                            quit = true;
                        }
                    }
                    
                   
                }

            }

        }

    }
}
