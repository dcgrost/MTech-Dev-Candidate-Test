using UserController.Models;

namespace UserController.Services
{
    public class UserService
    {
        public List<User> ListUsers()
        {
            var users = new List<User>
            {
                new User(1, "John Doe", "john@example.com"),
                new User(2, "Jane Doe", "jane@example.com"),
                new User(3, "Bob Smith", "bob@example.com"),
                new User(4, "Alice Johnson", "alice@example.com"),
                new User(5, "Charlie Brown", "charlie@example.com"),
                new User(6, "Eva Williams", "eva@example.com"),
                new User(7, "David Clark", "david@example.com"),
                new User(8, "Grace Miller", "grace@example.com"),
                new User(9, "Frank Wilson", "frank@example.com"),
                new User(10, "Helen Davis", "helen@example.com")
            };

            return users;
        }
    }
}