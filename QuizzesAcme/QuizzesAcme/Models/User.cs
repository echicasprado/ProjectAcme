namespace QuizzesAcme.Models.User
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = "example@acme";
        public string Password { get; set; } = "1234";

        public User(int id, string email, string password)
        {
            this.Id= id;
            this.Email = email;
            this.Password = password;
        }

        public User() { }
    }
}
