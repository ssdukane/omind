using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OMinD.web.ViewModel
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string UserName { get; set; }
    }
}