using Domain;

User user = new User()
{
    Id = 2,
    Name = "Muhammad",
    Email = "134"
};

UserService service = new UserService();
service.CreatUser(user);
service.UpdateUser(user);
service.DeleteUser(1);
var get = service.GetAllUser();

foreach (var item in get)
{
    Console.WriteLine($"Id: {item.Id}");
    Console.WriteLine($"Name: {item.Name}");
    Console.WriteLine($"Email: {item.Email}");
}
