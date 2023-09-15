using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Client
{
    public void SendTcpMessage(string message)
    {
        TcpClient tcpClient = new TcpClient();
        tcpClient.Connect(IPAddress.Loopback, Settings.TCP_PORT); // Anslut till lokal TCP-server
        NetworkStream stream = tcpClient.GetStream();
        byte[] data = Encoding.ASCII.GetBytes(message);
        stream.Write(data, 0, data.Length); // Skicka meddelandet
        Console.WriteLine("TCP-meddelande skickat: " + message);
        stream.Close();
        tcpClient.Close();
    }

    public void SendUdpMessage(string message)
    {
        UdpClient udpClient = new UdpClient();
        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Loopback, Settings.UDP_PORT); // Skapa en ändpunkt för UDP-servern
        byte[] data = Encoding.ASCII.GetBytes(message);
        udpClient.Send(data, data.Length, serverEndPoint); // Skicka UDP-meddelandet
        Console.WriteLine("UDP-meddelande skickat: " + message);
        udpClient.Close();
    }
}
