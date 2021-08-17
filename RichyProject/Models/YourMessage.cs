using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RichyProject.Models
{
    public class YourMessage
    {
        public int Id { get; set; }
        [DataType(DataType.Text), Required, MinLength(3, ErrorMessage ="Name cannot be less than three letter"), 
        MaxLength(30, ErrorMessage ="Name cannot be more than 20 character"), DisplayName("Full Name")]
        public string Name { get; set; }
        [DataType(DataType.PhoneNumber), Display(Name = "Phone Number"), MaxLength(14, ErrorMessage = "Your Phone Number cannot exceed 11 digits"), Required]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Text), Required]
        public string Subject { get; set; }
        [DataType(DataType.MultilineText), Required]
        public string Message { get; set; }


    }
}
