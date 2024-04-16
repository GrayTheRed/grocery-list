
namespace Domain
{
    public interface IUser
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string EmailAddress { get; set; }
    }
}
