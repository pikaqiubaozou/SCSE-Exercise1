using System.Collections.Generic;

public class Member
{
    private readonly string _name;
    private readonly List<LibraryItem> _borrowedItems = new List<LibraryItem>();

    public string Name => _name;

    public Member(string name)
    {
        _name = name;
    }

    public string BorrowItem(LibraryItem item)
    {
        if (_borrowedItems.Count >= 3)
        {
            return "You cannot borrow more than 3 items.";
        }

        _borrowedItems.Add(item);
        return $"{item.Title} has been added to {_name}'s borrowed items.";
    }

    public string ReturnItem(LibraryItem item)
    {
        if (_borrowedItems.Contains(item))
        {
            _borrowedItems.Remove(item);
            return $"{item.Title} has been successfully returned.";
        }

        return $"{item.Title} was not in {_name}'s borrowed items.";
    }

    public List<LibraryItem> GetBorrowedItems()
    {
        return _borrowedItems.ToList();
    }
}
