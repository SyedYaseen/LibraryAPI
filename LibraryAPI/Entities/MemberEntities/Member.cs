using LibraryAPI.Entities.BookEntities;

namespace LibraryAPI.Entities.MemberEntities;

public class Member
{
    private List<BookItem> _booksCheckedOut = new List<BookItem>(5);
    private LibraryCard _libraryCard;
}