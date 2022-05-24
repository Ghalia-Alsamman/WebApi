using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
//using System.Web.Http;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Returning from TestController Get Method";
        }
    }
   

}