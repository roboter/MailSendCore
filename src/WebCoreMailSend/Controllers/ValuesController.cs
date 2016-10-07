using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebCoreMailSend.Helpers;
using WebCoreMailSend.Models;

namespace WebCoreMailSend.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private readonly ViewRender view;
        public ValuesController(ViewRender view)
        {
            this.view = view;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var mailBodyHtml = view.Render("Email/Index", new Product { Name = "Test" });
            return new string[] { "value1" , mailBodyHtml };
        }
    }
}
