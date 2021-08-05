using System.ComponentModel.DataAnnotations;

namespace loginApp.Models
{
    public class Order
    {
        public int Id {get;set;}
        [Required]
        [DataType(DataType.Date)]
        public string OrderDate {get;set;}
        [Required]
        [DataType(DataType.Date)]
        public string RequiredDate {get;set;}
    }
}