using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Lab487Modulo4.Extensions;

namespace Lab487Modulo4.Controllers
{
    public class TestController : ApiController
    {

        [ResponseType(typeof(String))]
        public IHttpActionResult Get(String s)
        {
            return Ok($"Hola {s}");
        }

        [LogFiltro]
        [ResponseType(typeof(String))]
        public IHttpActionResult GetFiltrado(String s,bool filtrado)
        {
            return Ok($"Hola {s}");
        }

        [Authorize]
        [ResponseType(typeof(String))]
        public IHttpActionResult GetAuth(String s,bool auth)
        {
            return Ok($"Hola {s}");
        }
    }
}
