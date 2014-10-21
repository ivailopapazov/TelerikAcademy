namespace Articles.WebAPI.Controllers
{
        using Articles.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class BaseController : ApiController
    {
        private ArticlesData data;

        public BaseController()
        {

        }
    }
}
