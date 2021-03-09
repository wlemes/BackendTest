using BookSearchDomain.Aplication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBookSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private readonly IBookService _service;

        public ShippingController(IBookService service)
        {
            _service = service;
        }
        [HttpGet]
        public double Get(int id)
        {
            return _service.Shipping(id);
        }

    }
}
