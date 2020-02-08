using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Http;
using AssetTrackerApis.Models;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

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
        public HttpResponseMessage Post(BarcodeUsers barcodeUsers)
        {
            string result = "Name: " + barcodeUsers.Username + " Password: " + barcodeUsers.Password;
            return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, result);
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