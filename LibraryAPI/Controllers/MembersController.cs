using LibraryAPI.Entities.MemberEntities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;

public class MembersController : Controller
{
    //To be used by Admin/ System
    public Member GetMember(string barcode)
    {
        var libraryCard = GetLibraryCardDetails(barcode);
        return new Member();
    }

    private LibraryCard GetLibraryCardDetails(string barcode)
    {
        return new LibraryCard();
    }
}