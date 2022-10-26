namespace ASPMVC_Sessions.Context
{
    public static class FakeDB
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User(1, "PaulK", "PaulKalkbrenner@Music.com", "Test123="),
            new User(2, "BillG", "BillGates@Business.com", "Test123="),
            new User(3, "MireilleM", "MireilleMathieu@Chanson.com", "Test123=")
        };
    }

    public class User
    {

        public User(int id, string userName, string email, string password)
        {
            Id = id;
            UserName = userName;
            Email = email;
            Password = password;
        }
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
