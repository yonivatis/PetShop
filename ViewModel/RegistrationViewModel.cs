﻿using System.ComponentModel.DataAnnotations;

namespace PetShopProject.ViewModel
{
    public class RegistrationViewModel
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match!")]
        public string? ConfirmPassword { get; set; }
    }
}
