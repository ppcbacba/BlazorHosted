using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorHosted.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorHosted.Server.Controllers
{
   
    public class TestController : ControllerBase
    {
        [Route("api/test1")]
        public string Test1()
        {
            return "response 1";
        }

        [Route("api/test2")]
        public TestObject test2()
        {
            return new TestObject(){a=5,b="test string",c=0.5};
        }

        [Route("api/test3")]
        public TestObject test3([FromBody] TestObject tobj)
        {
            tobj.a += 15;
            tobj.b += " work and uses header: " + Request.Headers["headervalue"];
            tobj.c = 15;
            return tobj;
        }

        [Route("api/test4")]
        public TestObject Test4([FromForm] TestObject tobj)
        {
            tobj.a += 15;
            tobj.b += " works and uses header: " + Request.Headers["headervalue"];
            tobj.c = 15;
            return tobj;
        }
    }
}
