using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class BankSampahItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item Name is required")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Item Type is required")]
        public string ItemType { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        public BankSampahItem()
        {
            Id = 0;
            ItemName = "";
            ItemType = "";
            Quantity = 0;
        }
    }
}
