﻿
using System.Security.Claims;
using System.Web.Mvc;
using WebSite.UserData;

namespace WebSite.Views.BaseViewPage
{
    public abstract class AppViewPage<TModel> : WebViewPage<TModel>
    {
        protected AppUser CurrentUser
        {
            get
            {
                return new AppUser(this.User as ClaimsPrincipal);
            }
        }
    }

    public abstract class AppViewPage : AppViewPage<dynamic>
    {

    }
}