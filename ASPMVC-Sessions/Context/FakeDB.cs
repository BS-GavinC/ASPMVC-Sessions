namespace ASPMVC_Sessions.Context
{
    public static class FakeDB
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User(1, "PaulK", "PaulKalkbrenner@Music.com", "Test123="),
            new User(2, "BillG", "BillGates@Business.com", "Test123=", true),
            new User(3, "MireilleM", "MireilleMathieu@Chanson.com", "Test123=")
        };
    }

    public class User
    {

        public User(int id, string userName, string email, string password, bool isAdmin = false)
        {
            Id = id;
            UserName = userName;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

    }
}
