using desafioGestãoLivraria.Communication.Requests;
using desafioGestãoLivraria.Model;
using Microsoft.AspNetCore.Mvc;

namespace desafioGestãoLivraria.Controllers;

public class BookController : BaseController
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult Created([FromBody] RequestRegisterBookJson request)
    {
        Book newBook = new()
        {
            Id = Db.Count + 1,
            Author = request.Author,
            Genre = request.Genre,
            Stock = request.Stock,
            Title = request.Title,
            Value = request.Value
        };

        Db.Add(newBook);

        return Created(string.Empty, string.Empty);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetBooks()
    {
        return Ok(Db.ToList());
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    public IActionResult GetBook([FromRoute] int id)
    {
        var book = Db.Where<Book>(x => x.Id == id);

        return Ok(book);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    public IActionResult UpdateBook([FromRoute] int id, [FromBody] RequestRegisterBookJson request)
    {
        var book = Db.FirstOrDefault<Book>(x => x.Id == id);

        book!.Title = request.Title;
        book.Author = request.Author;
        book.Genre = request.Genre;
        book.Stock = request.Stock;
        book.Title = request.Title;
        book.Value = request.Value;


        return Ok(book);
    }


    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteBook([FromRoute] int id)
    {
        var books = Db.Where(x => x.Id != id);

        Db = books.ToList();
        return NoContent();
    }
}
