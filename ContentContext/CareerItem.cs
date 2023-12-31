using BaltaFundamentosPOO.NotificationContext;
using BaltaFundamentosPOO.SharedContext;

namespace BaltaFundamentosPOO.ContentContext;

public class CareerItem : Base
{
    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }

    public CareerItem(int order, string title, string description, Course course)
    {
        if (course is null)
            AddNotification(new Notification("Course", "O curso não pode ser nulo"));
        
        Order = order;
        Title = title;
        Description = description;
        Course = course;
    }
}