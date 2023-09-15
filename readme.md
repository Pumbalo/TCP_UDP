# Nätverksdemonstration

Detta är en enkel konsolapplikation som demonstrerar användning av TCP- och UDP-nätverkskommunikation i C#.

## Så här använder du programmet

1. **Starta TCP Server:** Välj alternativ 1 för att starta en TCP-server. Servern kommer att lyssna på anslutningar och visa inkommande meddelanden.

2. **Starta UDP Server:** Välj alternativ 2 för att starta en UDP-server. Servern kommer att lyssna på UDP-meddelanden och visa dem när de tas emot.

3. **Skicka TCP-meddelande:** Välj alternativ 3 för att skicka ett meddelande till en TCP-server. Du kommer att bli ombedd att ange meddelandet och det kommer att skickas till servern.

4. **Skicka UDP-meddelande:** Välj alternativ 4 för att skicka ett meddelande till en UDP-server. Du kommer att bli ombedd att ange meddelandet och det kommer att skickas till servern.

5. **Avsluta:** Välj alternativ 5 för att avsluta programmet.

## Anmärkningar

- Om du är i "Skicka TCP-meddelande" eller "Skicka UDP-meddelande" avsnitten, kan du fortsätta skicka meddelanden tills du väljer att gå tillbaka till huvudmenyn genom att ange "tillbaka" som meddelande.

- Konsolrutan kommer att rensas efter varje åtgärd för en renare användargränssnitt.

- Om du anger ogiltiga kommandon får du ett felmeddelande och blir ombedd att välja ett giltigt alternativ.

## Kör programmet

För att köra programmet, öppna två terminalfönster:

1. I det första terminalfönstret, navigera till projektets rotkatalog.

2. Kör kommandot `dotnet run`. Detta startar programmet och visar huvudmenyn i terminalen.

3. I det andra terminalfönstret, kan du också navigera till projektets rotkatalog och använda kommandot `dotnet run` för att starta ytterligare en instans av programmet, till exempel för att simulera en klient och server som kommunicerar med varandra.

Programmet är avsett för att demonstrera grundläggande nätverkskommunikation i C# och kan anpassas efter dina behov.

## Medverkande

- Simon Sjöö
