using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace loginApp.Models
{
    public class Customer
    {

        Customer(string CompanyName,string ContactName,string ContactTitle,string Address, string City,string Region,string PostalCode,string Country,string Phone,string Fax)
        {
            this.CompanyName=CompanyName;
            this.ContactName=ContactName;
            this.ContactTitle = ContactTitle;
            this.Address = Address;
            this.City = City;
            this.Region = Region;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.Phone = Phone;
            this.Fax = Fax;

           
        }
       
        public int Id { get; set; } 
       [Required]
       public string CompanyName { get; set; } 
       [Required]
       public string  ContactName { get; set; } 
       [Required]
       public string  ContactTitle { get; set; } 
       [Required]
       public string  Address { get; set; } 
       [Required]
       public string  City { get; set; } 
       [Required]
       public string  Region { get; set; } 
       [Required]
       [DataType(DataType.PostalCode)]
       public string  PostalCode { get; set; } 
       [Required]
       public string  Country { get; set; } 
       [Required]
       [DataType(DataType.PhoneNumber)]
       public string  Phone { get; set; } 
       [Required]
       public string  Fax { get; set; } 

        public ICollection<Order> Orders { get; set; } 
    }
}