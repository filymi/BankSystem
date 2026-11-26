public class Bank
{
    private readonly List<User> _users = new();
    public IReadOnlyList<User> Users => _users;

    public User? FindUser(string name)
    {
        foreach (var user in _users)
        {
            if (user.Name == name)
            {
                return user;
            }
        }
        return null;
    }

    public void AddUser(string name)
    {
        if (FindUser(name) != null){
            throw new InvalidOperationException("Пользователь с таким именем уже существует");
        }
        else
        {
            var user = new User(name);
            _users.Add(user);
            Console.WriteLine($"Пользователь {name} успешно добавлен");
        }
    }



}