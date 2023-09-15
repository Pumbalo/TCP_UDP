using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class UdpServer
{
    public void Start()
    {
        UdpClient udpListener = new UdpClient(Settings.UDP_PORT); // Lyssna på den angivna UDP-porten
        Console.WriteLine($"UDP-server startad på port {Settings.UDP_PORT}. Väntar på meddelanden...");

        while (true)
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, Settings.UDP_PORT); // Lyssna på alla nätverksgränssnitt på den angivna UDP-porten
            byte[] buffer = udpListener.Receive(ref clientEndPoint); // Vänta på UDP-meddelanden
            string message = Encoding.ASCII.GetString(buffer);
            Console.WriteLine("UDP-meddelande mottaget: " + message);
        }
    }
}
