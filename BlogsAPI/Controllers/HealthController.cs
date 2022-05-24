using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogsAPI.Controllers
{
    public class HealthController : ApiController
    {
        public HttpStatusCode Get()
        {
            return HttpStatusCode.OK;
        }

    }
}
