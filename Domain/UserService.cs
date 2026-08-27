namespace Domain;

public class UserService : IUserService
{
    List<User> users = new List<User>();
    public void CreatUser(User user)
    {
        users.Add(user);
    }

    public void UpdateUser(User user)
    {
        foreach (var item in users)
        {
            if(item.Id == user.Id)
            {
                item.Name = user.Name;
                item.Email = user.Email;
            }
        }
    }

    public void DeleteUser(int id)
    {
        foreach (var item in users)
        {
            if(item.Id == id)
            {
                users.Remove(item);
            }
        }
    }

    public List<User> GetAllUser()
    {
        return users;
    }
}
