using Microsoft.AspNetCore.Mvc;

namespace ProjectOne.API.Controllers;

public class UsersController : BaseController
{
    [HttpGet("get")]
    public IEnumerable<string> Get()
    {
        return new string[] 
        {
            "Muqimjon",
            "Mamadaliyev"
        };
    }
}
