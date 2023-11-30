namespace TTRPG_Character_Builder.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Ensure this is hashed in the actual implementation
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
