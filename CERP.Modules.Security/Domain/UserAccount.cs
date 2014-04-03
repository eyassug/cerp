namespace CERP.Modules.Security.Domain
{
   public class UserAccount
    {
      public int UserAccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
    }
}
