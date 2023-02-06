using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using vaagdevi.IRespo;
using vaagdevi.Models;

namespace vaagdevi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmpController : ApiController
    {
        public readonly MarksI local;
        public EmpController(MarksI reff)
        {
            this.local = reff;
        }

        [Route("api/Marks/log/{user}/{id}")]
        [HttpGet]
        public IHttpActionResult log(string user,int id)
        {
            var shiva = local.log(user, id);
            return Ok(shiva);
        }
        [Route("api/Marks/get/{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var Ms = local.ID(id);
            return Ok(Ms);
        }
        
        [Route("api/Marks/users")]
        [HttpGet]
        public IHttpActionResult gett()
        {
            var raj = local.get();
            return Ok(raj);
        }

        [Route("api/Marks/insert")]
        [HttpPost]
        public IHttpActionResult post(UserModel s)
        {
            var shiva = local.Add(s);
            if (shiva == "inserted")
            {
                return Ok(shiva);
            }
            else if (shiva == "updated")
            {
                return Ok(shiva);
            }
            return NotFound();
        }


        [Route("api/Marks/gl")]
        [HttpGet]
        public IHttpActionResult getM()
        {
            var okk = local.getStudenets();
            return Ok(okk);
        }



        [Route("api/Marks/insertMarks")]
        [HttpPost]
        public IHttpActionResult postM(Model s)
        {
            var shiva = local.AddMarks(s);
            if (shiva == "inserted")
            {
                return Ok(shiva);
            }
            else if (shiva == "updated")
            {
                return Ok(shiva);
            }
            return NotFound();
        }

    }
}
