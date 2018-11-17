using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace ProductCatalogApi.Controllers
{
    [Produces("application/json")]
    [Route("api/image")]
    public class ImageController : Controller
    {
        private readonly IHostingEnvironment _env;

        public ImageController(IHostingEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetImage(int id)
        {
            var webRoot = _env.WebRootPath;
            var path = Path.Combine(webRoot + "/Images/", "shoes-" + id + ".png");

            // convert path into image
            var buffer = System.IO.File.ReadAllBytes(path);

            return File(buffer, "image/png");
        }
    }
}