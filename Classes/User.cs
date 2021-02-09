namespace Solid.Classes
{
    public class User
    {
        private string Name { get; set; }
        private string Email { get; set; }

        public User(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
