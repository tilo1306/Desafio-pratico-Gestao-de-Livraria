using desafioGestãoLivraria.Model;
using Microsoft.AspNetCore.Mvc;

namespace desafioGestãoLivraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    protected static List<Book> Db { get; set; } = [];
}
