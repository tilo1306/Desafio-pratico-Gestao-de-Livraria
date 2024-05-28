namespace desafioGestãoLivraria.Model;

public class Book
{


    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    public Genre Genre { get; set; }

    public decimal Value { get; set; }
    public int Stock { get; set; }
}

public enum Genre
{
    Ficção,
    Romance,
    Mistério
}