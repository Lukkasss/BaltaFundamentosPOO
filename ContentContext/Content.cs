using BaltaFundamentosPOO.NotificationContext;
using BaltaFundamentosPOO.SharedContext;

namespace BaltaFundamentosPOO.ContentContext;

public abstract class Content : Base
{
    public string Title { get; set; }
    public string Url { get; set; }

    public Content(string title, string url)
    {
        Title = title;
        Url = url;
    }
}