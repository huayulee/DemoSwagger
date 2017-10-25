using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using System.ServiceModel.Channels;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Home
    /// </summary>
    public class HomeController : ApiController
    {
        [HttpGet]
        [ResponseType(typeof(Student))]
        public IHttpActionResult Index()
        {
            return Ok(@"{""Name"":""Huayu"",""Number"":""333333""}");
        }

        /// <summary>
        /// 索引
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetClientIP()
        {
            //return Ok(Request.GetOwinContext().Request.RemoteIpAddress);
            return Ok(GetClientIp());
        }

        [HttpGet]
        [ResponseType(typeof(Student))]
        public IHttpActionResult Jsonnn()
        {
            var jsonString = @"{""Name"":""Huayu"",""Number"":""333333""}";
            var obj = JsonConvert.DeserializeObject<Student>(jsonString);
            return Ok(obj);
        }

        private string GetClientIp(HttpRequestMessage request = null)
        {
            request = request ?? Request;

            if (request.Properties.ContainsKey("MS_HttpContext"))
            {
                return ((HttpContextWrapper)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            }
            else if (request.Properties.ContainsKey(RemoteEndpointMessageProperty.Name))
            {
                RemoteEndpointMessageProperty prop = (RemoteEndpointMessageProperty)request.Properties[RemoteEndpointMessageProperty.Name];
                return prop.Address;
            }
            else if (HttpContext.Current != null)
            {
                return HttpContext.Current.Request.UserHostAddress;
            }
            else
            {
                return null;
            }
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
