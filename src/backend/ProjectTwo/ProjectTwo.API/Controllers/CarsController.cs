using Microsoft.AspNetCore.Mvc;
using ProjectOne.API.Controllers;

namespace ProjectTwo.API.Controllers;

public class CarsController : BaseController
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] 
        {
            "Cars",
            "Volkswagen",
            "Skoda",
            "Octavia"
        };
    }
}
