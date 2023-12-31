using BaltaFundamentosPOO.SharedContext;

namespace BaltaFundamentosPOO.SubscriptionContext;

public class Student : Base
{
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

    public Student()
    {
        Subscriptions = new List<Subscription>();
    }
}