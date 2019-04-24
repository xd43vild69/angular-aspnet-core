using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MVC.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {

            return new List<Product>()
            {
                new Product(){ id=1, name = "P13", category ="C1"},
                new Product(){ id=2, name = "P9", category="C2"},
                new Product(){ id=3, name = "P9", category="C2"},
                new Product(){ id=4, name = "P9", category="C2"},
                new Product(){ id=5, name = "P9", category="C2"},
                new Product(){ id=6, name = "P9", category="C2"},
                new Product(){ id=7, name = "P9", category="C2"},
                new Product(){ id=8, name = "P9", category="C2"},
                new Product(){ id=9, name = "P9", category="C2"},
                new Product(){ id=10, name = "P9", category="C2"}

            };
        }
    }
}