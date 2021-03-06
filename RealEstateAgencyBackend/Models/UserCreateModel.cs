﻿using System.ComponentModel.DataAnnotations;

namespace RealEstateAgencyBackend.Models
{
	public class UserCreateModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }

}