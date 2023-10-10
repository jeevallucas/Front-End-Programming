namespace Model
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterModel
    {
        [Required(ErrorMessage = "*Username harus diisi")]
        public string Username { get; set; }

        [Required(ErrorMessage = "*Password harus diisi")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "*Nama harus diisi")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Alamat harus diisi")]
        public string Address { get; set; }

        [Required(ErrorMessage = "*Nomor Telepon harus diisi")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "*Peran harus dipilih")]
        public string Role { get; set; }

        // Konstruktor untuk menginisialisasi properti
        public RegisterModel()
        {
            Username = "";
            Password = "";
            Name = "";
            Address = "";
            Phone = "";
            Role = "";
        }
    }
}
