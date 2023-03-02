using PhoneBook.Api.Models;
using PhoneBook.Api.Repositories;

namespace PhoneBook.Api.Services;

public class PhoneBookService : IPhoneBookService
{
    private readonly IPhoneBookRepository _phoneBookRepository;

    public PhoneBookService(IPhoneBookRepository phoneBookRepository)
    { 
        _phoneBookRepository = phoneBookRepository; 
    }

    public async Task<BookPhone> AddAsync(string name, string number, long homeNumber)
    {
        return await _phoneBookRepository.AddAsync(name, number, homeNumber);  
    }

    

  
}
