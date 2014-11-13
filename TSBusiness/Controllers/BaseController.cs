using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TSBusiness.DataLayer;
using TSBusiness.DataLayer.Contract;
using TSBusiness.DataLayer.Repository;
using TSBusiness.Models;
using TSBusiness.Utils;

namespace TSBusiness.Controllers
{
    public class BaseController : Controller
    {
        public UserInfo CurrentUser
        {
            get {
                if (System.Web.HttpContext.Current.Session["UserInfo"] != null)
                    return (UserInfo) System.Web.HttpContext.Current.Session["UserInfo"];
                return null;
            }
            set { System.Web.HttpContext.Current.Session["UserInfo"] = value; }
        }
    }
}