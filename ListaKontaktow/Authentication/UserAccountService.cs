namespace ListaKontaktow.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;
        public UserAccountService()
        {
            _users = new List<UserAccount>() {
            new UserAccount { UserName = "user", Password = "user" },
            new UserAccount { UserName = "user2", Password = "user2" }
            };
        }
        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
