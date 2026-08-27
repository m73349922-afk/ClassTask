namespace Domain;

public interface IUserService
{
    void CreatUser(User user);
    List<User> GetAllUser();
    void UpdateUser(User user);
    void DeleteUser(int id);
}
