using System.ComponentModel.DataAnnotations;

namespace loginApp.Models
{
    public class loginModel
    {
        
       
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email {get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        public bool rememberme {get;set;}
    }
}