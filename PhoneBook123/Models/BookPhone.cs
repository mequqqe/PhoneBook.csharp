namespace PhoneBook.Api.Models;

public class BookPhone
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Phone { get; set; }
    public long HomeNumber { get; set; }
}
