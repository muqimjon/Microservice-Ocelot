using Microsoft.AspNetCore.Mvc;
using ProjectOne.API.Controllers;

namespace ProjectThree.API.Controllers;

public class CoursesController : BaseController
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[]
        {
            "Programming",
            "English",
            "Math",
            "Agile",
            "Scrum"
        };
    }
}
