namespace TheLostBasement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();

            rooms.Add(new Room("Trappan", "En mörk trapp som leder neråt."));
            rooms.Add(new Room("Ett mörkt rum", "Här nere i den mörka källaren ser du ingenting eftersom du inte har hittat den hemliga lyktan ännu."));
            rooms[0].North = rooms[1];
            rooms[1].South = rooms[0];


            foreach (Room room in rooms)
            {
                room.Display();
                
                Console.WriteLine();
            }
         


        }
    }
}
