using System;

class Program
{
    static TcpServer tcpServer = new TcpServer();
    static UdpServer udpServer = new UdpServer();
    static Client client = new Client();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear(); // Rensa skärmen för en renare användargränssnitt
            Console.WriteLine("Välkommen till Nätverksdemonstration");
            Console.WriteLine("1) Starta TCP Server");
            Console.WriteLine("2) Starta UDP Server");
            Console.WriteLine("3) Skicka TCP-meddelande");
            Console.WriteLine("4) Skicka UDP-meddelande");
            Console.WriteLine("5) Avsluta");

            Console.Write("Ange ditt val: ");
            var inputText = Console.ReadLine();

            switch (inputText)
            {
                case "1":
                    Console.Clear();
                    tcpServer.Start(); // Starta TCP-servern
                    break;

                case "2":
                    Console.Clear();
                    udpServer.Start(); // Starta UDP-servern
                    break;

                case "3":
                    Console.Clear();
                    while (true)
                    {
                        Console.Write("Ange TCP-meddelande (eller skriv 'tillbaka' för att återgå till huvudmenyn): ");
                        var tcpMessage = Console.ReadLine();

                        if (tcpMessage.ToLower() == "tillbaka")
                            break;

                        client.SendTcpMessage(tcpMessage); // Skicka TCP-meddelandet
                    }
                    break;

                case "4":
                    Console.Clear();
                    while (true)
                    {
                        Console.Write("Ange UDP-meddelande (eller skriv 'tillbaka' för att återgå till huvudmenyn): ");
                        var udpMessage = Console.ReadLine();

                        if (udpMessage.ToLower() == "tillbaka")
                            break;

                        client.SendUdpMessage(udpMessage); // Skicka UDP-meddelandet
                    }
                    break;

                case "5":
                    Environment.Exit(0); // Avsluta programmet
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Välj ett giltigt alternativ.");
                    WaitForEnter();
                    break;
            }
        }
    }

    static void WaitForEnter()
    {
        Console.WriteLine("\nTryck på Enter för att fortsätta...");
        Console.ReadLine();
    }
}
