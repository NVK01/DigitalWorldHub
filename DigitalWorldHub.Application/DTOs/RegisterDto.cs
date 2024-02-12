﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWorldHub.Application.DTOs
{
    public class RegisterDto
    {

        public string DisplayName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
