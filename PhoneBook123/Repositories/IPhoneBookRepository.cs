using PhoneBook.Api.Models;

namespace PhoneBook.Api.Repositories
{
    public interface IPhoneBookRepository
    {
        Task<BookPhone> AddAsync(string name, string number, long homeNumber);
    }
}
