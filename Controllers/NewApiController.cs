using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AwsCiCdElasticBeanstalk.Controllers
{
    [RoutePrefix("api")]
    public class NewApiController : ApiController
    {
        [HttpGet]
        [Route("getmessage")]
        public string GetMessage()
        {
            return "Hello! This is a message from new api controller";
        }
    }
}
