using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace chromus.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage = "Username or Email is required.")]
    [MaxLength(20, ErrorMessage = "Max 20 characters allowed.")]
    [DisplayName("Username or Email")]
    public string UserNameOrEmail { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [MaxLength(20, ErrorMessage = "Max 20 characters allowed.")]
    public string Password { get; set; }

    

}
