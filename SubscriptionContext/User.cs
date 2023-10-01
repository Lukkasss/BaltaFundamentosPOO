using BaltaFundamentosPOO.SharedContext;

namespace BaltaFundamentosPOO.SubscriptionContext;

public class User : Base
{
    public string Username { get; set; }
    public string Password { get; set; }
}