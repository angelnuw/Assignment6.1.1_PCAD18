namespace Assignment6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nLinked List of Houses: ");
            HouseLinkedList mylist = new HouseLinkedList();
            mylist.AddLast(1, "123 Main St", "Single Family");
            mylist.AddLast(2, "456 Elm St", "Condo");
            mylist.AddLast(3, "789 Oak St", "Townhouse");
            mylist.AddLast(4, "101 Pine St", "Single Family");
            mylist.Display();

            Console.Write("\nEnter a house number to search: ");
            if (int.TryParse(Console.ReadLine(), out int searchNum))
            {
                var found = mylist.SearchByNumber(searchNum);
                if (found != null)
                {
                    Console.WriteLine($"House found: #{found.HouseNumber} | {found.Address} | {found.HouseType}");
                }
                else
                {
                    Console.WriteLine("House not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid house number.");
            }
        }
    }
}
