class Program
{
    static void Main(string[] args)
    {
        LibraryManager library = new LibraryManager();

        library.AddItem(new Novel(1, "The Great Gatsby", "F. Scott Fitzgerald"));
        library.AddItem(new Magazine(2, "National Geographic", 125));
        library.AddItem(new TextBook(3, "Introduction to C#", "O'Reilly Media"));
        library.AddItem(new Novel(4, "1984", "George Orwell"));
        library.AddItem(new Magazine(5, "Time", 2023));

        Member alice = new Member("Alice");
        Member bob = new Member("Bob");

        library.RegisterMember(alice);
        library.RegisterMember(bob);

        library.ShowCatalog();

        System.Console.WriteLine("Alice's borrowing history:");
        LibraryItem? item = library.FindItemById(1);
        if (item != null)
            System.Console.WriteLine(alice.BorrowItem(item));

        item = library.FindItemById(2);
        if (item != null)
            System.Console.WriteLine(alice.BorrowItem(item));

        item = library.FindItemById(3);
        if (item != null)
            System.Console.WriteLine(alice.BorrowItem(item));

        item = library.FindItemById(4);
        if (item != null)
            System.Console.WriteLine(alice.BorrowItem(item));

        System.Console.WriteLine("\nAlice's borrowed items:");
        foreach (var borrowedItem in alice.GetBorrowedItems())
        {
            System.Console.WriteLine(borrowedItem.GetDetails());
        }

        item = library.FindItemById(2);
        if (item != null)
            System.Console.WriteLine("\n" + alice.ReturnItem(item));

        item = library.FindItemById(5);
        if (item != null)
            System.Console.WriteLine(alice.ReturnItem(item));
    }
}