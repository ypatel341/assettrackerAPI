using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Http;

namespace AssetTrackerApis.Controllers
{
    public class UserController : ApiController
    {
        // GET test api
        public IEnumerable<string> Get()
        {
            return new string[] { "username", "password" };
        }

        // GET api to use for logging in username
        public string Get(int id)
        {
            return "value";
        }

        // POST api to use to create new user name or password
        public void Post([FromBody]string value)
        {
        }

        // PUT api to update a user's crendentials
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api to detele a username or user account
        public void Delete(int id)
        {
        }
    }
}