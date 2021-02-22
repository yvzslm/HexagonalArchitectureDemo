namespace Domain.User.Ports.Outgoing
{
    public interface IUserRepository
    {
        UserEntity Add(UserEntity user);
    }
}
