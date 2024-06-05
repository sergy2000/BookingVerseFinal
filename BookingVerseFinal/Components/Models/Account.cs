namespace BookingVerseFinal.Components.Models
{
    public class Account
    {
        public int UserID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }

        public Account() 
        {
            UserID = 0;
            Password = string.Empty;
            Email = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public Account(int userID, string password, string email, string firstName, string lastName)
        {
            UserID = userID;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
