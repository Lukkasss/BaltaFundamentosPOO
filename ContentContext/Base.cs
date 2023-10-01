using BaltaFundamentosPOO.NotificationContext;

namespace BaltaFundamentosPOO.ContentContext;

public abstract class Base : Notifiable
{
    public Guid Id { get; set; }

    public Base()
    {
        Id = Guid.NewGuid();
    }
}