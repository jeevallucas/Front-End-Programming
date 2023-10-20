namespace Model
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Role { get; set; }
    }
}
