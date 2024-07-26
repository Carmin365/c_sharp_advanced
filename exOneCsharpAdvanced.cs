using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] { "Oliver", "Alexandra", "Leo" };
    }
}

