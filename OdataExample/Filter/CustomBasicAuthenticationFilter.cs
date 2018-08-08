using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;

namespace WebAPI.Filter
{
    public class CustomBasicAuthenticationFilter : BasicAuthenticationFilter
    {
        public override bool OnAuthorize(string userName, string userPassword, HttpActionContext actionContext)
        {
            if (userName == "admin" && userPassword == "password")

                return true;
            else
                return false;

        }
    }
}