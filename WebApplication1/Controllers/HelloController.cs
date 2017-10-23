using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HelloController : ApiController
    {
        /// <summary>
        /// 阿華田
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Baby()
        {
            return "Hello baby!!";
        }
    }
}
