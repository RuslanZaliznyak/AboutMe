﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AboutMe.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public DateTime CreatedDate { get; set; }
    }
}