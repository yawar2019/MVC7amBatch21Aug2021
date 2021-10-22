using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC7amBatch21Aug2021.Models
{
    public class RegistrationModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="UserName Cannot be Empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="pwd and cpwd is not matched")]
        public string ConfirmPassword { get; set; }
        [Range(18,45,ErrorMessage ="Age Shouldbe between 18-45")]
        public int Age { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid EmailAddress")]
        [Required]
        public string EmailId { get; set; }
        [StringLength(10,ErrorMessage ="More then 10 it is not valid")]
        public string Address { get; set; }
    }
}