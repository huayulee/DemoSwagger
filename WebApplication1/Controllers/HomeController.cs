using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Home
    /// </summary>
    public class HomeController : ApiController
    {
        /// <summary>
        /// 索引
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(Student))]
        public IHttpActionResult Index()
        {
            return Ok(new Student() { Name = "Huayu", Number = "5554432" });
        }
    }

    /// <summary>
    /// 學生
    /// </summary>
    public class Student
    {
        public string Name { get; set; }

        public string Number { get; set; }
    }

}
