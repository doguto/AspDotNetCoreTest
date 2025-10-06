using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ArticlesController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok(new List<string> { "Article 1", "Article 2" });
    }

    [HttpGet("{id}")]
    public IActionResult Show(int id)
    {
        return Ok($"Article {id}");
    }
}
