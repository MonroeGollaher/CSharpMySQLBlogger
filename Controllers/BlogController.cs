using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpBlogger.Models;
using CSharpBlogger.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSharpBlogger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _bs;

        public BlogController(BlogService bs)
        {
            _bs = bs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Blog>> Get()
        {
            try
            {
                return Ok(_bs.Get());
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}