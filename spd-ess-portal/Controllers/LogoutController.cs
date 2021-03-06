﻿using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Gov.Jag.Spice.Public.Controllers
{
    [Route("[controller]")]
    public class LogoutController : ControllerBase
    {
        private readonly IConfiguration Configuration;

        public LogoutController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();

            string logoutPath = string.IsNullOrEmpty(Configuration["SITEMINDER_LOGOUT_URL"]) ? "/" : Configuration["SITEMINDER_LOGOUT_URL"];
            return Redirect(logoutPath);
        }
    }
}
