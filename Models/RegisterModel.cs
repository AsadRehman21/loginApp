using System.ComponentModel.DataAnnotations;

namespace loginApp.Models
{
    public class RegisterModel
    {
        [Required]
        public string Fname {get;set;}

        [Required]
        public string Lname {get;set;}
       
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Password doesn't match")]
        public string confirmPassword {get;set;}
    }
}