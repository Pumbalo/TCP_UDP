using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class TcpServer
{
    public void Start()
    {
        TcpListener tcpListener = new TcpListener(IPAddress.Any, Settings.TCP_PORT); // Lyssna på alla nätverksgränssnitt på den angivna porten
        tcpListener.Start();
        Console.WriteLine($"TCP-server startad på port {Settings.TCP_PORT}. Väntar på anslutningar...");

        while (true)
        {
            TcpClient client = tcpListener.AcceptTcpClient(); // Vänta på en klientanslutning
            Console.WriteLine("TCP-klient ansluten.");
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("TCP-meddelande mottaget: " + message);
            stream.Close();
            client.Close();
        }
    }
}
