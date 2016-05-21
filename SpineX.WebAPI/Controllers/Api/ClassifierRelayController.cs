using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace SpineX.WebAPI.Controllers.Api
{
    public class ClassifierRelayController : ApiController
    {
        public JsonResult<string> GetTest()
        {
            return Json("{\"Result\": \"It's working!\"}"); 
        }


    }
}