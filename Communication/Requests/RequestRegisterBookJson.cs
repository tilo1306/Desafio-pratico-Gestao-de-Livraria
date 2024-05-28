using desafioGestãoLivraria.Model;

namespace desafioGestãoLivraria.Communication.Requests;

public class RequestRegisterBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    public Genre Genre { get; set; }

    public decimal Value { get; set; }
    public int Stock { get; set; }
}
