namespace MaakJeNietDrugLogic.ClassesLogic
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public Account(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }

        public Account()
        {
        }
    }
}