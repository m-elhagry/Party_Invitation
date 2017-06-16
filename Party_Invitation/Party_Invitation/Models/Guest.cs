using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Party_Invitation.Models
{
    public class Guest
    {
        [Required(ErrorMessage = "Please enter your Name")]
        [DisplayName("Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter your E-mail")]
        [DisplayName("Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter your Phone")]
        [DisplayName("Phone")]
        [StringLength(11, ErrorMessage = "Please enter a phone number", MinimumLength = 11)]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Please specify whether you will attend?")]
        [DisplayName("WillAttend")]
        public bool? WillAttend { get; set; }
    }
}