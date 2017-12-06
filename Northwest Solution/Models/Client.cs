using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Northwest_Solution.Models
{
    public class Client
    {
        //these are the attributes of my class and the validation for each one to make sure user input is correct
        [Key]
        public int? ClientID { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Please enter a username")]
        public string Username { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter a password")]
        public string Password { get; set; }

        [DisplayName("Re-Enter Password")]
        [Required(ErrorMessage = "Please enter a password")]
        public string RePassword { get; set; }

        [DisplayName("Client Name")]
        [Required(ErrorMessage = "Please enter valid client name")]
        public string ClientName { get; set; }

        [DisplayName("Rep Name")]
        [Required(ErrorMessage = "Please enter rep name")]
        public string RepName { get; set; }

        [DisplayName("Rep Phone")]
        [Required(ErrorMessage = "Please enter a phone number")]
        [RegularExpression(@"^\+?\(?\d+\)?(\s|\-|\.)?\d{1,3}(\s|\-|\.)?\d{4}[\s]*[\d]*$", ErrorMessage = "Please enter a valid Phone Number")]
        public string Phone { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Please enter an address")]
        public string Address { get; set; }

        [DisplayName("City")]
        [Required(ErrorMessage = "Please enter a City")]
        public string City { get; set; }

        [DisplayName("State")]
        [Required(ErrorMessage = "Please select a State")]
        [RegularExpression(@"^(?:(A[KLRZ]|C[AOT]|D[CE]|FL|GA|HI|I[ADLN]|K[SY]|LA|M[ADEINOST]|N[CDEHJMVY]|O[HKR]|P[AR]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY]))$", ErrorMessage = "Please enter a valid State")]
        public string State { get; set; }

        [DisplayName("Zip")]
        [Required(ErrorMessage = "Please enter a Zip Code")]
        [RegularExpression(@"^\d{5}([\-]\d{4})?$", ErrorMessage = "Please enter a valid Zip Code")]
        public int Zip { get; set; }

        [DisplayName("Country")]
        [Required(ErrorMessage = "Please enter a Country")]
        public string Country { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter an email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [DisplayName("Phone")]
        [Required(ErrorMessage = "Please enter a phone number")]
        [RegularExpression(@"^\+?\(?\d+\)?(\s|\-|\.)?\d{1,3}(\s|\-|\.)?\d{4}[\s]*[\d]*$", ErrorMessage = "Please enter a valid Phone Number")]
        public string ClientPhone { get; set; }


    }
}