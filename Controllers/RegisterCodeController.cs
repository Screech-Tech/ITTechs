﻿using ITTechs.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ITTechs.Controllers
{
    public class RegisterCodeController : Controller
    {
        public async Task<ActionResult> Register(string code)
        {
            if (Request.IsAuthenticated)
            {
                var userId = HttpContext.GetUserId();

                var registred = await SubscriptionExtensions
                    .RegisterUserSubscriptionCode(userId, code);

                if (!registred) throw new ApplicationException();

                return PartialView("_RegisterCodePartial");
            }
            return View();
        }
    }
}