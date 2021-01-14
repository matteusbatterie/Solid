namespace Solid.Classes
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}