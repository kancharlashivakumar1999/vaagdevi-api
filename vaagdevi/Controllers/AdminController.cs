using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using vaagdevi.IRespo;

namespace vaagdevi.Controllers
{
    [EnableCors(methods: "*", headers: "*", origins: "*")]
    public class AdminController : ApiController
    {
        public readonly AdminI shiva;
        public AdminController() { }
        public AdminController(AdminI shiva) 
        {
            this.shiva = shiva;
        }
        [Route("api/Admin/fee/{id}")]
        [HttpGet]
        public IHttpActionResult FeeID(int id)
        {
            var F = shiva.Details(id);
            return Ok(F);
        }

        [Route("api/Admin/fee")]
        [HttpGet]
        public IHttpActionResult Fee()
        {
            var feee = shiva.fee();
            return Ok(feee);
        }
        [Route("api/Admin/get")]
        [HttpGet]
        public IHttpActionResult get()
        {
            var dhoni = shiva.get();
            return Ok(dhoni);
        }
        [Route("api/Admin/get/{user}/{id}")]
        [HttpGet]
        public IHttpActionResult log(string user,int id)
        {
            var status = shiva.Alog(user, id);
            
                return Ok(status);
            
        }
    }
}
