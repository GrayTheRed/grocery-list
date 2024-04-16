
namespace Domain
{
    internal interface IUser
    {
        Guid Id { get; }
        string Name { get; }
        string EmailAddress { get; }
    }
}
