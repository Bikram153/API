﻿using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class ClientDto
    {
        [Required(ErrorMessage = "The first name is required")]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "The last name is required")]
        public string LastName { get; set; } = "";

        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Phone]
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";

        [Required]
        public string Status { get; set; } = "";//New, Permanent, Lead, Occasional, Inactive
    }
}
