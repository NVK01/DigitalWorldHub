﻿using AutoMapper;
using DigitalWorldHub.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalWorldHub.Application.DTOs;
using Microsoft.Extensions.Configuration;

namespace DigitalWorldHub.Application.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _config;

        public ProductUrlResolver(IConfiguration config) 
        { 
            _config = config;
        }
       
        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.PictureUrl)) 
            { 
                return _config["ApiUrl"] + source.PictureUrl;
            }

            return null;
        }
    }
}
