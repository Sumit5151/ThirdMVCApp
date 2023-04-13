using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThirdMVCApp.Models;

public partial class User
{
    public int Id { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }

    public int? GenderId { get; set; }
    [Required]    
    [RegularExpression(@"^(\+\d{1,2}\s?)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$")]
    public string? MobileNumber { get; set; }

    public virtual Gender? Gender { get; set; }
}
