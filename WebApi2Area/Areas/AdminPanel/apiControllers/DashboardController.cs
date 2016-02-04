using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi2Area.Areas.AdminPanel.apiControllers
{
    public class DashboardController : ApiController
    {
        //GET: AdminPanel/api/Dashboard/
        [HttpGet]
        public string Get()
        {
            string result = string.Empty;
            try
            {
                result = "We are in Dashboard From API2";
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return result;
        }

        //GET: AdminPanel/api/Dashboard/Get/1
        [Route("AdminPanel/api/Dashboard/Get/{id:int}")]
        [HttpGet]
        public string Get(int? id)
        {
            string result = string.Empty;
            try
            {
                result = "We are in Member - " + id + " From API2";
            }
            catch (Exception e)
            {
                e.ToString();
            }
            return result;
        }
    }
}
