﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
    }
}
