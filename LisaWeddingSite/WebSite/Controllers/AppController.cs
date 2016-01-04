using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using WebSite.UserData;

namespace WebSite.Controllers
{
    public abstract class AppController : Controller
    {
        public AppUser currentUser
        {
            get
            {
                return new AppUser(this.User as ClaimsPrincipal);
            }
        }
    }
}