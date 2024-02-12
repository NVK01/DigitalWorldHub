using DigitalWorldHub.Application;
using DigitalWorldHub.Application.DTOs;
using DigitalWorldHub.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DigitalWorldHub.Server.Controllers
{
    public class ProfileController : BaseApiController
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IGenericRepository<Product> _productRepository;

        public ProfileController(IWebHostEnvironment hostingEnvironment,IGenericRepository<Product> productRepository)
        {
            _hostingEnvironment = hostingEnvironment;
            _productRepository = productRepository;
        }

        
   
    }
}
