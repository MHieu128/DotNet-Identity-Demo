﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityDemo.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string FullName { get; set; }
    }
}
