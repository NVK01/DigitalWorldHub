﻿using DigitalWorldHub.Core.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWorldHub.Application.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser appUser);
    }
}
