using BaltaFundamentosPOO.NotificationContext;

namespace BaltaFundamentosPOO.SharedContext;

public abstract class Base : Notifiable
{
    public Guid Id { get; set; }

    public Base()
    {
        Id = Guid.NewGuid();
    }
}