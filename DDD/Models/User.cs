
namespace SpaUserControl.Domain.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
