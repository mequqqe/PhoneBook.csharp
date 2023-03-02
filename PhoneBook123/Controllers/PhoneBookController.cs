using Microsoft.AspNetCore.Mvc;
using PhoneBook.Api.Services;

namespace PhoneBook.Api.Controllers;

[ApiController]
[Route("phone-book")]
public class PhoneBookController : ControllerBase
{
    private readonly IPhoneBookService _phoneBookService;

    public PhoneBookController(IPhoneBookService phoneBookService)
    {
        _phoneBookService = phoneBookService;
    }

    [HttpPost("add")]

    public async Task<ActionResult> AddAsync([FromQuery] string name, [FromQuery] string number, [FromQuery] long homeNumber)
    {
        return Ok(await _phoneBookService.AddAsync(name, number, homeNumber));
    }


}
