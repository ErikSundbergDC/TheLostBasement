namespace TheLostBasement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();

            rooms.Add(new Room("Trappan", "En mörk trapp som leder neråt."));
            rooms.Add(new Room("Ett mörkt rum", "Här nere i den mörka källaren ser du ingenting eftersom du inte har hittat den hemliga lyktan ännu."));
            rooms.Add(new Room("Ett mörkare rum", "Här nere i den mörka källaren ser du ingenting eftersom du inte har hittat den hemliga lyktan ännu."));
            rooms.Add(new Room("Mörkaste rummet", "Här nere i den mörka källaren ser du ingenting eftersom du inte har hittat den hemliga lyktan ännu."));
            rooms[0].North = rooms[1];
            rooms[1].South = rooms[0];
            rooms[1].West = rooms[2];
            rooms[2].East = rooms[1];
            rooms[2].South = rooms[3];
            rooms[3].North = rooms[2];

            PlayerCharacter playerCharacter = new PlayerCharacter("Erik");
            playerCharacter.Position = rooms[0];

            bool gameRunning = true;
            while(gameRunning)
            {
                playerCharacter.Position.Display();
                gameRunning = playerCharacter.PerformCommand();
            }

            Console.WriteLine("Nu lämnar du källaren!");

        }
    }
}
