using Microsoft.AspNetCore.Mvc;

namespace ProjectOne.API.Controllers;

public class UsersController : BaseController
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] 
        {
            "Muqimjon",
            "Mamadaliyev"
        };
    }
}
