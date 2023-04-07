﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThirdMVCApp.Models;

public partial class User
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Gender { get; set; }
    [Required]    
    public string? MobileNumber { get; set; }
}
