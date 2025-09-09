using System.Collections.Generic;
using System.Linq;

public class LibraryManager
{
    private readonly List<LibraryItem> _catalog = new List<LibraryItem>();
    private readonly List<Member> _members = new List<Member>();

    public void AddItem(LibraryItem item)
    {
        _catalog.Add(item);
    }

    public void RegisterMember(Member member)
    {
        _members.Add(member);
    }

    public void ShowCatalog()
    {
        System.Console.WriteLine("\nLibrary Catalog:");
        System.Console.WriteLine("-----------------");
        foreach (var item in _catalog)
        {
            System.Console.WriteLine($"{item.Id}: {item.GetDetails()}");
        }
        System.Console.WriteLine();
    }

    public LibraryItem? FindItemById(int id) => _catalog.Find(i => i.Id == id);

    public Member? FindMemberByName(string name) => _members.Find(m => m.Name == name);
}