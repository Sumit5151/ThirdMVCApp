using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThirdMVCApp.Models;

public partial class User
{
    public int Id { get; set; }

    [Required]
    [EmailAddress]
    [Remote(action: "IsEmailIdValid", controller: "User")]
    public string? Email { get; set; }
    [Required]
    [Display(Name = "First Name")]
    public string? FirstName { get; set; }
    [Required]
    [Display(Name = "Last Name")]
    public string? LastName { get; set; }

    public int? GenderId { get; set; }
    [Required]
    [RegularExpression(@"^(\+\d{1,2}\s?)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$",ErrorMessage ="Mobile number is not valid")]
    [Display(Name = "Mobile")]
    public string? MobileNumber { get; set; }

    [StringLength(20, MinimumLength = 8)]
    public string? Password { get; set; }

    public virtual Gender? Gender { get; set; }
}
