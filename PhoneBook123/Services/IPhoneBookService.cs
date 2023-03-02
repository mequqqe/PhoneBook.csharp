using PhoneBook.Api.Models;

namespace PhoneBook.Api.Services;

public interface IPhoneBookService
{
    Task<BookPhone> AddAsync(string name, string number, long homeNumber);
}
