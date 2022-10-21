namespace LibraryAPI.Entities.BookEntities;

public class BookItem
{
    private int Id;
    private bool _isReserved;
    private bool _isBorrowed;
    private List<DateOnly> _dueDate;
    private string _barCode;
}