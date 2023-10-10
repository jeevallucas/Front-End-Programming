namespace Model
{
    using System.ComponentModel.DataAnnotations;

    public class LoginModel
    {
        [Required(ErrorMessage = "*Username harus diisi")]
        public string Username { get; set; }

        [Required(ErrorMessage = "*Password harus diisi")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Konstruktor untuk menginisialisasi properti
        public LoginModel()
        {
            Username = "";
            Password = "";
        }
    }
}
